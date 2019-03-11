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

    operation distance_cmp(d1 : Qubit[], d2 : Qubit[], target : Qubit) : Unit {
        body (...) {
            // What should be garbage? Doesn't need to be adjointable I think
            using (garbage = Qubit[Length(d1)]) {
                TC_comparator(d1, d2, target, garbage);
                ResetAll(garbage);
            }
        }
    }

    operation index_to_distance(index : Qubit[], distances: Int[], target : Qubit[]) : Unit {
        body (...) {
            for(i in 0..255) {
                let bool_i = int_to_boolsBE(i);
                using (stub = Qubit[Length(target)]) {
                    // What do I do with carry? NEEDS TO BE REVERSIBLE
                    (ControlledOnBitString(bool_i, IntegerIncrementLE_wrap(i, _, distances)))(index, target);
                }
            }
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation IntegerIncrementLE_wrap(i: Int, qs: Qubit[], distances: Int[]) : Unit {
        body (...) {
            IntegerIncrementLE(distances[i], BigEndianToLittleEndian(BigEndian(qs)));
        }
        
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }
}