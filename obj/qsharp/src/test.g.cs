#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"tests\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"tests\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG_adder_test\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG_adder_test\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG_int_adder_test\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":34,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG_int_adder_test\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":34,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
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
        protected ICallable<QVoid, QVoid> SCG_int_adder_test
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 8 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
            SCG_int_adder_test.Apply(QVoid.Instance);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.SCG_int_adder_test = this.Factory.Get<ICallable<QVoid, QVoid>>(typeof(SCG_int_adder_test));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<tests, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class SCG_adder_test : Operation<QVoid, QVoid>, ICallable
    {
        public SCG_adder_test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SCG_adder_test";
        String ICallable.FullName => "Final_Project.SCG_adder_test";
        protected IUnitary<(Boolean,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>)> TC_add_sub
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

        protected ICallable<Qubit, QVoid> Reset
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
#line 12 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                var A = Allocate.Apply(4L);
#line hidden
                {
#line 13 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    var B = Allocate.Apply(4L);
#line hidden
                    {
#line 14 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        var carry = Allocate.Apply();
#line hidden
                        {
#line 15 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            var Target = Allocate.Apply(4L);
#line 16 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumPrimitiveX.Apply(A[1L]);
#line 17 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumPrimitiveX.Apply(B[1L]);
#line 18 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumPrimitiveX.Apply(B[0L]);
#line 19 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_0.txt", A?.Copy()));
#line 20 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_0b.txt", B?.Copy()));
#line 21 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            TC_add_sub.Apply((false, A?.Copy(), B?.Copy(), carry, Target?.Copy()));
#line 22 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_1.txt", A?.Copy()));
#line 23 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_1b.txt", B?.Copy()));
#line 24 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_1T.txt", Target?.Copy()));
#line 25 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            ResetAll.Apply(A?.Copy());
#line 26 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            ResetAll.Apply(B?.Copy());
#line 27 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            Reset.Apply(carry);
#line 28 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            ResetAll.Apply(Target?.Copy());
#line hidden
                            Release.Apply(Target);
                        }

#line hidden
                        Release.Apply(carry);
                    }

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
            this.TC_add_sub = this.Factory.Get<IUnitary<(Boolean,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>)>>(typeof(TC_add_sub));
            this.MicrosoftQuantumExtensionsDiagnosticsDumpRegister = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Extensions.Diagnostics.DumpRegister<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<SCG_adder_test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class SCG_int_adder_test : Operation<QVoid, QVoid>, ICallable
    {
        public SCG_int_adder_test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SCG_int_adder_test";
        String ICallable.FullName => "Final_Project.SCG_int_adder_test";
        protected IUnitary<(Int64,QArray<Qubit>,Qubit,QArray<Qubit>)> TC_add_int
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

        protected ICallable<Qubit, QVoid> Reset
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
#line 36 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                var A = Allocate.Apply(4L);
#line hidden
                {
#line 37 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    var B = Allocate.Apply(4L);
#line hidden
                    {
#line 38 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        var carry = Allocate.Apply();
#line 39 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        MicrosoftQuantumPrimitiveX.Apply(A[1L]);
#line 40 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_0.txt", A?.Copy()));
#line 41 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_0b.txt", B?.Copy()));
#line 42 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        TC_add_int.Apply((3L, A?.Copy(), carry, B?.Copy()));
#line 43 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_1.txt", A?.Copy()));
#line 44 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_1b.txt", B?.Copy()));
#line 45 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        ResetAll.Apply(A?.Copy());
#line 46 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        ResetAll.Apply(B?.Copy());
#line 47 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        Reset.Apply(carry);
#line hidden
                        Release.Apply(carry);
                    }

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
            this.TC_add_int = this.Factory.Get<IUnitary<(Int64,QArray<Qubit>,Qubit,QArray<Qubit>)>>(typeof(TC_add_int));
            this.MicrosoftQuantumExtensionsDiagnosticsDumpRegister = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Extensions.Diagnostics.DumpRegister<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<SCG_int_adder_test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}