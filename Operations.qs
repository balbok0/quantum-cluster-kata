namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation quant_find_max (n: Int, m: Int, indices: Int[], distances: Int[]) : (Int, Int) {
        mutable prev_i = 0;
        mutable prev_j = 0;
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
        } until (prev_i != prev_j)
        // Sanity check. 
        // Should be executed only once, unless some edge case happens
        fixup {
        }

        return (prev_i, prev_j);
    }

    operation divisive_clust(n: Int, m: Int, point_idxs : Int[], distances : Int[]) : Int[] {
        mutable groupings = new Int[Length(point_idxs)];
        
        if (similarity_crit(point_idxs, distances)) {
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

    function Sum(arr : Int[]) : Int {
        mutable result = 0;
        for (i in 0..Length(arr) - 1) {
            set result = result + arr[i];
        }
        return result;
    }

    function similarity_crit(point_idxs : Int[], distances : Int[]) : Bool {
        // Stub method, which will make divise clustering run exactly once.
        if (Length(point_idxs) == 16) {
            return false;
        }
        
        return true;
    }
}
