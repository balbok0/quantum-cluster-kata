namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Convert;

    operation TC_prepare(a : Int, TC : Qubit[]) : Unit {
        body(...) {
            let N = Length(TC);
            let bools = BigIntToBools(ToBigInt(a));
            for (i in 0 .. N - 1) {
                if(bools[i] == true) {
                    X(TC[i]);
                }
            }
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation TC_negate(TC : Qubit[]) : Unit {
        body(...) {
            let N = Length(TC);
            if (N != 4) {
                Message("Eror: Only N = 4 Currently Implemented");
            }

            Controlled X([TC[0], TC[1], TC[2]], TC[3]);
            Controlled X([TC[1], TC[2]], TC[3]);
            Controlled X([TC[0], TC[2]], TC[3]);
            Controlled X([TC[0], TC[1]], TC[2]);
            Controlled X([TC[2]], TC[3]);
            Controlled X([TC[1]], TC[3]);
            Controlled X([TC[1]], TC[2]);
            Controlled X([TC[0]], TC[3]);
            Controlled X([TC[0]], TC[2]);
            Controlled X([TC[0]], TC[1]);
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    // also do int adder
    operation TC_add_int(INT_A : Int, TC_B : Qubit[]) : Unit {
        body(...) {

        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation TC_add(TC_A : Qubit[], TC_B : Qubit[]) : Unit {
        body(...) {
            let N = Length(TC_A);
            let P = Length(TC_B);
            if (N != 4) {
                Message("Eror: Only N = 4 Currently Implemented");
            }
            if (N != P) {
                Message("Eror: Only N = 4 Currently Implemented");
            }
            
            
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

}