#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"tests\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"tests\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"comp_test\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"comp_test\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG_sub_test\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":34,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG_sub_test\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":34,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG_adder_test\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG_adder_test\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG_int_adder_test\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":82,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"SCG_int_adder_test\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":82,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
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
        protected ICallable<QVoid, QVoid> comp_test
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 8 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
            comp_test.Apply(QVoid.Instance);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.comp_test = this.Factory.Get<ICallable<QVoid, QVoid>>(typeof(comp_test));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<tests, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class comp_test : Operation<QVoid, QVoid>, ICallable
    {
        public comp_test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "comp_test";
        String ICallable.FullName => "Final_Project.comp_test";
        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>)> TC_comparator
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

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
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
                        var b = Allocate.Apply();
#line hidden
                        {
#line 15 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            var garb = Allocate.Apply(4L);
#line 16 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumPrimitiveX.Apply(B[2L]);
#line 17 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumPrimitiveX.Apply(A[1L]);
#line 18 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            TC_comparator.Apply((A?.Copy(), B?.Copy(), b, garb?.Copy()));
#line 19 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("comp_garbage.txt", garb?.Copy()));
#line 20 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            if ((M.Apply(b) == Result.One))
                            {
#line 21 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                                Message.Apply("1");
                            }
                            else
                            {
#line 23 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                                Message.Apply("0");
                            }

#line 25 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            ResetAll.Apply(A?.Copy());
#line 26 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            ResetAll.Apply(B?.Copy());
#line 27 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            Reset.Apply(b);
#line 28 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            ResetAll.Apply(garb?.Copy());
#line hidden
                            Release.Apply(garb);
                        }

#line hidden
                        Release.Apply(b);
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
            this.TC_comparator = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>)>>(typeof(TC_comparator));
            this.MicrosoftQuantumExtensionsDiagnosticsDumpRegister = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Extensions.Diagnostics.DumpRegister<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<comp_test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class SCG_sub_test : Operation<QVoid, QVoid>, ICallable
    {
        public SCG_sub_test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SCG_sub_test";
        String ICallable.FullName => "Final_Project.SCG_sub_test";
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
#line hidden
                        {
#line 39 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            var Target = Allocate.Apply(4L);
#line 40 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumPrimitiveX.Apply(A[1L]);
#line 41 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumPrimitiveX.Apply(B[1L]);
#line 42 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumPrimitiveX.Apply(B[0L]);
#line 43 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_0.txt", A?.Copy()));
#line 44 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_0b.txt", B?.Copy()));
#line 45 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            TC_add_sub.Apply((true, A?.Copy(), B?.Copy(), carry, Target?.Copy()));
#line 46 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_1.txt", A?.Copy()));
#line 47 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_1b.txt", B?.Copy()));
#line 48 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_1T.txt", Target?.Copy()));
#line 49 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            ResetAll.Apply(A?.Copy());
#line 50 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            ResetAll.Apply(B?.Copy());
#line 51 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            Reset.Apply(carry);
#line 52 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
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
            return __m__.Run<SCG_sub_test, QVoid, QVoid>(QVoid.Instance);
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
#line 60 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                var A = Allocate.Apply(4L);
#line hidden
                {
#line 61 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    var B = Allocate.Apply(4L);
#line hidden
                    {
#line 62 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        var carry = Allocate.Apply();
#line hidden
                        {
#line 63 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            var Target = Allocate.Apply(4L);
#line 64 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumPrimitiveX.Apply(A[1L]);
#line 65 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumPrimitiveX.Apply(B[1L]);
#line 66 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumPrimitiveX.Apply(B[0L]);
#line 67 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_0.txt", A?.Copy()));
#line 68 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_0b.txt", B?.Copy()));
#line 69 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            TC_add_sub.Apply((false, A?.Copy(), B?.Copy(), carry, Target?.Copy()));
#line 70 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_1.txt", A?.Copy()));
#line 71 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_1b.txt", B?.Copy()));
#line 72 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_1T.txt", Target?.Copy()));
#line 73 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            ResetAll.Apply(A?.Copy());
#line 74 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            ResetAll.Apply(B?.Copy());
#line 75 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            Reset.Apply(carry);
#line 76 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
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
#line 84 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                var A = Allocate.Apply(4L);
#line hidden
                {
#line 85 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    var B = Allocate.Apply(4L);
#line hidden
                    {
#line 86 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        var carry = Allocate.Apply();
#line 87 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        MicrosoftQuantumPrimitiveX.Apply(A[1L]);
#line 88 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_0.txt", A?.Copy()));
#line 89 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_0b.txt", B?.Copy()));
#line 90 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        TC_add_int.Apply((3L, A?.Copy(), carry, B?.Copy()));
#line 91 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_1.txt", A?.Copy()));
#line 92 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("adder_testing_1b.txt", B?.Copy()));
#line 93 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        ResetAll.Apply(A?.Copy());
#line 94 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        ResetAll.Apply(B?.Copy());
#line 95 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
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