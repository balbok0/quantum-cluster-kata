namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Convert;

    // from "QUANTUM ADDER OF CLASSICAL NUMBERS"
    // by A.V. Cherkas and S.A. Chivilikhin
    // https://iopscience.iop.org/article/10.1088/1742-6596/735/1/012083/pdf

    /// # Summary
    /// create gate described by matrix [1 0; 0 e^(2*i*PI/2^k)]
    ///
    /// # Input
    /// ## q
    /// qubit being rotated.
    /// ## k
    /// Amount to rotate, defined by above equation.
    ///
    /// # Example
    /// ```Q#
    /// // often used as a controlled rotation
    /// Controlled Rzk([A], (B, 1.0)); 
    /// ```
    operation Rzk (q : Qubit, k : Double) : Unit {
        body (...) {
            ApplyDiagonalUnitary([0.0, 2.0*PI()/PowD(2.0, k)], BigEndian([q]));
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    /// # Summary
    /// Adder that takes A, B -> A+B, B
    /// Uses QFT cascading design described in paper
    ///
    /// # Input
    /// ## A
    /// operand. Will become A+B.
    /// ## B
    /// operand. Remains B.
    ///
    /// # Example
    /// ```Q#
    /// efficient_adder(A, B);
    /// ```
    operation efficient_adder (A : Qubit[], B : Qubit[]) : Unit {
        body (...) {
            let N = Length(A);
            let P = Length(B);

            // length of A, B must be the same
            if (N != P) {
                fail "Eror: improper quantum adder usage";
            }   

            QFT((BigEndian(A))); // apply fourier transform
            for (i in 0..N-1) {
                for (j in 0..i) {
                    // rotate lower bits according controlled on higher bits
                    Controlled Rzk([A[N-j-1]], (B[i], ToDouble(i-j+1))); 
                }
            }
            Adjoint QFT((BigEndian(A))); // undo fourier transform
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }   
    

    /// # Summary
    /// Compares d and dmax
    /// d, dmax, target -> d, dmax, (d > dmax)⊕target
    /// uses 1 extra qubit in function
    ///
    /// # Input
    /// ## d
    /// Unchanged operand.
    /// ## dmax
    /// Unchanged operand.
    /// ## target
    /// Flipped if d > dmax
    ///
    /// # Example
    /// ```Q#
    /// using (target = Qubit()) {
    ///     efficient_TC_comparator(A, B, target);
    ///     // do stuff with knowledge of d > dmax
    ///     efficient_TC_comparator(A, B, target); // reset target
    /// }
    /// ```
    operation efficient_TC_comparator (d : Qubit[], dmax : Qubit[], target : Qubit) : Unit {
        body(...) {
            let N = Length(d);
            let P = Length(dmax);

            // d, dmax must be the same length
            if (N != P) {
                fail "Eror: improper efficient_TC_comparator usage";
            }
            // if dmax is negative and d is positive, d > dmax
            (ControlledOnBitString([false, true], X))([d[0], dmax[0]], target);

            using (dmax_tmp = Qubit()) {
                CNOT(dmax[0], dmax_tmp); // store sign bit of dmax in dmax_tmp
                Adjoint efficient_adder(dmax, d); // subtract d from dmax and store in dmax

                // if dmax and d are positive and dmax - d is negative, d > dmax
                (ControlledOnBitString([false, false, true], X))([d[0], dmax_tmp, dmax[0]], target);

                // if dmax and d are negative and dmax - d is positive, d > dmax
                (ControlledOnBitString([true, true, true], X))([d[0], dmax_tmp, dmax[0]], target);

                efficient_adder(dmax, d); // undo subtraction
                CNOT(dmax[0], dmax_tmp); // undo temporary storage
            }
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }
}
