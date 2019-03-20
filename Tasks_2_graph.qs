namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation quantum_neighbourhood_graph (n : Int, k : Int) : Int[][] {
        mutable graph = initSquareMatrix(n);
        let N = PowI(2, n);
        for (i in 0 .. N - 1) {
            // find closest value for given value
            let results = quant_find_k_smallest(n, n+1, i, k);
            let distances = results[1];
            let indices = results[0];

            // iterate through closest values
            for (j in 0 .. k - 1) {
                set graph[i][indices[j]] = distances[j]; // create an edge weighted by the distance
                set graph[indices[j]][i] = distances[j]; // the graph is stored as a symmetric matrix
            }
        }
        return graph;
    }

    operation quantum_detection_outlier (data : Qubit[], n : Int, k : Int, w : Int) : Int[] {
        let graph = quantum_neighbourhood_graph(data, n, k); // generate neighborhood graph
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