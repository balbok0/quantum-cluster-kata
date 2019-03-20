namespace Final_Project
{ 
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Convert;

    /// # Summary
    /// PowI given 2 integers a, b returns a^b.
    ///
    /// # Example
    /// ```Q#
    /// let c = PowI(2, 6); // c = 64
    /// ```
    function PowI (a : Int, p : Int) : Int {
        return Round(PowD(ToDouble(a), ToDouble(p)));
    }

    /// # Summary
    /// Returns an n x n square matrix filled with 0's.
    ///
    /// # Example
    /// ```Q#
    /// let a = initSquareMatrix(5);
    /// ```
    function initSquareMatrix(n : Int) : Int[][] {
        return initMatrix(n, n);
    }

    /// # Summary
    /// initMatrix returns an a x b matrix filled with 0's.
    ///
    /// # Example
    /// ```Q#
    /// let a = initMatrix(5, 4);
    /// ```
    function initMatrix(a : Int, b : Int) : Int[][] {
        mutable arr = new Int[][b];
        for (i in 0 .. b - 1) {
            set arr[i] = new Int[a];
        }

        return arr;
    }

    /// # Summary
    /// Sum returns a sum of all elements in the Integer array.
    ///
    /// # Example
    /// ```Q#
    /// mutable a = new Int[5];
    /// for(i in 0 .. Length(a) - 1) {
    ///     set a[i] = i;
    /// }
    /// let b = Sum(a); // b = 15
    /// ```
    function Sum(arr : Int[]) : Int {
        mutable result = 0;
        for (i in 0..Length(arr) - 1) {
            set result = result + arr[i];
        }
        return result;
    }

    /// # Summary
    /// Remove removes all elements with value val from array arr.
    ///
    /// # Example
    /// ```Q#
    /// mutable a = new Int[5];
    /// for(i in 0 .. Length(a) - 1) {
    ///     set a[i] = i;
    /// }
    /// let b = Remove(a, 2); // b = {0, 1, 3, 4}
    /// ```
    function Remove(arr : Int[], val : Int) : Int[] {
        mutable new_size = 0;
        for(i in arr) {
            if(i != val) {
                set new_size = new_size + 1;
            }
        }

        mutable result = new Int[new_size];
        mutable idx = 0;
        for(i in arr) {
            if(i != val) {
                set result[idx] = i;
                set idx = idx + 1;
            }
        }

        return result;
    }

    /// # Summary
    /// Returns a boolean array representation of given integer.
    /// If the boolean representation of integer takes more bits than given size,
    /// Then the array returned is truncated to given size.
    ///
    /// # Example
    /// ```Q#
    /// let b = 5;
    /// let a = int_to_boolsBE(5, 3); // b = {1, 0, 1};
    /// let c = int_to_boolsBE(5, 2); // b = {0, 1};
    /// ```
    function int_to_boolsBE(a: Int, size: Int) : Bool[] {
        mutable tmp = BigIntToBools(ToBigInt(a));
        set tmp = tmp[0..size-1];
        mutable result = new Bool[size];
        for(i in 0..size-1) {
            set result[i] = tmp[size - i - 1];
        }
        return result;
    }
}