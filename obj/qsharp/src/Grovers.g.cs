#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"GroverIteration\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":60}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":69},\"Item2\":{\"Line\":1,\"Column\":75}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[\" # Summary\",\" GroverIteration is a single step in Grover Algorithm.\",\" For more insightful description look at Grovers Kata.\",\"\",\" # Example\",\" ```Q#\",\" using ((x, y, t) = (Qubit[4], Qubit[4], Qubit())) {\",\"     GroverIteration(x, y, t, distance_cmp);\",\" }\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"GroverIteration\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs\",\"Position\":{\"Item1\":18,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"GroverIteration\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs\",\"Position\":{\"Item1\":37,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"GroversSearch\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs\",\"Position\":{\"Item1\":50,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":58}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":68},\"Item2\":{\"Line\":1,\"Column\":74}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"iterations\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":124},\"Item2\":{\"Line\":1,\"Column\":134}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[\" # Summary\",\" GroverSearch is a performing iterations steps in Grover Algorithm.\",\" For more insightful description look at Grovers Kata.\",\"\",\" # Example\",\" ```Q#\",\" using ((x, y, t) = (Qubit[4], Qubit[4], Qubit())) {\",\"     GroverSearch(x, y, t, distance_cmp, 4);\",\" }\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"GroversSearch\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs\",\"Position\":{\"Item1\":51,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"GroversSearch\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs\",\"Position\":{\"Item1\":60,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace Final_Project
{
    public class GroverIteration : Adjointable<(QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable)>, ICallable
    {
        public GroverIteration(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "GroverIteration";
        String ICallable.FullName => "Final_Project.GroverIteration";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonMost
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonTail
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (x,y,target,oracle) = __in__;
#line 20 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs"
            oracle.Apply((x?.Copy(), y?.Copy(), target));
#line 22 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveH, x?.Copy()));
#line 23 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line 25 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveH, y?.Copy()));
#line 26 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, y?.Copy()));
#line 28 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs"
            MicrosoftQuantumPrimitiveZ.Controlled.Apply((MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(x), MicrosoftQuantumCanonTail.Apply<Qubit>(x)));
#line 29 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs"
            MicrosoftQuantumPrimitiveZ.Controlled.Apply((MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(y), MicrosoftQuantumCanonTail.Apply<Qubit>(y)));
#line 31 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, y?.Copy()));
#line 32 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveH, y?.Copy()));
#line 34 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line 35 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveH, x?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y,target,oracle) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveH, x?.Copy()));
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveH, y?.Copy()));
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, y?.Copy()));
#line hidden
            MicrosoftQuantumPrimitiveZ.Controlled.Adjoint.Apply((MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(y), MicrosoftQuantumCanonTail.Apply<Qubit>(y)));
#line hidden
            MicrosoftQuantumPrimitiveZ.Controlled.Adjoint.Apply((MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(x), MicrosoftQuantumCanonTail.Apply<Qubit>(x)));
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, y?.Copy()));
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveH, y?.Copy()));
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveH, x?.Copy()));
#line hidden
            oracle.Adjoint.Apply((x?.Copy(), y?.Copy(), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumCanonMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Most<>));
            this.MicrosoftQuantumCanonTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, QArray<Qubit> y, Qubit target, IAdjointable oracle)
        {
            return __m__.Run<GroverIteration, (QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable), QVoid>((x, y, target, oracle));
        }
    }

    public class GroversSearch : Adjointable<(QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable,Int64)>, ICallable
    {
        public GroversSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "GroversSearch";
        String ICallable.FullName => "Final_Project.GroversSearch";
        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable)> GroverIteration
        {
            get;
            set;
        }

        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable,Int64), QVoid> Body => (__in__) =>
        {
            var (x,y,target,oracle,iterations) = __in__;
#line 53 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveH, x?.Copy()));
#line 54 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveH, y?.Copy()));
#line 56 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs"
            foreach (var i in new Range(1L, iterations))
#line hidden
            {
#line 57 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Grovers.qs"
                GroverIteration.Apply((x?.Copy(), y?.Copy(), target, oracle));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y,target,oracle,iterations) = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(1L, iterations)))
#line hidden
            {
#line hidden
                GroverIteration.Adjoint.Apply((x?.Copy(), y?.Copy(), target, oracle));
            }

#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveH, y?.Copy()));
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveH, x?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.GroverIteration = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable)>>(typeof(GroverIteration));
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, QArray<Qubit> y, Qubit target, IAdjointable oracle, Int64 iterations)
        {
            return __m__.Run<GroversSearch, (QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable,Int64), QVoid>((x, y, target, oracle, iterations));
        }
    }
}