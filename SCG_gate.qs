namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    // from "Realization of a Novel Reversible SCG Gate and its
    // "Application for Designing Parallel Adder/Subtractor
    // and Match Logic" by Diganta Sengupta, Mahamuda Sultana, and Atal Chaudhuri
    // https://pdfs.semanticscholar.org/2e0e/2a716f9e93851bee0e39c17f9adb1757908f.pdf?_ga=2.170849696.1610892819.1552011944-1235957452.1552011944

    // output[0] = input[1] * ¬input[2] + input[2] * ¬input[3]
    // output[1] = (input[0] + input[2])*(input[1] ⊕ input[3]) + input[1] * input[2]
    // output[2] = input[3] ⊕ input[2] ⊕ input[0]
    // output[3] = input[3] ⊕ input[2] ⊕ input[1]
    operation SCG (input : Qubit[], output : Qubit[]) : Unit {
        body (...) {
            if (Length(input) != 4 || Length(output) != 4) {
                fail "Eror: Improper SCG gate usage";
            }

            (ControlledOnBitString([true, false], X))([input[1], input[2]], output[0]);
            (ControlledOnBitString([true, false], X))([input[2], input[3]], output[0]);

            (ControlledOnBitString([true, true, false, false], X))([input[0], input[1], input[2], input[3]], output[1]);
            (ControlledOnBitString([false, true, true, false], X))([input[0], input[1], input[2], input[3]], output[1]);
            (ControlledOnBitString([true, false, true, false], X))([input[0], input[1], input[2], input[3]], output[1]);
            (ControlledOnBitString([true, true, true, false], X))([input[0], input[1], input[2], input[3]], output[1]);
            (ControlledOnBitString([true, false, false, true], X))([input[0], input[1], input[2], input[3]], output[1]);
            (ControlledOnBitString([false, false, true, true], X))([input[0], input[1], input[2], input[3]], output[1]);
            (ControlledOnBitString([true, true, false, false], X))([input[0], input[1], input[2], input[3]], output[1]);
            (ControlledOnBitString([true, true, false, true], X))([input[0], input[1], input[2], input[3]], output[1]);

            CNOT(input[3], output[2]);
            CNOT(input[2], output[2]);
            CNOT(input[0], output[2]);

            CNOT(input[3], output[3]);
            CNOT(input[2], output[3]);
            CNOT(input[1], output[3]);
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation SCG_bit_adder (A : Qubit, B : Qubit, carry : Qubit, Target : Qubit) : Unit {
        body (...) {
            CNOT(A, Target);
            CNOT(B, Target);
            CNOT(carry, Target);

            CCNOT(A, B, carry);
            CCNOT(A, B, carry);
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation experimental_adder (A : Qubit[], B : Qubit[]) : Unit {
        body (...) {
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }
}