#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_add\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":4,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"i\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"j\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"distances\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":68},\"Item2\":{\"Line\":1,\"Column\":77}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_add\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":5,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_add\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":8,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_add\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":9,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_add\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":10,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_cmp\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":30}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_cmp\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":14,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_cmp\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":17,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_cmp\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":18,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_cmp\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":19,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"index_to_distance\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"index\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"distances\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":55}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":64},\"Item2\":{\"Line\":1,\"Column\":70}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"index_to_distance\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":23,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"index_to_distance\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":29,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"index_to_distance\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":30,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"index_to_distance\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":31,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
#line hidden
namespace Final_Project
{
    public class distance_add : Unitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>)>, ICallable
    {
        public distance_add(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "distance_add";
        String ICallable.FullName => "Final_Project.distance_add";
        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>), QVoid> Body => (__in__) =>
        {
            var (i,j,target,distances) = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>), QVoid> AdjointBody => (__in__) =>
        {
            var (i,j,target,distances) = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(i,j,target,distances)) = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(i,j,target,distances)) = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> i, QArray<Qubit> j, QArray<Qubit> target, QArray<Int64> distances)
        {
            return __m__.Run<distance_add, (QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>), QVoid>((i, j, target, distances));
        }
    }

    public class distance_cmp : Unitary<Qubit>, ICallable
    {
        public distance_cmp(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "distance_cmp";
        String ICallable.FullName => "Final_Project.distance_cmp";
        public override Func<Qubit, QVoid> Body => (__in__) =>
        {
            var target = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => (__in__) =>
        {
            var target = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,target) = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,target) = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit target)
        {
            return __m__.Run<distance_cmp, Qubit, QVoid>(target);
        }
    }

    public class index_to_distance : Unitary<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>)>, ICallable
    {
        public index_to_distance(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Int64>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "index_to_distance";
        String ICallable.FullName => "Final_Project.index_to_distance";
        protected ICallable<Int64, QArray<Boolean>> int_to_boolsBE
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (index,distances,target) = __in__;
#line 25 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs"
            foreach (var i in new Range(0L, 255L))
#line hidden
            {
#line 26 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs"
                var bool_i = int_to_boolsBE.Apply(i);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (index,distances,target) = __in__;
#line hidden
            foreach (var i in new Range(0L, 255L))
#line hidden
            {
#line hidden
                var bool_i = int_to_boolsBE.Apply(i);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Int64>,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(index,distances,target)) = __in__;
#line hidden
            foreach (var i in new Range(0L, 255L))
#line hidden
            {
#line hidden
                var bool_i = int_to_boolsBE.Apply(i);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Int64>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(index,distances,target)) = __in__;
#line hidden
            foreach (var i in new Range(0L, 255L))
#line hidden
            {
#line hidden
                var bool_i = int_to_boolsBE.Apply(i);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.int_to_boolsBE = this.Factory.Get<ICallable<Int64, QArray<Boolean>>>(typeof(int_to_boolsBE));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Int64>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> index, QArray<Int64> distances, QArray<Qubit> target)
        {
            return __m__.Run<index_to_distance, (QArray<Qubit>,QArray<Int64>,QArray<Qubit>), QVoid>((index, distances, target));
        }
    }
}