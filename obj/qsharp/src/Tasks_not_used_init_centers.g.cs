#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"quantum_initialization_centers_random\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_not_used_init_centers.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":48}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":51}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":60}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"quantum_initialization_centers_random\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_not_used_init_centers.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":48}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"quantum_initialization_centers_smart\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_not_used_init_centers.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":47}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":59}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"data\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":67},\"Item2\":{\"Line\":1,\"Column\":71}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"quantum_initialization_centers_smart\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_not_used_init_centers.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":47}},\"Documentation\":[]}")]
#line hidden
namespace Final_Project
{
    public class quantum_initialization_centers_random : Operation<(Int64,Int64), QArray<Int64>>, ICallable
    {
        public quantum_initialization_centers_random(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "quantum_initialization_centers_random";
        String ICallable.FullName => "Final_Project.quantum_initialization_centers_random";
        protected ICallable<Int64, Int64> MicrosoftQuantumCanonRandomInt
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), QArray<Int64>> Body => (__in__) =>
        {
            var (n,k) = __in__;
#line 7 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_not_used_init_centers.qs"
            var centers = new QArray<Int64>(k);
#line 8 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_not_used_init_centers.qs"
            foreach (var i in new Range(0L, (k - 1L)))
#line hidden
            {
#line 9 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_not_used_init_centers.qs"
                centers[k] = MicrosoftQuantumCanonRandomInt.Apply(n);
            }

#line 11 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_not_used_init_centers.qs"
            return centers;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.RandomInt));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, Int64 n, Int64 k)
        {
            return __m__.Run<quantum_initialization_centers_random, (Int64,Int64), QArray<Int64>>((n, k));
        }
    }

    public class quantum_initialization_centers_smart : Operation<(Int64,Int64,QArray<Qubit>), QArray<Int64>>, ICallable
    {
        public quantum_initialization_centers_smart(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((Int64,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "quantum_initialization_centers_smart";
        String ICallable.FullName => "Final_Project.quantum_initialization_centers_smart";
        protected ICallable<Int64, Int64> MicrosoftQuantumCanonRandomInt
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,QArray<Qubit>), QArray<Int64>> Body => (__in__) =>
        {
            var (n,k,data) = __in__;
#line 16 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_not_used_init_centers.qs"
            var centers = new QArray<Int64>(k);
#line 18 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_not_used_init_centers.qs"
            centers[0L] = MicrosoftQuantumCanonRandomInt.Apply(n);
#line 19 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_not_used_init_centers.qs"
            foreach (var i in new Range(1L, (k - 1L)))
#line hidden
            {
            }

#line 23 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_not_used_init_centers.qs"
            return centers;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.RandomInt));
        }

        public override IApplyData __dataIn((Int64,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, Int64 n, Int64 k, QArray<Qubit> data)
        {
            return __m__.Run<quantum_initialization_centers_smart, (Int64,Int64,QArray<Qubit>), QArray<Int64>>((n, k, data));
        }
    }
}