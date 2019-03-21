#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"quantum_neighbourhood_graph\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"m\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"indices\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":65}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":74},\"Item2\":{\"Line\":1,\"Column\":75}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"distances\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":83},\"Item2\":{\"Line\":1,\"Column\":92}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"quantum_neighbourhood_graph\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"quantum_detection_outlier\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"m\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"indices\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":63}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":72},\"Item2\":{\"Line\":1,\"Column\":73}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"w\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":81},\"Item2\":{\"Line\":1,\"Column\":82}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"distances\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":90},\"Item2\":{\"Line\":1,\"Column\":99}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"quantum_detection_outlier\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
#line hidden
namespace Final_Project
{
    public class quantum_neighbourhood_graph : Operation<(Int64,Int64,QArray<Int64>,Int64,QArray<Int64>), QArray<QArray<Int64>>>, ICallable
    {
        public quantum_neighbourhood_graph(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,QArray<Int64>,Int64,QArray<Int64>)>, IApplyData
        {
            public In((Int64,Int64,QArray<Int64>,Int64,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "quantum_neighbourhood_graph";
        String ICallable.FullName => "Final_Project.quantum_neighbourhood_graph";
        protected ICallable<(Int64,Int64), Int64> PowI
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> SqrtI
        {
            get;
            set;
        }

        protected ICallable<Int64, QArray<QArray<Int64>>> initSquareMatrix
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,QArray<Int64>,Int64,QArray<Int64>), QArray<QArray<Int64>>> quant_find_k_smallest
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,QArray<Int64>,Int64,QArray<Int64>), QArray<QArray<Int64>>> Body => (__in__) =>
        {
            var (n,m,indices,k,distances) = __in__;
#line 8 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
            var N = PowI.Apply((2L, n));
#line 9 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
            var graph = initSquareMatrix.Apply(N);
#line 10 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 12 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
                var results = quant_find_k_smallest.Apply((N, m, indices?.Copy(), k, distances?.Copy()));
#line 15 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
                foreach (var j in new Range(0L, (k - 1L)))
#line hidden
                {
#line 16 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
                    graph[i][results[j][0L]] = distances[((i * SqrtI.Apply(distances.Length)) + results[j][0L])];
#line 17 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
                    graph[results[j][0L]][i] = distances[((results[j][0L] * SqrtI.Apply(distances.Length)) + i)];
                }
            }

#line 20 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
            return graph;
        }

        ;
        public override void Init()
        {
            this.PowI = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(PowI));
            this.SqrtI = this.Factory.Get<ICallable<Int64, Int64>>(typeof(SqrtI));
            this.initSquareMatrix = this.Factory.Get<ICallable<Int64, QArray<QArray<Int64>>>>(typeof(initSquareMatrix));
            this.quant_find_k_smallest = this.Factory.Get<ICallable<(Int64,Int64,QArray<Int64>,Int64,QArray<Int64>), QArray<QArray<Int64>>>>(typeof(quant_find_k_smallest));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((Int64,Int64,QArray<Int64>,Int64,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QArray<QArray<Int64>> data) => data;
        public static System.Threading.Tasks.Task<QArray<QArray<Int64>>> Run(IOperationFactory __m__, Int64 n, Int64 m, QArray<Int64> indices, Int64 k, QArray<Int64> distances)
        {
            return __m__.Run<quantum_neighbourhood_graph, (Int64,Int64,QArray<Int64>,Int64,QArray<Int64>), QArray<QArray<Int64>>>((n, m, indices, k, distances));
        }
    }

    public class quantum_detection_outlier : Operation<(Int64,Int64,QArray<Int64>,Int64,Int64,QArray<Int64>), QArray<Int64>>, ICallable
    {
        public quantum_detection_outlier(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,QArray<Int64>,Int64,Int64,QArray<Int64>)>, IApplyData
        {
            public In((Int64,Int64,QArray<Int64>,Int64,Int64,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "quantum_detection_outlier";
        String ICallable.FullName => "Final_Project.quantum_detection_outlier";
        protected ICallable<(Int64,Int64), Int64> PowI
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,QArray<Int64>,Int64,QArray<Int64>), QArray<QArray<Int64>>> quantum_neighbourhood_graph
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

        public override Func<(Int64,Int64,QArray<Int64>,Int64,Int64,QArray<Int64>), QArray<Int64>> Body => (__in__) =>
        {
            var (n,m,indices,k,w,distances) = __in__;
#line 24 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
            var graph = quantum_neighbourhood_graph.Apply((n, m, indices?.Copy(), k, distances?.Copy()));
#line 25 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
            var N = PowI.Apply((2L, n));
#line 26 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
            var outliers = new QArray<Int64>(N);
#line 27 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 29 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
                var sum = 0L;
#line 30 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
                foreach (var j in new Range(0L, (k - 1L)))
#line hidden
                {
#line 31 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
                    sum = (sum + graph[i][j]);
                }

#line 35 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
                Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply(sum));
#line 37 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
                if ((sum > w))
                {
#line 38 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
                    outliers[i] = 1L;
                }
            }

#line 41 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_2_graph.qs"
            return outliers;
        }

        ;
        public override void Init()
        {
            this.PowI = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(PowI));
            this.quantum_neighbourhood_graph = this.Factory.Get<ICallable<(Int64,Int64,QArray<Int64>,Int64,QArray<Int64>), QArray<QArray<Int64>>>>(typeof(quantum_neighbourhood_graph));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
        }

        public override IApplyData __dataIn((Int64,Int64,QArray<Int64>,Int64,Int64,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, Int64 n, Int64 m, QArray<Int64> indices, Int64 k, Int64 w, QArray<Int64> distances)
        {
            return __m__.Run<quantum_detection_outlier, (Int64,Int64,QArray<Int64>,Int64,Int64,QArray<Int64>), QArray<Int64>>((n, m, indices, k, w, distances));
        }
    }
}