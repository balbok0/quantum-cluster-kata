namespace Final_Project
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation V (q : Qubit) : Unit {
        body (...) {
            H(q);
            S(q);
            H(q);
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation AV (q : Qubit) : Unit {
        body (...) {
            Adjoint V(q);
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation CV (controller : Qubit, target : Qubit) : Unit {
        Controlled V([controller], target);
    }

    operation CAV (controller : Qubit, target : Qubit) : Unit {
        Controlled AV([controller], target);
    }
}