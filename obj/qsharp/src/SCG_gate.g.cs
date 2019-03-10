#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":16,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"output\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":17,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":42,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":43,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":44,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG_bit_adder\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":47,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"A\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"B\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"carry\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":53}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG_bit_adder\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":48,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG_bit_adder\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":56,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG_bit_adder\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":57,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG_bit_adder\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":58,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"Rzk\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":63,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":17}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"Rzk\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":64,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"Rzk\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":67,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"Rzk\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":68,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"Rzk\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":69,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"experimental_adder\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":72,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"A\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"B\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"experimental_adder\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":73,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"experimental_adder\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":90,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"experimental_adder\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":91,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"experimental_adder\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs\",\"Position\":{\"Item1\":92,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
#line hidden
namespace Final_Project
{
    public class SCG : Unitary<(QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public SCG(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "SCG";
        String ICallable.FullName => "Final_Project.SCG";
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

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (input,output) = __in__;
#line 19 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            if (((input.Length != 4L) || (output.Length != 4L)))
            {
#line 20 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
                throw new ExecutionFailException("Eror: Improper SCG gate usage");
            }

#line 23 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false), MicrosoftQuantumPrimitiveX)).Apply((new QArray<Qubit>(input[1L], input[2L]), output[0L]));
#line 24 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false), MicrosoftQuantumPrimitiveX)).Apply((new QArray<Qubit>(input[2L], input[3L]), output[0L]));
#line 26 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, false, false), MicrosoftQuantumPrimitiveX)).Apply((new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L]));
#line 27 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, true, true, false), MicrosoftQuantumPrimitiveX)).Apply((new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L]));
#line 28 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false, true, false), MicrosoftQuantumPrimitiveX)).Apply((new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L]));
#line 29 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, true, false), MicrosoftQuantumPrimitiveX)).Apply((new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L]));
#line 30 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false, false, true), MicrosoftQuantumPrimitiveX)).Apply((new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L]));
#line 31 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, false, true, true), MicrosoftQuantumPrimitiveX)).Apply((new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L]));
#line 32 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, false, false), MicrosoftQuantumPrimitiveX)).Apply((new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L]));
#line 33 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, false, true), MicrosoftQuantumPrimitiveX)).Apply((new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L]));
#line 35 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((input[3L], output[2L]));
#line 36 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((input[2L], output[2L]));
#line 37 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((input[0L], output[2L]));
#line 39 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((input[3L], output[3L]));
#line 40 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((input[2L], output[3L]));
#line 41 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((input[1L], output[3L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (input,output) = __in__;
#line hidden
            if (((input.Length != 4L) || (output.Length != 4L)))
            {
#line hidden
                throw new ExecutionFailException("Eror: Improper SCG gate usage");
            }

#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((input[1L], output[3L]));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((input[2L], output[3L]));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((input[3L], output[3L]));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((input[0L], output[2L]));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((input[2L], output[2L]));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((input[3L], output[2L]));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, false, true), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L]));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, false, false), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L]));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, false, true, true), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L]));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false, false, true), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L]));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, true, false), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L]));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false, true, false), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L]));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, true, true, false), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L]));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, false, false), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L]));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((new QArray<Qubit>(input[2L], input[3L]), output[0L]));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((new QArray<Qubit>(input[1L], input[2L]), output[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(input,output)) = __in__;
#line hidden
            if (((input.Length != 4L) || (output.Length != 4L)))
            {
#line hidden
                throw new ExecutionFailException("Eror: Improper SCG gate usage");
            }

#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false), MicrosoftQuantumPrimitiveX)).Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[1L], input[2L]), output[0L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false), MicrosoftQuantumPrimitiveX)).Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[2L], input[3L]), output[0L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, false, false), MicrosoftQuantumPrimitiveX)).Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, true, true, false), MicrosoftQuantumPrimitiveX)).Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false, true, false), MicrosoftQuantumPrimitiveX)).Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, true, false), MicrosoftQuantumPrimitiveX)).Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false, false, true), MicrosoftQuantumPrimitiveX)).Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, false, true, true), MicrosoftQuantumPrimitiveX)).Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, false, false), MicrosoftQuantumPrimitiveX)).Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, false, true), MicrosoftQuantumPrimitiveX)).Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L])));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (input[3L], output[2L])));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (input[2L], output[2L])));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (input[0L], output[2L])));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (input[3L], output[3L])));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (input[2L], output[3L])));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (input[1L], output[3L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(input,output)) = __in__;
#line hidden
            if (((input.Length != 4L) || (output.Length != 4L)))
            {
#line hidden
                throw new ExecutionFailException("Eror: Improper SCG gate usage");
            }

#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (input[1L], output[3L])));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (input[2L], output[3L])));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (input[3L], output[3L])));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (input[0L], output[2L])));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (input[2L], output[2L])));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (input[3L], output[2L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, false, true), MicrosoftQuantumPrimitiveX)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, false, false), MicrosoftQuantumPrimitiveX)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, false, true, true), MicrosoftQuantumPrimitiveX)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false, false, true), MicrosoftQuantumPrimitiveX)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, true, false), MicrosoftQuantumPrimitiveX)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false, true, false), MicrosoftQuantumPrimitiveX)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, true, true, false), MicrosoftQuantumPrimitiveX)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, false, false), MicrosoftQuantumPrimitiveX)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[0L], input[1L], input[2L], input[3L]), output[1L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false), MicrosoftQuantumPrimitiveX)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[2L], input[3L]), output[0L])));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false), MicrosoftQuantumPrimitiveX)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(input[1L], input[2L]), output[0L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonControlledOnBitString = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnBitString<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> input, QArray<Qubit> output)
        {
            return __m__.Run<SCG, (QArray<Qubit>,QArray<Qubit>), QVoid>((input, output));
        }
    }

    public class SCG_bit_adder : Unitary<(Qubit,Qubit,Qubit,Qubit)>, ICallable
    {
        public SCG_bit_adder(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit,Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                    yield return Data.Item3;
                    yield return Data.Item4;
                }
            }
        }

