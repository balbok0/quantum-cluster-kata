#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"tests\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"tests\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
#line hidden
namespace Final_Project
{
    public class tests : Operation<QVoid, QVoid>, ICallable
    {
        public tests(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "tests";
        String ICallable.FullName => "Final_Project.tests";
        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> experimental_adder
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumExtensionsDiagnosticsDumpRegister
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 8 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                var A = Allocate.Apply(3L);
#line hidden
                {
#line 9 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    var B = Allocate.Apply(3L);
#line 10 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    MicrosoftQuantumPrimitiveX.Apply(B[0L]);
#line 11 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    MicrosoftQuantumPrimitiveX.Apply(B[2L]);
#line 12 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    MicrosoftQuantumPrimitiveX.Apply(A[1L]);
#line 13 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_0.txt", A?.Copy()));
#line 14 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_0b.txt", B?.Copy()));
#line 15 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    experimental_adder.Apply((A?.Copy(), B?.Copy()));
#line 16 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_1.txt", A?.Copy()));
#line 17 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_1b.txt", B?.Copy()));
#line 18 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    ResetAll.Apply(A?.Copy());
#line 19 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    ResetAll.Apply(B?.Copy());
#line hidden
                    Release.Apply(B);
                }

#line hidden
                Release.Apply(A);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.experimental_adder = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(experimental_adder));
            this.MicrosoftQuantumExtensionsDiagnosticsDumpRegister = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Extensions.Diagnostics.DumpRegister<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<tests, QVoid, QVoid>(QVoid.Instance);
        }
    }
}