namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Diagnostics;

    operation tests () : Unit {
        comp_test();
    }

    operation comp_test () : Unit { 
        using (A = Qubit[4]) {
            using (B = Qubit[4]) {
                using (b = Qubit()) {
                    using (garb = Qubit[4]) {
                        X(B[2]);
                        X(A[1]);
                        TC_comparator(A, B, b, garb);
                        DumpRegister("comp_garbage.txt", garb);
                        if (M(b) == One) {
                            Message("1");
                        } else {
                            Message("0");
                        }
                        ResetAll(A);
                        ResetAll(B);
                        Reset(b);
                        ResetAll(garb);
                    }
                }
            }
        }
    }

    operation SCG_sub_test () : Unit {
        using (A = Qubit[4]) {
            using (B = Qubit[4]) {
                using (carry = Qubit()) {
                    using (Target = Qubit[4]) {
                        X(A[1]);
                        X(B[1]);
                        X(B[0]);
                        DumpRegister("adder_testing_0.txt", A);
                        DumpRegister("adder_testing_0b.txt", B);
                        TC_add_sub(true, A, B, carry, Target);
                        DumpRegister("adder_testing_1.txt", A);
                        DumpRegister("adder_testing_1b.txt", B);
                        DumpRegister("adder_testing_1T.txt", Target);
                        ResetAll(A);
                        ResetAll(B);
                        Reset(carry);
                        ResetAll(Target);
                    }
                }
            }
        }
    }

    operation SCG_adder_test () : Unit {
        using (A = Qubit[4]) {
            using (B = Qubit[4]) {
                using (carry = Qubit()) {
                    using (Target = Qubit[4]) {
                        X(A[1]);
                        X(B[1]);
                        X(B[0]);
                        DumpRegister("adder_testing_0.txt", A);
                        DumpRegister("adder_testing_0b.txt", B);
                        TC_add_sub(false, A, B, carry, Target);
                        DumpRegister("adder_testing_1.txt", A);
                        DumpRegister("adder_testing_1b.txt", B);
                        DumpRegister("adder_testing_1T.txt", Target);
                        ResetAll(A);
                        ResetAll(B);
                        Reset(carry);
                        ResetAll(Target);
                    }
                }
            }
        }
    }

    operation SCG_int_adder_test () : Unit {
        using (A = Qubit[4]) {
            using (B = Qubit[4]) {
                using (carry = Qubit()) {
                    X(A[1]);
                    DumpRegister("adder_testing_0.txt", A);
                    DumpRegister("adder_testing_0b.txt", B);
                    TC_add_int(3, A, carry, B);
                    DumpRegister("adder_testing_1.txt", A);
                    DumpRegister("adder_testing_1b.txt", B);
                    ResetAll(A);
                    ResetAll(B);
                    Reset(carry);
                }
            }
        }
    }
}