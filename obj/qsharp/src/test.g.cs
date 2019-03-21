#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"tests\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Tests for all adders, comparators, and rotations\",\"\",\" # Example\",\" ```Q#\",\" tests();\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"tests\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"test_rzk\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Tests Rz_k gate on single qubit for some rotation\",\"\",\" # Example\",\" ```Q#\",\" test_rzk();\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"test_rzk\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"thorough_adder_test\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Tests all possible additions for n-bit adder\",\"\",\" # Example\",\" ```Q#\",\" thorough_adder_test(4);\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"thorough_adder_test\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"thorough_comp_test\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":72,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":32}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Tests all possible  combinations for n-bit comparator\",\"\",\" # Example\",\" ```Q#\",\" thorough_comp_test(4);\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"thorough_comp_test\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs\",\"Position\":{\"Item1\":72,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
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
        protected ICallable<QVoid, QVoid> test_rzk
        {
            get;
            set;
        }

        protected ICallable<Int64, QVoid> thorough_adder_test
        {
            get;
            set;
        }

        protected ICallable<Int64, QVoid> thorough_comp_test
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 16 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
            thorough_adder_test.Apply(4L);
#line 17 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
            thorough_comp_test.Apply(4L);
#line 18 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
            test_rzk.Apply(QVoid.Instance);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.test_rzk = this.Factory.Get<ICallable<QVoid, QVoid>>(typeof(test_rzk));
            this.thorough_adder_test = this.Factory.Get<ICallable<Int64, QVoid>>(typeof(thorough_adder_test));
            this.thorough_comp_test = this.Factory.Get<ICallable<Int64, QVoid>>(typeof(thorough_comp_test));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<tests, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class test_rzk : Operation<QVoid, QVoid>, ICallable
    {
        public test_rzk(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "test_rzk";
        String ICallable.FullName => "Final_Project.test_rzk";
        protected IUnitary<(Qubit,Double)> Rzk
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 30 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                var A = Allocate.Apply();
#line 31 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                MicrosoftQuantumPrimitiveX.Apply(A);
#line 32 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                Rzk.Apply((A, 1D));
#line 33 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("tests/rzk_test.txt", new QArray<Qubit>()
                {A}));
