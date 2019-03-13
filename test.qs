namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Diagnostics;
    open Microsoft.Quantum.Extensions.Convert;

    operation tests () : Unit {
        thorough_comp_test();
    }

    operation test_rzk() : Unit {
        using (A = Qubit()) {
            X(A);
            Rzk(A, 1.0);
            DumpRegister("rzk_test.txt", [A]);
            Reset(A);
        }
    }

    operation thorough_adder_test () : Unit {
        let n = 4;
        let N = PowI(2, n);
        using (A = Qubit[n]) {
            using (B = Qubit[n]) {
                for (i in 0..N-1) {
                    for (j in 0..N-1) {
                        IntegerIncrementLE(i, BigEndianToLittleEndian(BigEndian(A)));
                        IntegerIncrementLE(j, BigEndianToLittleEndian(BigEndian(B)));
                        efficient_adder(A, B);
                        let r = ToStringI(MeasureIntegerBE(BigEndian(A)));
                        let b = ToStringI(MeasureIntegerBE(BigEndian(B)));
                        let a = ToStringI(i);
                        Message(a + " + " + b + " = " + r);
                        ResetAll(A);
                        ResetAll(B);
                    }
                }
            }
        }
    }

    operation thorough_comp_test () : Unit {
        let n = 4;
        let N = PowI(2, n);
        using (A = Qubit[n]) {
            using (B = Qubit[n]) {
                using (c = Qubit()) {
                    for (i in 0..N-1) {
                        for (j in 0..N-1) {
                            IntegerIncrementLE(i, BigEndianToLittleEndian(BigEndian(A)));
                            IntegerIncrementLE(j, BigEndianToLittleEndian(BigEndian(B)));
                            efficient_TC_comparator(A, B, c);
                            let r = ToStringB((M(c) == One));
                            let b = ToStringI(MeasureIntegerBE(BigEndian(B)));
                            let a = ToStringI(MeasureIntegerBE(BigEndian(A)));
                            Message(a + " > " + b + " is " + r);
                            ResetAll(A);
                            ResetAll(B);
                            Reset(c);
                        }
                    }
                }
            }
        }
    }

    operation exp_adder_test () : Unit {
        using (A = Qubit[4]) {
            using (B = Qubit[4]) {
                X(A[2]);
                X(B[1]);
                X(B[3]);
                DumpRegister("adder_testing_0.txt", A);
                DumpRegister("adder_testing_0b.txt", B);
                Adjoint efficient_adder(A, B);
                DumpRegister("adder_testing_1.txt", A);
                DumpRegister("adder_testing_1b.txt", B);
                efficient_adder(A, B);
                DumpRegister("adder_testing_2.txt", A);
                DumpRegister("adder_testing_2b.txt", B);
                ResetAll(A);
                ResetAll(B);
            }
        }
    }

    operation exp_comp_test () : Unit { 
        using (A = Qubit[4]) {
            using (B = Qubit[4]) {
                using (b = Qubit()) {
                        X(B[2]);
                        X(A[1]);
                        DumpRegister("comp_testing_0.txt", A);
                        DumpRegister("comp_testing_0b.txt", B);
                        efficient_TC_comparator(A, B, b);
                        if (M(b) == One) {
                            Message("1");
                        } else {
                            Message("0");
                        }
                        ResetAll(A);
                        ResetAll(B);
                        Reset(b);
                }
            }
        }
    }
}