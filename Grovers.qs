namespace Final_Project {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    
    operation GroverIteration (x : Qubit[], y : Qubit[], target: Qubit, oracle : ((Qubit[], Qubit[], Qubit) => Unit : Adjoint)) : Unit {
        
        body (...) {
            oracle(x, y, target);

            ApplyToEachA(H, x);
            ApplyToEachA(X, x);

            ApplyToEachA(H, y);
            ApplyToEachA(X, y);
            
            Controlled Z(Most(x), Tail(x));
            Controlled Z(Most(y), Tail(y));

            ApplyToEachA(X, y);
            ApplyToEachA(H, y);

            ApplyToEachA(X, x);
            ApplyToEachA(H, x);
        }
        
        adjoint invert;
    }
    
    operation GroversSearch (x : Qubit[], y : Qubit[], target : Qubit, oracle : ((Qubit[], Qubit[], Qubit) => Unit : Adjoint), iterations : Int) : Unit {
        
        body (...) {
            ApplyToEachA(H, x);
            ApplyToEachA(H, y);

            for (i in 1 .. iterations) {
                GroverIteration(x, y, target, oracle);
            }
        }
        
        adjoint invert;
    }
    
}
