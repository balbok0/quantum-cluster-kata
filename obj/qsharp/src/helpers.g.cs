#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"PowI\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":17}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"p\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":26}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" PowI given 2 integers a, b returns a^b.\",\"\",\" # Example\",\" ```Q#\",\" let c = PowI(2, 6); // c = 64\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"PowI\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"initSquareMatrix\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":24,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Returns an n x n square matrix filled with 0's.\",\"\",\" # Example\",\" ```Q#\",\" let a = initSquareMatrix(5);\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"initSquareMatrix\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":24,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"initMatrix\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":35,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":31}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" initMatrix returns an a x b matrix filled with 0's.\",\"\",\" # Example\",\" ```Q#\",\" let a = initMatrix(5, 4);\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"initMatrix\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":35,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"SqrtI\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":15}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":17}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[\" Literally a Square Root of Int.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"SqrtI\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":15}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"Sum\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":60,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":13}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"arr\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":14},\"Item2\":{\"Line\":1,\"Column\":17}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Sum returns a sum of all elements in the Integer array.\",\"\",\" # Example\",\" ```Q#\",\" mutable a = new Int[5];\",\" for(i in 0 .. Length(a) - 1) {\",\"     set a[i] = i;\",\" }\",\" let b = Sum(a); // b = 15\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"Sum\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":60,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":13}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"Remove\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":79,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"arr\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"val\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Remove removes all elements with value val from array arr.\",\"\",\" # Example\",\" ```Q#\",\" mutable a = new Int[5];\",\" for(i in 0 .. Length(a) - 1) {\",\"     set a[i] = i;\",\" }\",\" let b = Remove(a, 2); // b = {0, 1, 3, 4}\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"Remove\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":79,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"int_to_boolsBE\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":110,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"size\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Returns a boolean array representation of given integer.\",\" If the boolean representation of integer takes more bits than given size,\",\" Then the array returned is truncated to given size.\",\"\",\" # Example\",\" ```Q#\",\" let b = 5;\",\" let a = int_to_boolsBE(5, 3); // b = {1, 0, 1};\",\" let c = int_to_boolsBE(5, 2); // b = {0, 1};\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"int_to_boolsBE\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":110,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
#line hidden
namespace Final_Project
{
    public class PowI : Function<(Int64,Int64), Int64>, ICallable
    {
        public PowI(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "PowI";
        String ICallable.FullName => "Final_Project.PowI";
        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<(Double,Double), Double> MicrosoftQuantumExtensionsMathPowD
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathRound
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), Int64> Body => (__in__) =>
        {
            var (a,p) = __in__;
#line 15 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            return MicrosoftQuantumExtensionsMathRound.Apply(MicrosoftQuantumExtensionsMathPowD.Apply((MicrosoftQuantumExtensionsConvertToDouble.Apply(a), MicrosoftQuantumExtensionsConvertToDouble.Apply(p))));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathPowD = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(Microsoft.Quantum.Extensions.Math.PowD));
            this.MicrosoftQuantumExtensionsMathRound = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.Round));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a, Int64 p)
        {
            return __m__.Run<PowI, (Int64,Int64), Int64>((a, p));
        }
    }

    public class initSquareMatrix : Function<Int64, QArray<QArray<Int64>>>, ICallable
    {
        public initSquareMatrix(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "initSquareMatrix";
        String ICallable.FullName => "Final_Project.initSquareMatrix";
        protected ICallable<(Int64,Int64), QArray<QArray<Int64>>> initMatrix
        {
            get;
            set;
        }

        public override Func<Int64, QArray<QArray<Int64>>> Body => (__in__) =>
        {
            var n = __in__;
#line 26 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            return initMatrix.Apply((n, n));
        }

        ;
        public override void Init()
        {
            this.initMatrix = this.Factory.Get<ICallable<(Int64,Int64), QArray<QArray<Int64>>>>(typeof(initMatrix));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QArray<QArray<Int64>> data) => data;
        public static System.Threading.Tasks.Task<QArray<QArray<Int64>>> Run(IOperationFactory __m__, Int64 n)
        {
            return __m__.Run<initSquareMatrix, Int64, QArray<QArray<Int64>>>(n);
        }
    }

    public class initMatrix : Function<(Int64,Int64), QArray<QArray<Int64>>>, ICallable
    {
        public initMatrix(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "initMatrix";
        String ICallable.FullName => "Final_Project.initMatrix";
        public override Func<(Int64,Int64), QArray<QArray<Int64>>> Body => (__in__) =>
        {
            var (a,b) = __in__;
#line 37 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            var arr = new QArray<QArray<Int64>>(b);
#line 38 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            foreach (var i in new Range(0L, (b - 1L)))
#line hidden
            {
#line 39 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
                arr[i] = new QArray<Int64>(a);
            }

#line 42 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            return arr;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<QArray<Int64>> data) => data;
        public static System.Threading.Tasks.Task<QArray<QArray<Int64>>> Run(IOperationFactory __m__, Int64 a, Int64 b)
        {
            return __m__.Run<initMatrix, (Int64,Int64), QArray<QArray<Int64>>>((a, b));
        }
    }

    public class SqrtI : Function<Int64, Int64>, ICallable
    {
        public SqrtI(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SqrtI";
        String ICallable.FullName => "Final_Project.SqrtI";
        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathRound
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get;
            set;
        }

        public override Func<Int64, Int64> Body => (__in__) =>
        {
            var a = __in__;
#line 47 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            return MicrosoftQuantumExtensionsMathRound.Apply(MicrosoftQuantumExtensionsMathSqrt.Apply(MicrosoftQuantumExtensionsConvertToDouble.Apply(a)));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathRound = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.Round));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a)
        {
            return __m__.Run<SqrtI, Int64, Int64>(a);
        }
    }

    public class Sum : Function<QArray<Int64>, Int64>, ICallable
    {
        public Sum(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Sum";
        String ICallable.FullName => "Final_Project.Sum";
        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<QArray<Int64>, Int64> Body => (__in__) =>
        {
            var arr = __in__;
#line 62 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            var result = 0L;
#line 63 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            foreach (var i in new Range(0L, (arr.Length - 1L)))
#line hidden
            {
#line 64 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
                result = (result + arr[i]);
            }

#line 66 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn(QArray<Int64> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Int64> arr)
        {
            return __m__.Run<Sum, QArray<Int64>, Int64>(arr);
        }
    }

    public class Remove : Function<(QArray<Int64>,Int64), QArray<Int64>>, ICallable
    {
        public Remove(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64)>, IApplyData
        {
            public In((QArray<Int64>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Remove";
        String ICallable.FullName => "Final_Project.Remove";
        public override Func<(QArray<Int64>,Int64), QArray<Int64>> Body => (__in__) =>
        {
            var (arr,val) = __in__;
#line 81 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            var new_size = 0L;
#line 82 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            foreach (var i in arr)
#line hidden
            {
#line 83 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
                if ((i != val))
                {
#line 84 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
                    new_size = (new_size + 1L);
                }
            }

#line 88 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            var result = new QArray<Int64>(new_size);
#line 89 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            var idx = 0L;
#line 90 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            foreach (var i in arr)
#line hidden
            {
#line 91 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
                if ((i != val))
                {
#line 92 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
                    result[idx] = i;
#line 93 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
                    idx = (idx + 1L);
                }
            }

#line 97 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            return result;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, QArray<Int64> arr, Int64 val)
        {
            return __m__.Run<Remove, (QArray<Int64>,Int64), QArray<Int64>>((arr, val));
        }
    }

    public class int_to_boolsBE : Function<(Int64,Int64), QArray<Boolean>>, ICallable
    {
        public int_to_boolsBE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "int_to_boolsBE";
        String ICallable.FullName => "Final_Project.int_to_boolsBE";
        protected ICallable<System.Numerics.BigInteger, QArray<Boolean>> MicrosoftQuantumExtensionsConvertBigIntToBools
        {
            get;
            set;
        }

        protected ICallable<Int64, System.Numerics.BigInteger> MicrosoftQuantumExtensionsConvertToBigInt
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), QArray<Boolean>> Body => (__in__) =>
        {
            var (a,size) = __in__;
#line 112 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            var tmp = MicrosoftQuantumExtensionsConvertBigIntToBools.Apply(MicrosoftQuantumExtensionsConvertToBigInt.Apply(a));
#line 113 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            tmp = tmp?.Slice(new Range(0L, (size - 1L)));
#line 114 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            var result = new QArray<Boolean>(size);
#line 115 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            foreach (var i in new Range(0L, (size - 1L)))
#line hidden
            {
#line 116 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
                result[i] = tmp[((size - i) - 1L)];
            }

#line 118 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsConvertBigIntToBools = this.Factory.Get<ICallable<System.Numerics.BigInteger, QArray<Boolean>>>(typeof(Microsoft.Quantum.Extensions.Convert.BigIntToBools));
            this.MicrosoftQuantumExtensionsConvertToBigInt = this.Factory.Get<ICallable<Int64, System.Numerics.BigInteger>>(typeof(Microsoft.Quantum.Extensions.Convert.ToBigInt));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<QArray<Boolean>> Run(IOperationFactory __m__, Int64 a, Int64 size)
        {
            return __m__.Run<int_to_boolsBE, (Int64,Int64), QArray<Boolean>>((a, size));
        }
    }
}