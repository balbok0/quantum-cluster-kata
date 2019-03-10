#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"quantum_neighbourhood_graph\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_4_graph.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"data\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":57}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":66}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"quantum_neighbourhood_graph\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_4_graph.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"quantum_detection_outlier\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_4_graph.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"data\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":55}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":64}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"w\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":72},\"Item2\":{\"Line\":1,\"Column\":73}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"quantum_detection_outlier\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_4_graph.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
#line hidden
namespace Final_Project
{
    public class quantum_neighbourhood_graph : Operation<(QArray<Qubit>,Int64,Int64), QArray<QArray<Int64>>>, ICallable
    {
        public quantum_neighbourhood_graph(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "quantum_neighbourhood_graph";
        String ICallable.FullName => "Final_Project.quantum_neighbourhood_graph";
        protected ICallable<Int64, QArray<QArray<Int64>>> initSquareMatrix
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64,Int64), QArray<QArray<Int64>>> Body => (__in__) =>
        {
            var (data,n,k) = __in__;
#line 7 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_4_graph.qs"
            var graph = initSquareMatrix.Apply(n);
#line 8 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_4_graph.qs"
            foreach (var i in new Range(0L, (n - 1L)))
#line hidden
            {
#line 10 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_4_graph.qs"
                foreach (var j in new Range(0L, (k - 1L)))
#line hidden
                {
                }
            }

#line 15 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_4_graph.qs"
            return graph;
        }

        ;
        public override void Init()
        {
            this.initSquareMatrix = this.Factory.Get<ICallable<Int64, QArray<QArray<Int64>>>>(typeof(initSquareMatrix));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<QArray<Int64>> data) => data;
        public static System.Threading.Tasks.Task<QArray<QArray<Int64>>> Run(IOperationFactory __m__, QArray<Qubit> data, Int64 n, Int64 k)
        {
            return __m__.Run<quantum_neighbourhood_graph, (QArray<Qubit>,Int64,Int64), QArray<QArray<Int64>>>((data, n, k));
        }
    }

    public class quantum_detection_outlier : Operation<(QArray<Qubit>,Int64,Int64,Int64), QArray<Int64>>, ICallable
    {
        public quantum_detection_outlier(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64,Int64,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "quantum_detection_outlier";
        String ICallable.FullName => "Final_Project.quantum_detection_outlier";
        protected ICallable<(QArray<Qubit>,Int64,Int64), QArray<QArray<Int64>>> quantum_neighbourhood_graph
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64,Int64,Int64), QArray<Int64>> Body => (__in__) =>
        {
            var (data,n,k,w) = __in__;
#line 19 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_4_graph.qs"
            var graph = quantum_neighbourhood_graph.Apply((data?.Copy(), n, k));
#line 20 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_4_graph.qs"
            var outliers = new QArray<Int64>(n);
#line 21 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_4_graph.qs"
            foreach (var i in new Range(0L, (n - 1L)))
#line hidden
            {
#line 23 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_4_graph.qs"
                var sum = 0L;
#line 24 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_4_graph.qs"
                foreach (var j in new Range(0L, (k - 1L)))
#line hidden
                {
                }

#line 27 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_4_graph.qs"
                if ((sum > w))
                {
#line 28 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_4_graph.qs"
                    outliers[i] = 1L;
                }
            }

#line 31 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_4_graph.qs"
            return outliers;
        }

        ;
        public override void Init()
        {
            this.quantum_neighbourhood_graph = this.Factory.Get<ICallable<(QArray<Qubit>,Int64,Int64), QArray<QArray<Int64>>>>(typeof(quantum_neighbourhood_graph));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, QArray<Qubit> data, Int64 n, Int64 k, Int64 w)
        {
            return __m__.Run<quantum_detection_outlier, (QArray<Qubit>,Int64,Int64,Int64), QArray<Int64>>((data, n, k, w));
        }
    }
}