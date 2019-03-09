namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    
    // output[0] = input[1] * ¬input[2] + input[2] * ¬input[3]
    // output[1] = (input[0] + input[2])*(input[1] ⊕ input[3]) + input[1] * input[2]
    // output[2] = input[3] ⊕ input[2] ⊕ input[0]
    // output[3] = input[3] ⊕ input[2] ⊕ input[1]
    operation SCG (input : Qubit[], output : Qubit[]) : Unit {
        body (...) {
            if (Length(input) != 4 || Length(output) != 4) {
                Message("Eror: Improper SCG gate usage");
            }

            (ControlledOnBitString([true, false], X))([input[1], input[2]], output[0]);
            (ControlledOnBitString([true, false], X))([input[2], input[3]], output[0]);
            (ControlledOnBitString([true, false, true, false], X))([input[1], input[2], input[2], input[3]], output[0]);

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
}