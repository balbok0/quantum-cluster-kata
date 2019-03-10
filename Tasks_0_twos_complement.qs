namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    // from "A novel reversible two's complement gate (TCG) and its quantum mapping"
    // by Ayan Chaudhuri ; Mahamuda Sultana ; Diganta Sengupta ; Atal Chaudhuri
    // https://ieeexplore.ieee.org/document/8073946

    // test if handles negatives properly
    operation TC_prepare(a : Int, TC : Qubit[]) : Unit {
        body(...) {
            let N = Length(TC);
            mutable bools = int_to_boolsBE(a);
            for (i in 0..N-1) {
                if (bools[i]) {
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
                fail "Eror: Only N = 4 Currently Implemented for TC_negate";
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

    operation TC_add_sub(sub : Bool, TC_A : Qubit[], TC_B : Qubit[], carry : Qubit, TC_target : Qubit[]) : Unit {
        body(...) {
            let N = Length(TC_A);
            let P = Length(TC_B);
            let Q = Length(TC_target);
            if (N != P || N != Q) {
                fail "Eror: improper TC_add_sub usage";
            }

            if (sub) {
                X(carry);
                for (i in 0..N-1) {
                    X(TC_B[i]);
                }
            }

            for (i in 0..N-1) {
                SCG_bit_adder(TC_A[i], TC_B[i], carry, TC_target[i]);
            }
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation P_comparator(d : Qubit[], dmax : Qubit[], b : Qubit) : Unit {
        body(...) {
            let N = Length(d);
            let P = Length(dmax);
            if (N != P) {
                fail "Eror: improper Pcomparator usage";
            }
            
            
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation TC_add_int(INT_A : Int, TC_B : Qubit[], carry : Qubit, TC_target : Qubit[]) : Unit {
        body(...) {
            let N = Length(TC_B);
            let P = Length(TC_target);
            if (N != P) {
                fail "Eror: improper TC_add_int usage";
            }
            using (TC_A = Qubit[N]) {
                TC_prepare(INT_A, TC_A);
                TC_add_sub(false, TC_A, TC_B, carry, TC_target);
                TC_prepare(INT_A, TC_A); // de-prepares TC_A
            }  
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }


}

