namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation quant_find_max (n: Int, dist_oracle: ((Qubit[], Qubit[], Qubit) => Unit : Controlled, Adjoint)) : (Int, Int) {
        mutable d_max = 0.0;
        using (d_max_qubit = Qubit()) {
            using ((i, j, dist_qubit, phase_qubit) = (Qubit[n], Qubit[n], Qubit(), Qubit())) {
                dist_oracle(i, j, dist_qubit);
                H(phase_qubit);

                H(phase_qubit);
                Adjoint dist_oracle(i, j, dist_qubit);
            }
        }
        return (0, 0);
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