#line 34 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                Reset.Apply(A);
#line hidden
                Release.Apply(A);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Rzk = this.Factory.Get<IUnitary<(Qubit,Double)>>(typeof(Rzk));
            this.MicrosoftQuantumExtensionsDiagnosticsDumpRegister = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Extensions.Diagnostics.DumpRegister<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<test_rzk, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class thorough_adder_test : Operation<Int64, QVoid>, ICallable
    {
        public thorough_adder_test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "thorough_adder_test";
        String ICallable.FullName => "Final_Project.thorough_adder_test";
        protected ICallable<(Int64,Int64), Int64> PowI
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> efficient_adder
        {
            get;
            set;
        }

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

        protected ICallable<Microsoft.Quantum.Canon.BigEndian, Int64> MicrosoftQuantumCanonMeasureIntegerBE
        {
            get;
            set;
        }

        protected ICallable<Int64, String> MicrosoftQuantumExtensionsConvertToStringI
        {
            get;
            set;
        }

        protected Allocate Allocate
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

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        public override Func<Int64, QVoid> Body => (__in__) =>
        {
            var n = __in__;
#line 46 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
            var N = PowI.Apply((2L, n));
#line hidden
            {
#line 47 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                var A = Allocate.Apply(n);
#line hidden
                {
#line 48 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    var B = Allocate.Apply(n);
#line 49 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                    {
#line 50 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        foreach (var j in new Range(0L, (N - 1L)))
#line hidden
                        {
#line 51 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumCanonIntegerIncrementLE.Apply((i, MicrosoftQuantumCanonBigEndianToLittleEndian.Apply(new Microsoft.Quantum.Canon.BigEndian(A?.Copy()))));
#line 52 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            MicrosoftQuantumCanonIntegerIncrementLE.Apply((j, MicrosoftQuantumCanonBigEndianToLittleEndian.Apply(new Microsoft.Quantum.Canon.BigEndian(B?.Copy()))));
#line 53 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            efficient_adder.Apply((A?.Copy(), B?.Copy()));
#line 54 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            var r = MicrosoftQuantumExtensionsConvertToStringI.Apply(MicrosoftQuantumCanonMeasureIntegerBE.Apply(new Microsoft.Quantum.Canon.BigEndian(A?.Copy())));
#line 55 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            var b = MicrosoftQuantumExtensionsConvertToStringI.Apply(MicrosoftQuantumCanonMeasureIntegerBE.Apply(new Microsoft.Quantum.Canon.BigEndian(B?.Copy())));
#line 56 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            var a = MicrosoftQuantumExtensionsConvertToStringI.Apply(i);
#line 57 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            Message.Apply(((((a + " + ") + b) + " = ") + r));
#line 58 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            ResetAll.Apply(A?.Copy());
#line 59 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            ResetAll.Apply(B?.Copy());
                        }
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
            this.PowI = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(PowI));
            this.efficient_adder = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(efficient_adder));
            this.MicrosoftQuantumCanonBigEndianToLittleEndian = this.Factory.Get<ICallable<Microsoft.Quantum.Canon.BigEndian, Microsoft.Quantum.Canon.LittleEndian>>(typeof(Microsoft.Quantum.Canon.BigEndianToLittleEndian));
            this.MicrosoftQuantumCanonIntegerIncrementLE = this.Factory.Get<IUnitary<(Int64,Microsoft.Quantum.Canon.LittleEndian)>>(typeof(Microsoft.Quantum.Canon.IntegerIncrementLE));
            this.MicrosoftQuantumCanonMeasureIntegerBE = this.Factory.Get<ICallable<Microsoft.Quantum.Canon.BigEndian, Int64>>(typeof(Microsoft.Quantum.Canon.MeasureIntegerBE));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 n)
        {
            return __m__.Run<thorough_adder_test, Int64, QVoid>(n);
        }
    }

    public class thorough_comp_test : Operation<Int64, QVoid>, ICallable
    {
        public thorough_comp_test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "thorough_comp_test";
        String ICallable.FullName => "Final_Project.thorough_comp_test";
        protected ICallable<(Int64,Int64), Int64> PowI
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,Qubit)> efficient_TC_comparator
        {
            get;
            set;
        }

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

        protected ICallable<Microsoft.Quantum.Canon.BigEndian, Int64> MicrosoftQuantumCanonMeasureIntegerBE
        {
            get;
            set;
        }

        protected ICallable<Boolean, String> MicrosoftQuantumExtensionsConvertToStringB
        {
            get;
            set;
        }

        protected ICallable<Int64, String> MicrosoftQuantumExtensionsConvertToStringI
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

        public override Func<Int64, QVoid> Body => (__in__) =>
        {
            var n = __in__;
#line 74 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
            var N = PowI.Apply((2L, n));
#line hidden
            {
#line 75 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                var A = Allocate.Apply(n);
#line hidden
                {
#line 76 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                    var B = Allocate.Apply(n);
#line hidden
                    {
#line 77 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        var c = Allocate.Apply();
#line 78 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                        foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                        {
#line 79 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                            foreach (var j in new Range(0L, (N - 1L)))
#line hidden
                            {
#line 80 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                                MicrosoftQuantumCanonIntegerIncrementLE.Apply((i, MicrosoftQuantumCanonBigEndianToLittleEndian.Apply(new Microsoft.Quantum.Canon.BigEndian(A?.Copy()))));
#line 81 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                                MicrosoftQuantumCanonIntegerIncrementLE.Apply((j, MicrosoftQuantumCanonBigEndianToLittleEndian.Apply(new Microsoft.Quantum.Canon.BigEndian(B?.Copy()))));
#line 82 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                                efficient_TC_comparator.Apply((A?.Copy(), B?.Copy(), c));
#line 83 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                                var r = MicrosoftQuantumExtensionsConvertToStringB.Apply((M.Apply(c) == Result.One));
#line 84 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                                var b = MicrosoftQuantumExtensionsConvertToStringI.Apply(MicrosoftQuantumCanonMeasureIntegerBE.Apply(new Microsoft.Quantum.Canon.BigEndian(B?.Copy())));
#line 85 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                                var a = MicrosoftQuantumExtensionsConvertToStringI.Apply(MicrosoftQuantumCanonMeasureIntegerBE.Apply(new Microsoft.Quantum.Canon.BigEndian(A?.Copy())));
#line 86 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                                Message.Apply(((((a + " > ") + b) + " is ") + r));
#line 87 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                                ResetAll.Apply(A?.Copy());
#line 88 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                                ResetAll.Apply(B?.Copy());
#line 89 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/test.qs"
                                Reset.Apply(c);
                            }
                        }

#line hidden
                        Release.Apply(c);
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
            this.PowI = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(PowI));
            this.efficient_TC_comparator = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,Qubit)>>(typeof(efficient_TC_comparator));
            this.MicrosoftQuantumCanonBigEndianToLittleEndian = this.Factory.Get<ICallable<Microsoft.Quantum.Canon.BigEndian, Microsoft.Quantum.Canon.LittleEndian>>(typeof(Microsoft.Quantum.Canon.BigEndianToLittleEndian));
            this.MicrosoftQuantumCanonIntegerIncrementLE = this.Factory.Get<IUnitary<(Int64,Microsoft.Quantum.Canon.LittleEndian)>>(typeof(Microsoft.Quantum.Canon.IntegerIncrementLE));
            this.MicrosoftQuantumCanonMeasureIntegerBE = this.Factory.Get<ICallable<Microsoft.Quantum.Canon.BigEndian, Int64>>(typeof(Microsoft.Quantum.Canon.MeasureIntegerBE));
            this.MicrosoftQuantumExtensionsConvertToStringB = this.Factory.Get<ICallable<Boolean, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringB));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 n)
        {
            return __m__.Run<thorough_comp_test, Int64, QVoid>(n);
        }
    }
}