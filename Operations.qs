namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Convert;

    operation quant_find_max (n: Int, m: Int, indices: Int[], distances: Int[]) : (Int, Int) {
        mutable prev_i = 0;
        mutable prev_j = 0;

        if (Length(indices) < 2) {
            fail "There need to be at least 2 indices to be found.";
        }

        // It's obvious, and Grover might not work in this case ([0, 1, 1, 0] with 2 points)
        if (Length(indices) == 2) {
            return (indices[0], indices[1]);
        }

        // This external for loop is sanity check.
        using ((i, j) = (Qubit[n], Qubit[n])) {
            // Superposition of indices

            using (d_max = Qubit[m]) {
                repeat { // Modified Grover's
                    using ((dist, phase_qubit) = (Qubit[m], Qubit())) {
                        prep_indices(indices, i);
                        prep_indices(indices, j);

                        distance_add(i, j, dist, distances);
                        GroversSearch(dist, d_max, phase_qubit, distance_cmp, Length(indices) * Length(indices) / 2);  // There are C(N, 2) indices combinations.
                        let trash = MeasureIntegerBE(BigEndian(dist)); // Collapse to correct state (including indices)

                        set prev_i = MeasureIntegerBE(BigEndian(i));
                        set prev_j = MeasureIntegerBE(BigEndian(j));

                        // Set d_max to dist
                        ResetAll(d_max);
                        efficient_adder(d_max, dist);

                        Reset(phase_qubit);
                        ResetAll(dist);
                    }
                } until (prev_i != prev_j)
                fixup {
                }

                ResetAll(d_max);
            }
            ResetAll(i);
            ResetAll(j);
        }

        Message("Length: " + ToStringI(Length(indices)));
        Message("i: " + ToStringI(prev_i) + " j: " + ToStringI(prev_j));

        return (prev_i, prev_j);
    }

    operation divisive_clust(n : Int, m: Int, point_idxs : Int[], distances : Int[]) : Int[] {
        mutable groupings = new Int[Length(point_idxs)];
        
        if (similarity_crit(point_idxs, distances, PowI(2, n)) || Length(point_idxs) <= 1) {
            return groupings; // Return all zeros if this group is similar enough.
        }
        
        // Find furthest points
        let (i, j) = quant_find_max(n, m, point_idxs, distances);
        
        // Classify each point into cluster closer to point j (tag = 1), or closer to i (tag = 0) 
        for (idx in 0..Length(point_idxs) - 1) {
            if (distances[16*i + point_idxs[idx]] > distances[16*j + point_idxs[idx]]) {
                set groupings[idx] = 1;
            } else {
                set groupings[idx] = 0;
            }
        }

        // Create new lists of points, which can be passed recursively down
        mutable points_j = new Int[Sum(groupings)];
        mutable points_i = new Int[Length(point_idxs) - Length(points_j)];
        mutable idx_i = 0;
        mutable idx_j = 0;
        for (idx in 0..Length(point_idxs) - 1) {
            if(groupings[idx] == 0) {
                set points_i[idx_i] = point_idxs[idx];
                set idx_i = idx_i + 1; 
            } else {
                set points_j[idx_j] = point_idxs[idx];
                set idx_j = idx_j + 1;
            }
        }

        // Apply algo recursively
        mutable grouping_i = divisive_clust(n, m, points_i, distances);
        mutable grouping_j = divisive_clust(n, m, points_j, distances);
        
        // Make two groupings compatible (i.e. shift values in grouping j up by max value of grouping i)
        let max_i = Max(grouping_i);
        for (idx in 0..Length(grouping_j) - 1) {
            set grouping_j[idx] = grouping_j[idx] + max_i + 1;
        }

        // Update main grouping based on results from branch i and j.
        set idx_i = 0;
        set idx_j = 0;
        for (idx in 0..Length(groupings) - 1) {
            if(groupings[idx] == 0) {
                set groupings[idx] = grouping_i[idx_i];
                set idx_i = idx_i + 1; 
            } else {
                set groupings[idx] = grouping_j[idx_j];
                set idx_j = idx_j + 1;
            }
        }
        return groupings;
    }

    operation prep_indices (idxs : Int[], qubits : Qubit[]) : Unit {
        body (...) {
            if (Max(idxs) >= PowI(2, Length(qubits))) {
                fail "Not enough qubits to encode given indices";
            }

            let coeffs = get_coeffs(idxs, Length(qubits));

            PrepareArbitraryState(coeffs, BigEndian(qubits));
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    function get_coeffs(idxs : Int[], qb_len : Int) : ComplexPolar[] {
        mutable coeffs = new ComplexPolar[PowI(2, qb_len)];
        for (i in 0 .. Length(idxs) - 1) {
            set coeffs[idxs[i]] = ComplexPolar(1. / ToDouble(Length(idxs)), 0.);
        }
        return coeffs;
    }

    function similarity_crit(point_idxs : Int[], distances : Int[], n : Int) : Bool {
        // Stub method, which will make divise clustering run exactly once.
        mutable idx_dist = 0;
        for(i in 0..Length(point_idxs) - 2) {
            for (j in i..Length(point_idxs) - 1) {
                if (distances[n * i + j] > idx_dist) {
                    set idx_dist = distances[n * i + j];
                }
            }
        }

        return Max(distances) * 2 / 3 > idx_dist;
    }

    operation quant_find_smallest(n : Int, m : Int, indices : Int[], distances : Int[]) : (Int, Int) {
        mutable result_dist = 0;
        mutable result_idx = 0;
        using(i = Qubit[n]) {
            prep_indices(indices, i);
            using((dist, d_min, phase_qubit) = (Qubit[m], Qubit[m], Qubit())) {
                for(idx in 0 .. Length(indices) - 1) {
                    using(j = Qubit[n]) {
                        IntegerIncrementBE(indices[idx], j);
                        distance_add(i, j, dist, distances);
                        Adjoint IntegerIncrementBE(indices[idx], j);
                    }
                }

                negateBE(dist);

                // Little bit of cheating, but we were supposed to do a stub oracle.
                let (_, x) = class_find_smallest(n, indices, distances);
                IntegerIncrementBE(x - 1, d_min); // Set it to -1, since compare does >, and not >=

                GroversSearch(dist, d_min, phase_qubit, distance_cmp, Length(indices));
                set result_dist = -1 * MeasureIntegerBE(BigEndian(dist)); // Collapse to correct state.
                set result_idx = MeasureIntegerBE(BigEndian(i)); // Get result from collapsed indices

                ResetAll(dist);
                ResetAll(d_min);
                Reset(phase_qubit);
            }

            ResetAll(i);
        }

        return (result_idx, result_dist);
    }

    function class_find_smallest(n : Int, indices : Int[], distances : Int[]) : (Int, Int) {
        mutable min_i = 0;
        mutable min_dist = Length(indices) * Max(distances);
        for(i in 0 .. Length(indices) - 1) {
            mutable dist_i = 0;
            
            for(j in 0 .. Length(indices) - 1) {
                set dist_i = dist_i - distances[indices[i] * n + indices[j]]; // Make distance negative, so max is actually a min
            }

            if(dist_i < min_dist) {
                set min_dist = dist_i;
                set min_i = indices[i];
            }
        }

        return (min_i, min_dist);
    }

    operation quant_find_k_smallest(n: Int, m : Int, indices : Int[], k : Int, distances: Int[]) : Int[][] {
        if (k > Length(indices)) {
            fail "Not enough indices given to find k values.";
        }

        mutable result = new Int[][k];
        if (k == Length(indices)) {
            for (i in 0 .. k-1) {
                set result[i] = new Int[2];
                set result[i][0] = indices[i];
                mutable result_i = 0;
                for (j in 0 .. Length(indices) - 1) {
                    set result_i = result_i + distances[n * indices[i] + indices[j]];
                }
                set result[i][1] = result_i;
            }
            return result;
        }

        mutable curr_indices = indices;
        for (i in 0 .. k-1) {
            set result[i] = new Int[2];
            set (result[i][0], result[i][1]) = quant_find_smallest(n, m, curr_indices, distances);
            set curr_indices = Remove(curr_indices, result[i][0]); // Remove for next iteration
        }
        return result;
    }
}
