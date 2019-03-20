namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Diagnostics;
    open Microsoft.Quantum.Extensions.Convert;

    /// # Summary
    /// Tests for all adders, comparators, and rotations
    ///
    /// # Example
    /// ```Q#
    /// tests();
    /// ```
    operation tests () : Unit {
        thorough_adder_test(4);
        // thorough_comp_test(4);
        // test_rzk();
    }


    /// # Summary
    /// Tests Rz_k gate on single qubit for some rotation
    ///
    /// # Example
    /// ```Q#
    /// test_rzk();
    /// ```
    operation test_rzk() : Unit {
        using (A = Qubit()) {
            X(A); // set A = 1 (or some value)
            Rzk(A, 1.0); // rotate A by R1
            DumpRegister("tests/rzk_test.txt", [A]);
            Reset(A);
        }
    }

    /// # Summary
    /// Tests all possible additions for n-bit adder
    ///
    /// # Example
    /// ```Q#
    /// thorough_adder_test(4);
    /// ```
    operation thorough_adder_test (n : Int) : Unit {
        let N = PowI(2, n);
        using (A = Qubit[n]) {
            using (B = Qubit[n]) {
                for (i in 0..N-1) {
                    for (j in 0..N-1) {
                        IntegerIncrementLE(i, BigEndianToLittleEndian(BigEndian(A))); // set A = i
                        IntegerIncrementLE(j, BigEndianToLittleEndian(BigEndian(B))); // set B = j
                        efficient_adder(A, B);
                        let r = ToStringI(MeasureIntegerBE(BigEndian(A))); // prints A+B
                        let b = ToStringI(MeasureIntegerBE(BigEndian(B))); // prints B
                        let a = ToStringI(i); // prints i (should be what A was)
                        // Message(a + " + " + b + " = " + r);
                        ResetAll(A);
                        ResetAll(B);
                    }
                }
            }
        }
    }
    
    /// # Summary
    /// Tests all possible  combinations for n-bit comparator
    ///
    /// # Example
    /// ```Q#
    /// thorough_comp_test(4);
    /// ```
    operation thorough_comp_test (n : Int) : Unit {
        let N = PowI(2, n);
        using (A = Qubit[n]) {
            using (B = Qubit[n]) {
                using (c = Qubit()) {
                    for (i in 0..N-1) {
                        for (j in 0..N-1) {
                            IntegerIncrementLE(i, BigEndianToLittleEndian(BigEndian(A))); // set A = i
                            IntegerIncrementLE(j, BigEndianToLittleEndian(BigEndian(B))); // set B = j
                            efficient_TC_comparator(A, B, c);
                            let r = ToStringB((M(c) == One)); // prints if A > B
                            let b = ToStringI(MeasureIntegerBE(BigEndian(B))); // prints B
                            let a = ToStringI(MeasureIntegerBE(BigEndian(A))); // prints A
                            // Message(a + " > " + b + " is " + r);
                            ResetAll(A);
                            ResetAll(B);
                            Reset(c);
                        }
                    }
                }
            }
        }
    }
}