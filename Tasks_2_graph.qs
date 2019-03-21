namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Convert;

    /// # Summary
    /// Creates Neighbourhood Graph where edges are formed between every point and the centers
    /// where the centers are chosen by quant_find_k_smallest
    /// and edges are weighted by the distance to the center
    ///
    /// # Input
    /// ## n
    /// Number of qubits required to represent indices
    /// ## m
    /// Number of qubits required to represent distance between any 2 points
    /// ## indices
    /// Indices of datapoints over which to look for pair of points.
    /// ## distances
    /// Distances between two points where distances[c] is 
    /// distance between points c0, c1, such that c0 = c / n; c1 = c % n.
    /// ## k
    /// Number of centers for quant_find_k_smallest to find
    ///
    /// # Example
    /// ```Q#
    /// let graph = quantum_neighbourhood_graph(n, m, indices, k, distances);
    /// ```
    operation quantum_neighbourhood_graph (n : Int, m : Int, indices: Int[], k : Int, distances: Int[]) : Int[][] {
        let N = PowI(2, n);
        mutable graph = initSquareMatrix(N);
        for (i in 0 .. N - 1) {
            // find closest values for given value
            let results = quant_find_k_smallest(N, m, indices, k, distances);

            // iterate through closest values
            for (j in 0 .. k - 1) {
                set graph[i][results[j][0]] = distances[i*SqrtI(Length(distances)) + results[j][0]]; // create an edge weighted by the distance
                set graph[results[j][0]][i] = distances[results[j][0]*SqrtI(Length(distances)) + i]; // the graph is stored as a symmetric matrix
            }
        }
        return graph;
    }

    /// # Summary
    /// Uses Neighbourhood Graph to calculate the sume of the distances
    /// from every point to k centers, then marks points with a sum greater than w
    /// as outliers and returns those marks
    ///
    /// # Input
    /// ## n
    /// Number of qubits required to represent indices
    /// ## m
    /// Number of qubits required to represent distance between any 2 points
    /// ## indices
    /// Indices of datapoints over which to look for pair of points.
    /// ## k
    /// Number of centers for quant_find_k_smallest to find
    /// ## w
    /// threshold for distinguishing outliers
    /// ## distances
    /// Distances between two points where distances[c] is 
    /// distance between points c0, c1, such that c0 = c / n; c1 = c % n.
    ///
    /// # Example
    /// ```Q#
    /// let outliers = quantum_detection_outlier (n, m, indices, k, w, distances);
    /// ```
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

            // print distances
            Message(ToStringI(sum));
            // if distances are sufficiently large, it is an outlier
            if (sum > w) {
                set outliers[i] = 1;
            }
        }
        return outliers;
    }
}