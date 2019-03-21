#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"Rzk\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":25,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":17}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[\" # Summary\",\" create gate described by matrix [1 0; 0 e^(2*i*PI/2^k)]\",\"\",\" # Input\",\" ## q\",\" qubit being rotated.\",\" ## k\",\" Amount to rotate, defined by above equation.\",\"\",\" # Example\",\" ```Q#\",\" // often used as a controlled rotation\",\" Controlled Rzk([A], (B, 1.0));\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"Rzk\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":26,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"Rzk\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":29,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"Rzk\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":30,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"Rzk\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":31,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"efficient_adder\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"A\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"B\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[\" # Summary\",\" Adder that takes A, B -> A+B, B\",\" Uses QFT cascading design described in paper\",\"\",\" # Input\",\" ## A\",\" operand. Will become A+B.\",\" ## B\",\" operand. Remains B.\",\"\",\" # Example\",\" ```Q#\",\" efficient_adder(A, B);\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"efficient_adder\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":49,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"efficient_adder\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":67,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"efficient_adder\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":68,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"efficient_adder\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":69,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"efficient_TC_comparator\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":94,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"d\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"dmax\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":53}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":71}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[\" # Summary\",\" Compares d and dmax\",\" d, dmax, target -> d, dmax, (d > dmax)⊕target\",\" uses 1 extra qubit in function\",\"\",\" # Input\",\" ## d\",\" Unchanged operand.\",\" ## dmax\",\" Unchanged operand.\",\" ## target\",\" Flipped if d > dmax\",\"\",\" # Example\",\" ```Q#\",\" using (target = Qubit()) {\",\"     efficient_TC_comparator(A, B, target);\",\"     // do stuff with knowledge of d > dmax\",\"     efficient_TC_comparator(A, B, target); // reset target\",\" }\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"efficient_TC_comparator\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":95,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"efficient_TC_comparator\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":120,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"efficient_TC_comparator\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":121,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"efficient_TC_comparator\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":122,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"negateBE\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":125,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":21}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"negateBE\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":126,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"negateBE\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":132,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"negateBE\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":133,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"negateBE\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":134,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
#line hidden
namespace Final_Project
{
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
        protected IUnitary<(QArray<Double>,Microsoft.Quantum.Canon.BigEndian)> MicrosoftQuantumCanonApplyDiagonalUnitary
        {
            get;
            set;
        }

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

        public override Func<(Qubit,Double), QVoid> Body => (__in__) =>
        {
            var (q,k) = __in__;
#line 28 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            MicrosoftQuantumCanonApplyDiagonalUnitary.Apply((new QArray<Double>(0D, ((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / MicrosoftQuantumExtensionsMathPowD.Apply((2D, k)))), new Microsoft.Quantum.Canon.BigEndian(new QArray<Qubit>()
            {q})));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Double), QVoid> AdjointBody => (__in__) =>
        {
            var (q,k) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyDiagonalUnitary.Adjoint.Apply((new QArray<Double>(0D, ((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / MicrosoftQuantumExtensionsMathPowD.Apply((2D, k)))), new Microsoft.Quantum.Canon.BigEndian(new QArray<Qubit>()
            {q})));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Double)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(q,k)) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyDiagonalUnitary.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Double>(0D, ((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / MicrosoftQuantumExtensionsMathPowD.Apply((2D, k)))), new Microsoft.Quantum.Canon.BigEndian(new QArray<Qubit>()
            {q}))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Double)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(q,k)) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyDiagonalUnitary.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Double>(0D, ((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / MicrosoftQuantumExtensionsMathPowD.Apply((2D, k)))), new Microsoft.Quantum.Canon.BigEndian(new QArray<Qubit>()
            {q}))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyDiagonalUnitary = this.Factory.Get<IUnitary<(QArray<Double>,Microsoft.Quantum.Canon.BigEndian)>>(typeof(Microsoft.Quantum.Canon.ApplyDiagonalUnitary));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumExtensionsMathPowD = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(Microsoft.Quantum.Extensions.Math.PowD));
        }

        public override IApplyData __dataIn((Qubit,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q, Double k)
        {
            return __m__.Run<Rzk, (Qubit,Double), QVoid>((q, k));
        }
    }

    public class efficient_adder : Unitary<(QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public efficient_adder(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "efficient_adder";
        String ICallable.FullName => "Final_Project.efficient_adder";
        protected IUnitary<(Qubit,Double)> Rzk
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

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (A,B) = __in__;
#line 51 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            var N = A.Length;
#line 52 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            var P = B.Length;
#line 55 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            if ((N != P))
            {
#line 56 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                throw new ExecutionFailException("Eror: improper quantum adder usage");
            }

#line 59 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            MicrosoftQuantumCanonQFT.Apply(new Microsoft.Quantum.Canon.BigEndian(A?.Copy()));
#line 60 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 61 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                foreach (var j in new Range(0L, i))
#line hidden
                {
#line 63 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                    Rzk.Controlled.Apply((new QArray<Qubit>()
                    {A[((N - j) - 1L)]}, (B[i], MicrosoftQuantumExtensionsConvertToDouble.Apply(((i - j) + 1L)))));
                }
            }

