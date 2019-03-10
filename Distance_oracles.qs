namespace Final_Project {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation distance_add(i : Qubit[], j : Qubit[], target : Qubit[], distances : Int[]) : Unit {
        body (...) {

        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation distance_cmp(target : Qubit) : Unit {
        body (...) {
            // ...
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation index_to_distance(index : Qubit[], distances: Int[], target : Qubit[]) : Unit {
        body (...) {
            for(i in 0..255) {
                let bool_i = int_to_boolsBE(i);
                //(ControlledOnBitString(bool_i, TC_add_int(distances[i], _)))(index, target);
            }
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }
}