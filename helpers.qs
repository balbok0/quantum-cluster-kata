namespace Final_Project
{ 
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Convert;

    function PowI (a : Int, p : Int) : Int {
        return Round(PowD(ToDouble(a), ToDouble(p)));
    }

    function initSquareMatrix(n : Int) : Int[][] {
        return initMatrix(n, n);
    }

    function initMatrix(a : Int, b : Int) : Int[][] {
        mutable arr = new Int[][b];
        for (i in 0 .. b - 1) {
            set arr[i] = new Int[a];
        }

        return arr;
    }
}