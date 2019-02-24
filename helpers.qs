namespace Final_Project
{ 
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Convert;

    function PowI (a : Int, p : Int) : Int {
        return Round(PowD(ToDouble(a), ToDouble(p)));
    }
}