#line 66 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            MicrosoftQuantumCanonQFT.Adjoint.Apply(new Microsoft.Quantum.Canon.BigEndian(A?.Copy()));
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
                throw new ExecutionFailException("Eror: improper quantum adder usage");
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Apply(new Microsoft.Quantum.Canon.BigEndian(A?.Copy()));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range(0L, i)))
#line hidden
                {
#line hidden
                    Rzk.Controlled.Adjoint.Apply((new QArray<Qubit>()
                    {A[((N - j) - 1L)]}, (B[i], MicrosoftQuantumExtensionsConvertToDouble.Apply(((i - j) + 1L)))));
                }
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Apply(new Microsoft.Quantum.Canon.BigEndian(A?.Copy()));
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
                throw new ExecutionFailException("Eror: improper quantum adder usage");
            }

#line hidden
            MicrosoftQuantumCanonQFT.Controlled.Apply((__controlQubits__?.Copy(), new Microsoft.Quantum.Canon.BigEndian(A?.Copy())));
#line hidden
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line hidden
                foreach (var j in new Range(0L, i))
#line hidden
                {
#line hidden
                    Rzk.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
                    {A[((N - j) - 1L)]}, (B[i], MicrosoftQuantumExtensionsConvertToDouble.Apply(((i - j) + 1L))))));
                }
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), new Microsoft.Quantum.Canon.BigEndian(A?.Copy())));
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
                throw new ExecutionFailException("Eror: improper quantum adder usage");
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), new Microsoft.Quantum.Canon.BigEndian(A?.Copy())));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range(0L, i)))
#line hidden
                {
#line hidden
                    Rzk.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
                    {A[((N - j) - 1L)]}, (B[i], MicrosoftQuantumExtensionsConvertToDouble.Apply(((i - j) + 1L))))));
                }
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), new Microsoft.Quantum.Canon.BigEndian(A?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Rzk = this.Factory.Get<IUnitary<(Qubit,Double)>>(typeof(Rzk));
            this.MicrosoftQuantumCanonQFT = this.Factory.Get<IUnitary<Microsoft.Quantum.Canon.BigEndian>>(typeof(Microsoft.Quantum.Canon.QFT));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> A, QArray<Qubit> B)
        {
            return __m__.Run<efficient_adder, (QArray<Qubit>,QArray<Qubit>), QVoid>((A, B));
        }
    }

    public class efficient_TC_comparator : Unitary<(QArray<Qubit>,QArray<Qubit>,Qubit)>, ICallable
    {
        public efficient_TC_comparator(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "efficient_TC_comparator";
        String ICallable.FullName => "Final_Project.efficient_TC_comparator";
        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> efficient_adder
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

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (d,dmax,target) = __in__;
#line 97 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            var N = d.Length;
#line 98 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            var P = dmax.Length;
#line 101 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            if ((N != P))
            {
#line 102 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                throw new ExecutionFailException("Eror: improper efficient_TC_comparator usage");
            }

#line 105 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, true), MicrosoftQuantumPrimitiveX)).Apply((new QArray<Qubit>(d[0L], dmax[0L]), target));
#line hidden
            {
#line 107 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                var dmax_tmp = Allocate.Apply();
#line 108 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((dmax[0L], dmax_tmp));
#line 109 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                efficient_adder.Adjoint.Apply((dmax?.Copy(), d?.Copy()));
#line 112 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, false, true), MicrosoftQuantumPrimitiveX)).Apply((new QArray<Qubit>(d[0L], dmax_tmp, dmax[0L]), target));
#line 115 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, true), MicrosoftQuantumPrimitiveX)).Apply((new QArray<Qubit>(d[0L], dmax_tmp, dmax[0L]), target));
#line 117 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                efficient_adder.Apply((dmax?.Copy(), d?.Copy()));
#line 118 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((dmax[0L], dmax_tmp));
#line hidden
                Release.Apply(dmax_tmp);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (d,dmax,target) = __in__;
#line hidden
            var N = d.Length;
#line hidden
            var P = dmax.Length;
#line hidden
            if ((N != P))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper efficient_TC_comparator usage");
            }

#line hidden
            {
#line hidden
                var dmax_tmp = Allocate.Apply();
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((dmax[0L], dmax_tmp));
#line hidden
                efficient_adder.Adjoint.Apply((dmax?.Copy(), d?.Copy()));
#line hidden
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, true), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((new QArray<Qubit>(d[0L], dmax_tmp, dmax[0L]), target));
#line hidden
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, false, true), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((new QArray<Qubit>(d[0L], dmax_tmp, dmax[0L]), target));
#line hidden
                efficient_adder.Adjoint.Adjoint.Apply((dmax?.Copy(), d?.Copy()));
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((dmax[0L], dmax_tmp));
#line hidden
                Release.Apply(dmax_tmp);
            }

