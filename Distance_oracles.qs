namespace Final_Project {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation distance_add(i : Qubit[], j : Qubit[], target : Qubit[], distances : Int[]) : Unit {
        body (...) {
            index_to_distance(i + j, target, distances);
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation distance_cmp(d1 : Qubit[], d2 : Qubit[], target : Qubit) : Unit {
        body (...) {
            efficient_TC_comparator(d1, d2, target);
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation index_to_distance(index : Qubit[], target : Qubit[], distances: Int[]) : Unit {
        body (...) {
            for(i in 0..255) {
                let bool_i = int_to_boolsBE(i, Length(index));
                (ControlledOnBitString(bool_i, IIBE_wrap(i, _, distances)))(index, target);
            }
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation IIBE_wrap(i: Int, qs: Qubit[], distances: Int[]) : Unit{
        body (...) {
            IntegerIncrementBE(distances[i], qs);
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation IntegerIncrementBE(i: Int, qs: Qubit[]) : Unit {
        body (...) {
            IntegerIncrementLE(i, BigEndianToLittleEndian(BigEndian(qs)));
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }
}
