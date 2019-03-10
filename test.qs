namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Diagnostics;

    operation tests () : Unit {
        using (A = Qubit[3]) {
            using (B = Qubit[3]) {
                X(B[0]);
                X(B[2]);
                X(A[1]);
                DumpRegister("adder_testing_0.txt", A);
                DumpRegister("adder_testing_0b.txt", B);
                experimental_adder(A, B);
                DumpRegister("adder_testing_1.txt", A);
                DumpRegister("adder_testing_1b.txt", B);
                ResetAll(A);
                ResetAll(B);
            }
        }
    }
}