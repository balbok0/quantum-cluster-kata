#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_add\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":4,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"i\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"j\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"distances\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":68},\"Item2\":{\"Line\":1,\"Column\":77}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_add\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":5,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_add\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":9,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_add\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":10,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_add\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":11,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_cmp\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"d1\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"d2\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":58}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_cmp\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":15,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_cmp\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":19,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_cmp\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":20,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"distance_cmp\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":21,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"index_to_distance\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":24,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"index\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"distances\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":64},\"Item2\":{\"Line\":1,\"Column\":73}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"index_to_distance\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":25,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"index_to_distance\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":32,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"index_to_distance\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":33,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"index_to_distance\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":34,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"IIBE_wrap\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"i\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"distances\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"IIBE_wrap\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":38,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"IIBE_wrap\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":42,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"IIBE_wrap\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":43,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"IIBE_wrap\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":44,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"IntegerIncrementBE\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":47,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"i\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"IntegerIncrementBE\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":48,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"IntegerIncrementBE\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":52,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"IntegerIncrementBE\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":53,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"IntegerIncrementBE\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs\",\"Position\":{\"Item1\":54,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
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
        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Int64>)> index_to_distance
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>), QVoid> Body => (__in__) =>
        {
            var (i,j,target,distances) = __in__;
#line 7 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs"
            index_to_distance.Apply(((i + j), target?.Copy(), distances?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>), QVoid> AdjointBody => (__in__) =>
        {
            var (i,j,target,distances) = __in__;
#line hidden
            index_to_distance.Adjoint.Apply(((i + j), target?.Copy(), distances?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(i,j,target,distances)) = __in__;
#line hidden
            index_to_distance.Controlled.Apply((__controlQubits__?.Copy(), ((i + j), target?.Copy(), distances?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(i,j,target,distances)) = __in__;
#line hidden
            index_to_distance.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), ((i + j), target?.Copy(), distances?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.index_to_distance = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Int64>)>>(typeof(index_to_distance));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> i, QArray<Qubit> j, QArray<Qubit> target, QArray<Int64> distances)
        {
            return __m__.Run<distance_add, (QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>), QVoid>((i, j, target, distances));
        }
    }

    public class distance_cmp : Unitary<(QArray<Qubit>,QArray<Qubit>,Qubit)>, ICallable
    {
        public distance_cmp(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "distance_cmp";
        String ICallable.FullName => "Final_Project.distance_cmp";
        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,Qubit)> efficient_TC_comparator
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (d1,d2,target) = __in__;
#line 17 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs"
            efficient_TC_comparator.Apply((d1?.Copy(), d2?.Copy(), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (d1,d2,target) = __in__;
#line hidden
            efficient_TC_comparator.Adjoint.Apply((d1?.Copy(), d2?.Copy(), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,Qubit)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(d1,d2,target)) = __in__;
#line hidden
            efficient_TC_comparator.Controlled.Apply((__controlQubits__?.Copy(), (d1?.Copy(), d2?.Copy(), target)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,Qubit)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(d1,d2,target)) = __in__;
#line hidden
            efficient_TC_comparator.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (d1?.Copy(), d2?.Copy(), target)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.efficient_TC_comparator = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,Qubit)>>(typeof(efficient_TC_comparator));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> d1, QArray<Qubit> d2, Qubit target)
        {
            return __m__.Run<distance_cmp, (QArray<Qubit>,QArray<Qubit>,Qubit), QVoid>((d1, d2, target));
        }
    }

    public class index_to_distance : Unitary<(QArray<Qubit>,QArray<Qubit>,QArray<Int64>)>, ICallable
    {
        public index_to_distance(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,QArray<Int64>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "index_to_distance";
        String ICallable.FullName => "Final_Project.index_to_distance";
        protected IUnitary<(Int64,QArray<Qubit>,QArray<Int64>)> IIBE_wrap
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), QArray<Boolean>> int_to_boolsBE
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonControlledOnBitString
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Int64>), QVoid> Body => (__in__) =>
        {
            var (index,target,distances) = __in__;
#line 27 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs"
            foreach (var i in new Range(0L, (distances.Length - 1L)))
#line hidden
            {
#line 28 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs"
                var bool_i = int_to_boolsBE.Apply((i, index.Length));
#line 29 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs"
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((bool_i?.Copy(), IIBE_wrap.Partial(new Func<QArray<Qubit>, (Int64,QArray<Qubit>,QArray<Int64>)>((__arg1__) => (i, __arg1__, distances?.Copy()))))).Apply((index?.Copy(), target?.Copy()));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Int64>), QVoid> AdjointBody => (__in__) =>
        {
            var (index,target,distances) = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (distances.Length - 1L))))
#line hidden
            {
#line hidden
                var bool_i = int_to_boolsBE.Apply((i, index.Length));
#line hidden
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((bool_i?.Copy(), IIBE_wrap.Partial(new Func<QArray<Qubit>, (Int64,QArray<Qubit>,QArray<Int64>)>((__arg1__) => (i, __arg1__, distances?.Copy()))))).Adjoint.Apply((index?.Copy(), target?.Copy()));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Int64>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(index,target,distances)) = __in__;
#line hidden
            foreach (var i in new Range(0L, (distances.Length - 1L)))
#line hidden
            {
#line hidden
                var bool_i = int_to_boolsBE.Apply((i, index.Length));
#line hidden
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((bool_i?.Copy(), IIBE_wrap.Partial(new Func<QArray<Qubit>, (Int64,QArray<Qubit>,QArray<Int64>)>((__arg1__) => (i, __arg1__, distances?.Copy()))))).Controlled.Apply((__controlQubits__?.Copy(), (index?.Copy(), target?.Copy())));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Int64>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(index,target,distances)) = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (distances.Length - 1L))))
#line hidden
            {
#line hidden
                var bool_i = int_to_boolsBE.Apply((i, index.Length));
#line hidden
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((bool_i?.Copy(), IIBE_wrap.Partial(new Func<QArray<Qubit>, (Int64,QArray<Qubit>,QArray<Int64>)>((__arg1__) => (i, __arg1__, distances?.Copy()))))).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (index?.Copy(), target?.Copy())));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.IIBE_wrap = this.Factory.Get<IUnitary<(Int64,QArray<Qubit>,QArray<Int64>)>>(typeof(IIBE_wrap));
            this.int_to_boolsBE = this.Factory.Get<ICallable<(Int64,Int64), QArray<Boolean>>>(typeof(int_to_boolsBE));
            this.MicrosoftQuantumCanonControlledOnBitString = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnBitString<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> index, QArray<Qubit> target, QArray<Int64> distances)
        {
            return __m__.Run<index_to_distance, (QArray<Qubit>,QArray<Qubit>,QArray<Int64>), QVoid>((index, target, distances));
        }
    }

    public class IIBE_wrap : Unitary<(Int64,QArray<Qubit>,QArray<Int64>)>, ICallable
    {
        public IIBE_wrap(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Qubit>,QArray<Int64>)>, IApplyData
        {
            public In((Int64,QArray<Qubit>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "IIBE_wrap";
        String ICallable.FullName => "Final_Project.IIBE_wrap";
        protected IUnitary<(Int64,QArray<Qubit>)> IntegerIncrementBE
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Qubit>,QArray<Int64>), QVoid> Body => (__in__) =>
        {
            var (i,qs,distances) = __in__;
#line 40 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs"
            IntegerIncrementBE.Apply((distances[i], qs?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,QArray<Qubit>,QArray<Int64>), QVoid> AdjointBody => (__in__) =>
        {
            var (i,qs,distances) = __in__;
#line hidden
            IntegerIncrementBE.Adjoint.Apply((distances[i], qs?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,QArray<Qubit>,QArray<Int64>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(i,qs,distances)) = __in__;
#line hidden
            IntegerIncrementBE.Controlled.Apply((__controlQubits__?.Copy(), (distances[i], qs?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,QArray<Qubit>,QArray<Int64>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(i,qs,distances)) = __in__;
#line hidden
            IntegerIncrementBE.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (distances[i], qs?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.IntegerIncrementBE = this.Factory.Get<IUnitary<(Int64,QArray<Qubit>)>>(typeof(IntegerIncrementBE));
        }

        public override IApplyData __dataIn((Int64,QArray<Qubit>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 i, QArray<Qubit> qs, QArray<Int64> distances)
        {
            return __m__.Run<IIBE_wrap, (Int64,QArray<Qubit>,QArray<Int64>), QVoid>((i, qs, distances));
        }
    }

    public class IntegerIncrementBE : Unitary<(Int64,QArray<Qubit>)>, ICallable
    {
        public IntegerIncrementBE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Qubit>)>, IApplyData
        {
            public In((Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "IntegerIncrementBE";
        String ICallable.FullName => "Final_Project.IntegerIncrementBE";
        protected ICallable<Microsoft.Quantum.Canon.BigEndian, Microsoft.Quantum.Canon.LittleEndian> MicrosoftQuantumCanonBigEndianToLittleEndian
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Microsoft.Quantum.Canon.LittleEndian)> MicrosoftQuantumCanonIntegerIncrementLE
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (i,qs) = __in__;
#line 50 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Distance_oracles.qs"
            MicrosoftQuantumCanonIntegerIncrementLE.Apply((i, MicrosoftQuantumCanonBigEndianToLittleEndian.Apply(new Microsoft.Quantum.Canon.BigEndian(qs?.Copy()))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (i,qs) = __in__;
#line hidden
            MicrosoftQuantumCanonIntegerIncrementLE.Adjoint.Apply((i, MicrosoftQuantumCanonBigEndianToLittleEndian.Apply(new Microsoft.Quantum.Canon.BigEndian(qs?.Copy()))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(i,qs)) = __in__;
#line hidden
            MicrosoftQuantumCanonIntegerIncrementLE.Controlled.Apply((__controlQubits__?.Copy(), (i, MicrosoftQuantumCanonBigEndianToLittleEndian.Apply(new Microsoft.Quantum.Canon.BigEndian(qs?.Copy())))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(i,qs)) = __in__;
#line hidden
            MicrosoftQuantumCanonIntegerIncrementLE.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (i, MicrosoftQuantumCanonBigEndianToLittleEndian.Apply(new Microsoft.Quantum.Canon.BigEndian(qs?.Copy())))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonBigEndianToLittleEndian = this.Factory.Get<ICallable<Microsoft.Quantum.Canon.BigEndian, Microsoft.Quantum.Canon.LittleEndian>>(typeof(Microsoft.Quantum.Canon.BigEndianToLittleEndian));
            this.MicrosoftQuantumCanonIntegerIncrementLE = this.Factory.Get<IUnitary<(Int64,Microsoft.Quantum.Canon.LittleEndian)>>(typeof(Microsoft.Quantum.Canon.IntegerIncrementLE));
        }

        public override IApplyData __dataIn((Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 i, QArray<Qubit> qs)
        {
            return __m__.Run<IntegerIncrementBE, (Int64,QArray<Qubit>), QVoid>((i, qs));
        }
    }
}