#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"PowI\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":17}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"p\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":26}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"PowI\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"initSquareMatrix\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"initSquareMatrix\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"initMatrix\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":31}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"initMatrix\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"int_to_boolsBE\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":23,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":26}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"int_to_boolsBE\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs\",\"Position\":{\"Item1\":23,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
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
#line 8 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
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
#line 12 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
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
#line 16 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            var arr = new QArray<QArray<Int64>>(b);
#line 17 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            foreach (var i in new Range(0L, (b - 1L)))
#line hidden
            {
#line 18 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
                arr[i] = new QArray<Int64>(a);
            }

#line 21 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
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

    public class int_to_boolsBE : Function<Int64, QArray<Boolean>>, ICallable
    {
        public int_to_boolsBE(IOperationFactory m) : base(m)
        {
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

        public override Func<Int64, QArray<Boolean>> Body => (__in__) =>
        {
            var a = __in__;
#line 25 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/helpers.qs"
            return MicrosoftQuantumExtensionsConvertBigIntToBools.Apply(MicrosoftQuantumExtensionsConvertToBigInt.Apply(a));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsConvertBigIntToBools = this.Factory.Get<ICallable<System.Numerics.BigInteger, QArray<Boolean>>>(typeof(Microsoft.Quantum.Extensions.Convert.BigIntToBools));
            this.MicrosoftQuantumExtensionsConvertToBigInt = this.Factory.Get<ICallable<Int64, System.Numerics.BigInteger>>(typeof(Microsoft.Quantum.Extensions.Convert.ToBigInt));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<QArray<Boolean>> Run(IOperationFactory __m__, Int64 a)
        {
            return __m__.Run<int_to_boolsBE, Int64, QArray<Boolean>>(a);
        }
    }
}