#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, true), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((new QArray<Qubit>(d[0L], dmax[0L]), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,Qubit)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(d,dmax,target)) = __in__;
#line hidden
            var N = d.Length;
#line hidden
            var P = dmax.Length;
#line hidden
            if ((N != P))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper efficient_TC_comparator usage");
            }

#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, true), MicrosoftQuantumPrimitiveX)).Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(d[0L], dmax[0L]), target)));
#line hidden
            {
#line hidden
                var dmax_tmp = Allocate.Apply();
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (dmax[0L], dmax_tmp)));
#line hidden
                efficient_adder.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (dmax?.Copy(), d?.Copy())));
#line hidden
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, false, true), MicrosoftQuantumPrimitiveX)).Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(d[0L], dmax_tmp, dmax[0L]), target)));
#line hidden
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, true), MicrosoftQuantumPrimitiveX)).Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(d[0L], dmax_tmp, dmax[0L]), target)));
#line hidden
                efficient_adder.Controlled.Apply((__controlQubits__?.Copy(), (dmax?.Copy(), d?.Copy())));
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (dmax[0L], dmax_tmp)));
#line hidden
                Release.Apply(dmax_tmp);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,Qubit)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(d,dmax,target)) = __in__;
#line hidden
            var N = d.Length;
#line hidden
            var P = dmax.Length;
#line hidden
            if ((N != P))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper efficient_TC_comparator usage");
            }

#line hidden
            {
#line hidden
                var dmax_tmp = Allocate.Apply();
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (dmax[0L], dmax_tmp)));
#line hidden
                efficient_adder.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (dmax?.Copy(), d?.Copy())));
#line hidden
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, true), MicrosoftQuantumPrimitiveX)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(d[0L], dmax_tmp, dmax[0L]), target)));
#line hidden
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, false, true), MicrosoftQuantumPrimitiveX)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(d[0L], dmax_tmp, dmax[0L]), target)));
#line hidden
                efficient_adder.Adjoint.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (dmax?.Copy(), d?.Copy())));
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (dmax[0L], dmax_tmp)));
#line hidden
                Release.Apply(dmax_tmp);
            }

#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, true), MicrosoftQuantumPrimitiveX)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(d[0L], dmax[0L]), target)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.efficient_adder = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(efficient_adder));
            this.MicrosoftQuantumCanonControlledOnBitString = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnBitString<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> d, QArray<Qubit> dmax, Qubit target)
        {
            return __m__.Run<efficient_TC_comparator, (QArray<Qubit>,QArray<Qubit>,Qubit), QVoid>((d, dmax, target));
        }
    }

    public class negateBE : Unitary<QArray<Qubit>>, ICallable
    {
        public negateBE(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "negateBE";
        String ICallable.FullName => "Final_Project.negateBE";
        protected IUnitary<(Int64,QArray<Qubit>)> IntegerIncrementBE
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var a = __in__;
#line 128 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            foreach (var q in a)
#line hidden
            {
#line 129 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                MicrosoftQuantumPrimitiveX.Apply(q);
            }

#line 131 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            IntegerIncrementBE.Apply((1L, a?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var a = __in__;
#line hidden
            IntegerIncrementBE.Adjoint.Apply((1L, a?.Copy()));
#line hidden
            foreach (var q in a?.Slice(new Range((a.Length - 1L), -1L, 0L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,a) = __in__;
#line hidden
            foreach (var q in a)
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), q));
            }

#line hidden
            IntegerIncrementBE.Controlled.Apply((__controlQubits__?.Copy(), (1L, a?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,a) = __in__;
#line hidden
            IntegerIncrementBE.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (1L, a?.Copy())));
#line hidden
            foreach (var q in a?.Slice(new Range((a.Length - 1L), -1L, 0L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), q));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.IntegerIncrementBE = this.Factory.Get<IUnitary<(Int64,QArray<Qubit>)>>(typeof(IntegerIncrementBE));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> a)
        {
            return __m__.Run<negateBE, QArray<Qubit>, QVoid>(a);
        }
    }
}