        String ICallable.Name => "SCG_bit_adder";
        String ICallable.FullName => "Final_Project.SCG_bit_adder";
        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumPrimitiveCCNOT
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit,Qubit,Qubit), QVoid> Body => (__in__) =>
        {
            var (A,B,carry,Target) = __in__;
#line 50 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((A, Target));
#line 51 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((B, Target));
#line 52 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((carry, Target));
#line 54 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumPrimitiveCCNOT.Apply((A, B, carry));
#line 55 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumPrimitiveCCNOT.Apply((A, B, carry));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit,Qubit,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (A,B,carry,Target) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveCCNOT.Adjoint.Apply((A, B, carry));
#line hidden
            MicrosoftQuantumPrimitiveCCNOT.Adjoint.Apply((A, B, carry));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((carry, Target));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((B, Target));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((A, Target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Qubit,Qubit,Qubit)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(A,B,carry,Target)) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (A, Target)));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (B, Target)));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (carry, Target)));
#line hidden
            MicrosoftQuantumPrimitiveCCNOT.Controlled.Apply((__controlQubits__?.Copy(), (A, B, carry)));
#line hidden
            MicrosoftQuantumPrimitiveCCNOT.Controlled.Apply((__controlQubits__?.Copy(), (A, B, carry)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Qubit,Qubit,Qubit)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(A,B,carry,Target)) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveCCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (A, B, carry)));
