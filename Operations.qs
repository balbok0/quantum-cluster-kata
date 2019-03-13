namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation quant_find_max (n: Int, m: Int, indices: Int[], distances: Int[]) : (Int, Int) {
        mutable prev_i = 0;
        mutable prev_j = 0;
        mutable curr_dist = 0;
        mutable not_bigger = false;

        // This external for loop is sanity check.
        repeat {
            using ((i, j) = (Qubit[n], Qubit[n])) {
                // Superposition of indices
                ApplyToEach(H, i);
                ApplyToEach(H, j);
                using (d_max = Qubit[m]) {
                    repeat {
                        using ((dist, phase_qubit) = (Qubit[m], Qubit())) {                        
                            distance_add(i, j, dist, distances);
                            distance_cmp(dist, d_max, phase_qubit);
                            Adjoint distance_add(i, j, dist, distances);

                            if(M(phase_qubit) == Zero) {
                                set not_bigger = true;
                            } else { // It was bigger
                                set prev_i = MeasureIntegerBE(BigEndian(i));
                                set prev_j = MeasureIntegerBE(BigEndian(j));

                                // Set d_max to dist
                                ResetAll(d_max);
                                efficient_adder(d_max, dist);
                                
                                // Reset distances, since they collapsed
                                ResetAll(i);
                                ResetAll(j);
                                ApplyToEach(H, i);
                                ApplyToEach(H, j);
                            }
                            Reset(phase_qubit);
                            ResetAll(dist);
                        }
                    } until (not_bigger)
                    fixup {
                    }

                    ResetAll(d_max);
                }
                ResetAll(i);
                ResetAll(j);
            }
        } until (prev_i == 0 && prev_j == 0)
        // Sanity check. 
        // Should be executed only once, unless some edge case happens
        fixup {
        }

        return (prev_i, prev_j);
    }

    operation GroversHelper(i : Qubit[], j : Qubit[], oracle : (Qubit[] => Unit : Adjoint)) : Unit {
        
        body (...) {
        
        }
        
        adjoint invert;
    }

    operation OracleConverterImpl_Reference (markingOracle : ((Qubit[], Qubit[], Qubit) => Unit : Adjoint), i : Qubit[], j : Qubit[]) : Unit {    
        body (...) {
            using (target = Qubit()) {
                // Put the target into the |-⟩ state
                X(target);
                H(target);
                
                // Apply the marking oracle; since the target is in the |-⟩ state,
                // flipping the target if the register satisfies the oracle condition will apply a -1 factor to the state
                markingOracle(i, j, target);
                
                // Put the target back into |0⟩ so we can return it
                H(target);
                X(target);
            }
        }
        
        adjoint invert;
    }
    
    
    function OracleConverter_Reference (markingOracle : ((Qubit[], Qubit[], Qubit) => Unit : Adjoint)) : ((Qubit[], Qubit[]) => Unit : Adjoint) {
        return OracleConverterImpl_Reference(markingOracle, _, _);
    }

    operation GroversSearch_Reference (i: Qubit[], j: Qubit[], oracle : ((Qubit[], Qubit[], Qubit) => Unit : Adjoint), iterations : Int) : Unit {
        
        body (...) {
            let phaseOracle = OracleConverter_Reference(oracle);
            HadamardTransform_Reference(i);
            HadamardTransform_Reference(j);

            for (_ in 1 .. iterations) {
                GroverIteration_Reference(i, j, phaseOracle);
            }
        }
        
        adjoint invert;
    }
    
    operation GroverIteration_Reference (i : Qubit[], j : Qubit[], oracle : ((Qubit[], Qubit[]) => Unit : Adjoint)) : Unit {
        
        body (...) {
            oracle(i, j);
            HadamardTransform_Reference(i);
            HadamardTransform_Reference(j);

            ConditionalPhaseFlip_Reference(i, j);

            HadamardTransform_Reference(i);
            HadamardTransform_Reference(j);
        }
        
        adjoint invert;
    }

    operation HadamardTransform_Reference (register : Qubit[]) : Unit {
        
        body (...) {
            ApplyToEachA(H, register);
        }
        
        adjoint invert;
    }

    operation ConditionalPhaseFlip_Reference (i : Qubit[], j: Qubit[]) : Unit {
        body (...) {
            // TODO: Go from all zeros to actual indexes.
            let pattern_i = new Bool[Length(i)];
            let pattern_j = new Bool[Length(j)];
            // Define a marking oracle which detects an all zero state
            let allZerosOracle = Oracle_ArbitraryPattern_Reference(_, _, _, pattern_i, pattern_j);
            
            // Convert it into a phase-flip oracle and apply it
            let flipOracle = OracleConverter_Reference(allZerosOracle);
            flipOracle(i, j);
        }
        adjoint self;
    }

    operation Oracle_ArbitraryPattern_Reference (i : Qubit[], j: Qubit[], target : Qubit, pattern_i : Bool[], pattern_j : Bool[]) : Unit {
        
        body (...) {
            (ControlledOnBitString(pattern_i + pattern_j, X))(i + j, target);
        }
        
        adjoint invert;
    }
}
