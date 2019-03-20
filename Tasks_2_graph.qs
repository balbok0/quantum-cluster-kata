namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation quantum_neighbourhood_graph (n : Int, m : Int, indices: Int[], k : Int, distances: Int[]) : Int[][] {
        mutable graph = initSquareMatrix(n);
        let N = PowI(2, n);
        for (i in 0 .. N - 1) {
            // find closest value for given value
            let results = quant_find_k_smallest(n, m, indices, k, distances);
            let close_distances = results[1];
            let close_indices = results[0];

            // iterate through closest values
            for (j in 0 .. k - 1) {
                set graph[i][close_indices[j]] = close_distances[j]; // create an edge weighted by the distance
                set graph[close_indices[j]][i] = close_distances[j]; // the graph is stored as a symmetric matrix
            }
        }
        return graph;
    }

    operation quantum_detection_outlier (n : Int, m : Int, indices: Int[], k : Int, w : Int, distances: Int[]) : Int[] {
        let graph = quantum_neighbourhood_graph(n, m, indices, k, distances); // generate neighborhood graph
        let N = PowI(2, n);
        mutable outliers = new Int[N];
        for (i in 0 .. N - 1) {
            // sum distances associated with value
            mutable sum = 0;
            for (j in 0 .. k - 1) {
                set sum = sum + graph[i][j];
            }

            // if distances are sufficiently large, it is an outlier
            if (sum > w) {
                set outliers[i] = 1;
            }
        }
        return outliers;
    }
}