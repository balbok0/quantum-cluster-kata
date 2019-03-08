namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation quantum_neighbourhood_graph (data : Qubit[], n : Int, k : Int) : Int[][] {
        mutable graph = initSquareMatrix(n);
        for (i in 0 .. n - 1) {
            // indices, distances = quant_find_smallest_values(data[i], k);
            for (j in 0 .. k - 1) {
                // graph[data[i], indices[j]] = distances[j]
                // graph[indices[j], data[i]] = distances[j]
            }
        }
        return graph;
    }

    operation quantum_detection_outlier (data : Qubit[], n : Int, k : Int, w : Int) : Int[] {
        let graph = quantum_neighbourhood_graph(data, n, k);
        mutable outliers = new Int[n];
        for (i in 0 .. n - 1) {
            // indices, distances = quant_find_smallest_values(data[i], k);
            mutable sum = 0;
            for (j in 0 .. k - 1) {
                // set sum = sum + distances[j]
            }
            if (sum > w) {
                set outliers[i] = 1;
            }
        }
        return outliers;
    }
}