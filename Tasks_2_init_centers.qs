namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation quantum_initialization_centers_random (n : Int, k : Int) : Int[] {
        mutable centers = new Int[k];
        for (i in 0 .. k - 1) {
            set centers[k] = RandomInt(n);
        }
        return centers;
    }

    
    operation quantum_initialization_centers_smart (n : Int, k : Int, data : Qubit[]) : Int[] {
        mutable centers = new Int[k];
    
        set centers[0] = RandomInt(n);
        // centers[1] = quant_find_max(centers[0], data);
        for (i in 2 .. k - 1) {
            // centers[i] = distance_oracle(centers, data);
        }
    
        return centers;
    }
}