namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation quantum_initialization_centers_random (n : Int, k : Int) : Int[] {
        mutable centers = new Int[k];
        for (i in 0 .. k - 1) {
            using (qs = Qubit[n]) {
                ApplyToEach(H, qs);
                for (j in 0 .. n-1) {
                    let m = M(qs[j]);
                    if (m == One) {
                        set centers[k] = centers[k] + PowI(2, j);
                    }
                }
                ResetAll(qs);
            }
        }

        return centers;
    }

    operation quantum_initialization_centers_smart (n : Int, k : Int) : Unit {
        
    }
}