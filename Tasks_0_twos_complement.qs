namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Convert;

    // from "QUANTUM ADDER OF CLASSICAL NUMBERS"
    // by A.V. Cherkas and S.A. Chivilikhin
    // https://iopscience.iop.org/article/10.1088/1742-6596/735/1/012083/pdf
    operation Rzk (q : Qubit, k : Double) : Unit {
        body (...) {
            ApplyDiagonalUnitary([0.0, 2.0*PI()/PowD(2.0, k)], BigEndian([q]));
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation efficient_adder (A : Qubit[], B : Qubit[]) : Unit {
        body (...) {
            let N = Length(A);
            let P = Length(B);
            if (N != P) {
                fail "Eror: improper quantum adder usage";
            }   
            QFT((BigEndian(A)));
            for (i in 0..N-1) {
                for (j in 0..i) {
                    Controlled Rzk([A[N-j-1]], (B[i], ToDouble(i-j+1)));
                }
            }
            Adjoint QFT((BigEndian(A)));
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }   
    
    operation efficient_TC_comparator (d : Qubit[], dmax : Qubit[], target : Qubit) : Unit {
        body(...) {
            let N = Length(d);
            let P = Length(dmax);
            if (N != P) {
                fail "Eror: improper efficient_TC_comparator usage";
            }
            (ControlledOnBitString([false, true], X))([d[0], dmax[0]], target);
            using (dmax_tmp = Qubit()) {
                CNOT(dmax[0], dmax_tmp);
                Adjoint efficient_adder(dmax, d);
                (ControlledOnBitString([false, false, true], X))([d[0], dmax_tmp, dmax[0]], target);
                (ControlledOnBitString([true, true, true], X))([d[0], dmax_tmp, dmax[0]], target);
                efficient_adder(dmax, d);
                CNOT(dmax[0], dmax_tmp);
            }
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }
}