#line hidden
            MicrosoftQuantumPrimitiveCCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (A, B, carry)));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (carry, Target)));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (B, Target)));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (A, Target)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CCNOT));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit A, Qubit B, Qubit carry, Qubit Target)
        {
            return __m__.Run<SCG_bit_adder, (Qubit,Qubit,Qubit,Qubit), QVoid>((A, B, carry, Target));
        }
    }

    public class Rzk : Unitary<(Qubit,Double)>, ICallable
    {
        public Rzk(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Double)>, IApplyData
        {
            public In((Qubit,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                }
            }
        }

        String ICallable.Name => "Rzk";
        String ICallable.FullName => "Final_Project.Rzk";
        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected ICallable<(Double,Double), Double> MicrosoftQuantumExtensionsMathPowD
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRz
        {
            get;
            set;
        }

        public override Func<(Qubit,Double), QVoid> Body => (__in__) =>
        {
            var (q,k) = __in__;
#line 66 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumPrimitiveRz.Apply((((4D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / MicrosoftQuantumExtensionsMathPowD.Apply((2D, k))), q));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Double), QVoid> AdjointBody => (__in__) =>
        {
            var (q,k) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveRz.Adjoint.Apply((((4D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / MicrosoftQuantumExtensionsMathPowD.Apply((2D, k))), q));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Double)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(q,k)) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveRz.Controlled.Apply((__controlQubits__?.Copy(), (((4D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / MicrosoftQuantumExtensionsMathPowD.Apply((2D, k))), q)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Double)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(q,k)) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveRz.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (((4D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / MicrosoftQuantumExtensionsMathPowD.Apply((2D, k))), q)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumExtensionsMathPowD = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(Microsoft.Quantum.Extensions.Math.PowD));
            this.MicrosoftQuantumPrimitiveRz = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Rz));
        }

        public override IApplyData __dataIn((Qubit,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q, Double k)
        {
            return __m__.Run<Rzk, (Qubit,Double), QVoid>((q, k));
        }
    }

    public class experimental_adder : Unitary<(QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public experimental_adder(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "experimental_adder";
        String ICallable.FullName => "Final_Project.experimental_adder";
        protected IUnitary<(Qubit,Double)> Rzk
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Canon.LittleEndian, Microsoft.Quantum.Canon.BigEndian> MicrosoftQuantumCanonLittleEndianToBigEndian
        {
            get;
            set;
        }

        protected IUnitary<Microsoft.Quantum.Canon.BigEndian> MicrosoftQuantumCanonQFT
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

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<Int64, String> MicrosoftQuantumExtensionsConvertToStringI
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (A,B) = __in__;
#line 75 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            var N = A.Length;
#line 76 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            var P = B.Length;
#line 77 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            if ((N != P))
            {
#line 78 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
                throw new ExecutionFailException("Improper quantum adder usage");
            }

#line 80 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumCanonQFT.Apply(MicrosoftQuantumCanonLittleEndianToBigEndian.Apply(new Microsoft.Quantum.Canon.LittleEndian(A?.Copy())));
#line 81 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            foreach (var i in new Range(0L, (P - 1L)))
#line hidden
            {
#line 82 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
                foreach (var j in new Range(0L, i))
#line hidden
                {
#line 83 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply(i));
#line 84 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply(j));
#line 85 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
                    Message.Apply("\\n");
#line 86 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
                    Rzk.Controlled.Apply((new QArray<Qubit>()
                    {A[j]}, (B[i], MicrosoftQuantumExtensionsConvertToDouble.Apply(((i - j) + 1L)))));
                }
            }

#line 89 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/SCG_gate.qs"
            MicrosoftQuantumCanonQFT.Adjoint.Apply(MicrosoftQuantumCanonLittleEndianToBigEndian.Apply(new Microsoft.Quantum.Canon.LittleEndian(A?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (A,B) = __in__;
#line hidden
            var N = A.Length;
#line hidden
            var P = B.Length;
#line hidden
            if ((N != P))
            {
#line hidden
                throw new ExecutionFailException("Improper quantum adder usage");
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Apply(MicrosoftQuantumCanonLittleEndianToBigEndian.Apply(new Microsoft.Quantum.Canon.LittleEndian(A?.Copy())));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (P - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range(0L, i)))
#line hidden
                {
#line hidden
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply(i));
#line hidden
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply(j));
#line hidden
                    Message.Apply("\\n");
#line hidden
                    Rzk.Controlled.Adjoint.Apply((new QArray<Qubit>()
                    {A[j]}, (B[i], MicrosoftQuantumExtensionsConvertToDouble.Apply(((i - j) + 1L)))));
                }
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Apply(MicrosoftQuantumCanonLittleEndianToBigEndian.Apply(new Microsoft.Quantum.Canon.LittleEndian(A?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(A,B)) = __in__;
#line hidden
            var N = A.Length;
#line hidden
            var P = B.Length;
#line hidden
            if ((N != P))
            {
#line hidden
                throw new ExecutionFailException("Improper quantum adder usage");
            }

#line hidden
            MicrosoftQuantumCanonQFT.Controlled.Apply((__controlQubits__?.Copy(), MicrosoftQuantumCanonLittleEndianToBigEndian.Apply(new Microsoft.Quantum.Canon.LittleEndian(A?.Copy()))));
#line hidden
            foreach (var i in new Range(0L, (P - 1L)))
#line hidden
            {
#line hidden
                foreach (var j in new Range(0L, i))
#line hidden
                {
#line hidden
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply(i));
#line hidden
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply(j));
#line hidden
                    Message.Apply("\\n");
#line hidden
                    Rzk.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
                    {A[j]}, (B[i], MicrosoftQuantumExtensionsConvertToDouble.Apply(((i - j) + 1L))))));
                }
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), MicrosoftQuantumCanonLittleEndianToBigEndian.Apply(new Microsoft.Quantum.Canon.LittleEndian(A?.Copy()))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(A,B)) = __in__;
#line hidden
            var N = A.Length;
#line hidden
            var P = B.Length;
#line hidden
            if ((N != P))
            {
#line hidden
                throw new ExecutionFailException("Improper quantum adder usage");
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), MicrosoftQuantumCanonLittleEndianToBigEndian.Apply(new Microsoft.Quantum.Canon.LittleEndian(A?.Copy()))));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (P - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range(0L, i)))
#line hidden
                {
#line hidden
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply(i));
#line hidden
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply(j));
#line hidden
                    Message.Apply("\\n");
#line hidden
                    Rzk.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
                    {A[j]}, (B[i], MicrosoftQuantumExtensionsConvertToDouble.Apply(((i - j) + 1L))))));
                }
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), MicrosoftQuantumCanonLittleEndianToBigEndian.Apply(new Microsoft.Quantum.Canon.LittleEndian(A?.Copy()))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Rzk = this.Factory.Get<IUnitary<(Qubit,Double)>>(typeof(Rzk));
            this.MicrosoftQuantumCanonLittleEndianToBigEndian = this.Factory.Get<ICallable<Microsoft.Quantum.Canon.LittleEndian, Microsoft.Quantum.Canon.BigEndian>>(typeof(Microsoft.Quantum.Canon.LittleEndianToBigEndian));
            this.MicrosoftQuantumCanonQFT = this.Factory.Get<IUnitary<Microsoft.Quantum.Canon.BigEndian>>(typeof(Microsoft.Quantum.Canon.QFT));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> A, QArray<Qubit> B)
        {
            return __m__.Run<experimental_adder, (QArray<Qubit>,QArray<Qubit>), QVoid>((A, B));
        }
    }
}