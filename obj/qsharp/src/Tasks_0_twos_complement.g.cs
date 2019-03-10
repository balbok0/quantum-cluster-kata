#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_negate\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"TC\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":23}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_negate\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":9,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_negate\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":26,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_negate\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":27,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_negate\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":28,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_prepare\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":31,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"TC\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_prepare\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":32,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_prepare\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":41,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_prepare\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":42,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_prepare\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":43,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_add_sub\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":46,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"sub\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"TC_A\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"TC_B\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"carry\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":71}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"TC_target\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":81},\"Item2\":{\"Line\":1,\"Column\":90}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_add_sub\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":47,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_add_sub\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":72,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_add_sub\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":73,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_add_sub\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":74,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_construct_targ\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":77,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"GARBAGE\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":60}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_construct_targ\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":77,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_comparator\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":85,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"d\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"dmax\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":55}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"GARBAGE\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_comparator\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":86,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_comparator\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":97,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_comparator\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":98,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_comparator\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":99,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_add_int\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":102,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"INT_A\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"TC_B\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"carry\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"TC_target\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":75}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_add_int\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":103,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_add_int\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":115,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_add_int\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":116,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"TC_add_int\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs\",\"Position\":{\"Item1\":117,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
#line hidden
namespace Final_Project
{
    public class TC_negate : Unitary<QArray<Qubit>>, ICallable
    {
        public TC_negate(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TC_negate";
        String ICallable.FullName => "Final_Project.TC_negate";
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
            var TC = __in__;
#line 11 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            var N = TC.Length;
#line 12 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            if ((N != 4L))
            {
#line 13 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                throw new ExecutionFailException("Eror: Only N = 4 Currently Implemented for TC_negate");
            }

#line 16 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>(TC[0L], TC[1L], TC[2L]), TC[3L]));
#line 17 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>(TC[1L], TC[2L]), TC[3L]));
#line 18 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>(TC[0L], TC[2L]), TC[3L]));
#line 19 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>(TC[0L], TC[1L]), TC[2L]));
#line 20 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>()
            {TC[2L]}, TC[3L]));
#line 21 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>()
            {TC[1L]}, TC[3L]));
#line 22 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>()
            {TC[1L]}, TC[2L]));
#line 23 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>()
            {TC[0L]}, TC[3L]));
#line 24 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>()
            {TC[0L]}, TC[2L]));
#line 25 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>()
            {TC[0L]}, TC[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var TC = __in__;
#line hidden
            var N = TC.Length;
#line hidden
            if ((N != 4L))
            {
#line hidden
                throw new ExecutionFailException("Eror: Only N = 4 Currently Implemented for TC_negate");
            }

#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {TC[0L]}, TC[1L]));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {TC[0L]}, TC[2L]));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {TC[0L]}, TC[3L]));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {TC[1L]}, TC[2L]));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {TC[1L]}, TC[3L]));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {TC[2L]}, TC[3L]));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>(TC[0L], TC[1L]), TC[2L]));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>(TC[0L], TC[2L]), TC[3L]));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>(TC[1L], TC[2L]), TC[3L]));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>(TC[0L], TC[1L], TC[2L]), TC[3L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,TC) = __in__;
#line hidden
            var N = TC.Length;
#line hidden
            if ((N != 4L))
            {
#line hidden
                throw new ExecutionFailException("Eror: Only N = 4 Currently Implemented for TC_negate");
            }

#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(TC[0L], TC[1L], TC[2L]), TC[3L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(TC[1L], TC[2L]), TC[3L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(TC[0L], TC[2L]), TC[3L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(TC[0L], TC[1L]), TC[2L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
            {TC[2L]}, TC[3L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
            {TC[1L]}, TC[3L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
            {TC[1L]}, TC[2L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
            {TC[0L]}, TC[3L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
            {TC[0L]}, TC[2L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
            {TC[0L]}, TC[1L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,TC) = __in__;
#line hidden
            var N = TC.Length;
#line hidden
            if ((N != 4L))
            {
#line hidden
                throw new ExecutionFailException("Eror: Only N = 4 Currently Implemented for TC_negate");
            }

#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
            {TC[0L]}, TC[1L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
            {TC[0L]}, TC[2L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
            {TC[0L]}, TC[3L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
            {TC[1L]}, TC[2L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
            {TC[1L]}, TC[3L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
            {TC[2L]}, TC[3L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(TC[0L], TC[1L]), TC[2L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(TC[0L], TC[2L]), TC[3L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(TC[1L], TC[2L]), TC[3L])));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(TC[0L], TC[1L], TC[2L]), TC[3L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> TC)
        {
            return __m__.Run<TC_negate, QArray<Qubit>, QVoid>(TC);
        }
    }

    public class TC_prepare : Unitary<(Int64,QArray<Qubit>)>, ICallable
    {
        public TC_prepare(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Qubit>)>, IApplyData
        {
            public In((Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "TC_prepare";
        String ICallable.FullName => "Final_Project.TC_prepare";
        protected ICallable<Int64, QArray<Boolean>> int_to_boolsBE
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (a,TC) = __in__;
#line 34 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            var N = TC.Length;
#line 35 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            var bools = int_to_boolsBE.Apply(a);
#line 36 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 37 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                if (bools[i])
                {
#line 38 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                    MicrosoftQuantumPrimitiveX.Apply(TC[i]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (a,TC) = __in__;
#line hidden
            var N = TC.Length;
#line hidden
            var bools = int_to_boolsBE.Apply(a);
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
            {
#line hidden
                if (bools[i])
                {
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(TC[i]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(a,TC)) = __in__;
#line hidden
            var N = TC.Length;
#line hidden
            var bools = int_to_boolsBE.Apply(a);
#line hidden
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line hidden
                if (bools[i])
                {
#line hidden
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), TC[i]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(a,TC)) = __in__;
#line hidden
            var N = TC.Length;
#line hidden
            var bools = int_to_boolsBE.Apply(a);
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
            {
#line hidden
                if (bools[i])
                {
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), TC[i]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.int_to_boolsBE = this.Factory.Get<ICallable<Int64, QArray<Boolean>>>(typeof(int_to_boolsBE));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 a, QArray<Qubit> TC)
        {
            return __m__.Run<TC_prepare, (Int64,QArray<Qubit>), QVoid>((a, TC));
        }
    }

    public class TC_add_sub : Unitary<(Boolean,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>)>, ICallable
    {
        public TC_add_sub(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Boolean,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits, ((IApplyData)Data.Item5)?.Qubits);
        }

        String ICallable.Name => "TC_add_sub";
        String ICallable.FullName => "Final_Project.TC_add_sub";
        protected IUnitary<(Qubit,Qubit,Qubit,Qubit)> SCG_bit_adder
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Boolean,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (sub,TC_A,TC_B,carry,TC_target) = __in__;
#line 49 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            var N = TC_A.Length;
#line 50 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            var P = TC_B.Length;
#line 51 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            var Q = TC_target.Length;
#line 52 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            if (((N != P) || (N != Q)))
            {
#line 53 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                throw new ExecutionFailException("Eror: improper TC_add_sub usage");
            }

#line 56 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            if (sub)
            {
#line 57 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                MicrosoftQuantumPrimitiveX.Apply(carry);
#line 58 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                {
#line 59 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                    MicrosoftQuantumPrimitiveX.Apply(TC_B[i]);
                }
            }

#line 63 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 64 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                SCG_bit_adder.Apply((TC_A[i], TC_B[i], carry, TC_target[i]));
            }

#line 67 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            if (sub)
            {
#line 68 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                {
#line 69 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                    MicrosoftQuantumPrimitiveX.Apply(TC_B[i]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Boolean,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (sub,TC_A,TC_B,carry,TC_target) = __in__;
#line hidden
            var N = TC_A.Length;
#line hidden
            var P = TC_B.Length;
#line hidden
            var Q = TC_target.Length;
#line hidden
            if (((N != P) || (N != Q)))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper TC_add_sub usage");
            }

#line hidden
            if (sub)
            {
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(TC_B[i]);
                }
            }

#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
            {
#line hidden
                SCG_bit_adder.Adjoint.Apply((TC_A[i], TC_B[i], carry, TC_target[i]));
            }

#line hidden
            if (sub)
            {
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(TC_B[i]);
                }

#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(carry);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Boolean,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(sub,TC_A,TC_B,carry,TC_target)) = __in__;
#line hidden
            var N = TC_A.Length;
#line hidden
            var P = TC_B.Length;
#line hidden
            var Q = TC_target.Length;
#line hidden
            if (((N != P) || (N != Q)))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper TC_add_sub usage");
            }

#line hidden
            if (sub)
            {
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), carry));
#line hidden
                foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), TC_B[i]));
                }
            }

#line hidden
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line hidden
                SCG_bit_adder.Controlled.Apply((__controlQubits__?.Copy(), (TC_A[i], TC_B[i], carry, TC_target[i])));
            }

#line hidden
            if (sub)
            {
#line hidden
                foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), TC_B[i]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Boolean,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(sub,TC_A,TC_B,carry,TC_target)) = __in__;
#line hidden
            var N = TC_A.Length;
#line hidden
            var P = TC_B.Length;
#line hidden
            var Q = TC_target.Length;
#line hidden
            if (((N != P) || (N != Q)))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper TC_add_sub usage");
            }

#line hidden
            if (sub)
            {
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), TC_B[i]));
                }
            }

#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
            {
#line hidden
                SCG_bit_adder.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (TC_A[i], TC_B[i], carry, TC_target[i])));
            }

#line hidden
            if (sub)
            {
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), TC_B[i]));
                }

#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), carry));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.SCG_bit_adder = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit,Qubit)>>(typeof(SCG_bit_adder));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Boolean,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Boolean sub, QArray<Qubit> TC_A, QArray<Qubit> TC_B, Qubit carry, QArray<Qubit> TC_target)
        {
            return __m__.Run<TC_add_sub, (Boolean,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>), QVoid>((sub, TC_A, TC_B, carry, TC_target));
        }
    }

    public class TC_construct_targ : Function<(Qubit,QArray<Qubit>,Int64), QArray<Qubit>>, ICallable
    {
        public TC_construct_targ(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>,Int64)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "TC_construct_targ";
        String ICallable.FullName => "Final_Project.TC_construct_targ";
        public override Func<(Qubit,QArray<Qubit>,Int64), QArray<Qubit>> Body => (__in__) =>
        {
            var (b,GARBAGE,N) = __in__;
#line 79 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            var targ = new QArray<Qubit>()
            {GARBAGE[(N - 2L)]};
#line 80 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            foreach (var i in new Range(1L, (N - 2L)))
#line hidden
            {
#line 81 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                targ = (targ + new QArray<Qubit>()
                {GARBAGE[((N - i) - 2L)]});
            }

#line 83 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            return (targ + new QArray<Qubit>()
            {b});
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Qubit> data) => data;
        public static System.Threading.Tasks.Task<QArray<Qubit>> Run(IOperationFactory __m__, Qubit b, QArray<Qubit> GARBAGE, Int64 N)
        {
            return __m__.Run<TC_construct_targ, (Qubit,QArray<Qubit>,Int64), QArray<Qubit>>((b, GARBAGE, N));
        }
    }

    public class TC_comparator : Unitary<(QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>)>, ICallable
    {
        public TC_comparator(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "TC_comparator";
        String ICallable.FullName => "Final_Project.TC_comparator";
        protected IUnitary<(Boolean,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>)> TC_add_sub
        {
            get;
            set;
        }

        protected ICallable<(Qubit,QArray<Qubit>,Int64), QArray<Qubit>> TC_construct_targ
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (d,dmax,b,GARBAGE) = __in__;
#line 88 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            var N = d.Length;
#line 89 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            var P = dmax.Length;
#line 90 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            var Q = GARBAGE.Length;
#line 91 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            if (((N != P) || (N != Q)))
            {
#line 92 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                throw new ExecutionFailException("Eror: improper TC_comparator usage");
            }

#line 95 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            TC_add_sub.Apply((true, dmax?.Copy(), d?.Copy(), GARBAGE[(N - 1L)], TC_construct_targ.Apply((b, GARBAGE?.Copy(), N))));
#line 96 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false), MicrosoftQuantumPrimitiveX)).Apply((new QArray<Qubit>(dmax[(N - 1L)], d[(N - 1L)]), b));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (d,dmax,b,GARBAGE) = __in__;
#line hidden
            var N = d.Length;
#line hidden
            var P = dmax.Length;
#line hidden
            var Q = GARBAGE.Length;
#line hidden
            if (((N != P) || (N != Q)))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper TC_comparator usage");
            }

#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((new QArray<Qubit>(dmax[(N - 1L)], d[(N - 1L)]), b));
#line hidden
            TC_add_sub.Adjoint.Apply((true, dmax?.Copy(), d?.Copy(), GARBAGE[(N - 1L)], TC_construct_targ.Apply((b, GARBAGE?.Copy(), N))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(d,dmax,b,GARBAGE)) = __in__;
#line hidden
            var N = d.Length;
#line hidden
            var P = dmax.Length;
#line hidden
            var Q = GARBAGE.Length;
#line hidden
            if (((N != P) || (N != Q)))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper TC_comparator usage");
            }

#line hidden
            TC_add_sub.Controlled.Apply((__controlQubits__?.Copy(), (true, dmax?.Copy(), d?.Copy(), GARBAGE[(N - 1L)], TC_construct_targ.Apply((b, GARBAGE?.Copy(), N)))));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false), MicrosoftQuantumPrimitiveX)).Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(dmax[(N - 1L)], d[(N - 1L)]), b)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(d,dmax,b,GARBAGE)) = __in__;
#line hidden
            var N = d.Length;
#line hidden
            var P = dmax.Length;
#line hidden
            var Q = GARBAGE.Length;
#line hidden
            if (((N != P) || (N != Q)))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper TC_comparator usage");
            }

#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false), MicrosoftQuantumPrimitiveX)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(dmax[(N - 1L)], d[(N - 1L)]), b)));
#line hidden
            TC_add_sub.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (true, dmax?.Copy(), d?.Copy(), GARBAGE[(N - 1L)], TC_construct_targ.Apply((b, GARBAGE?.Copy(), N)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.TC_add_sub = this.Factory.Get<IUnitary<(Boolean,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>)>>(typeof(TC_add_sub));
            this.TC_construct_targ = this.Factory.Get<ICallable<(Qubit,QArray<Qubit>,Int64), QArray<Qubit>>>(typeof(TC_construct_targ));
            this.MicrosoftQuantumCanonControlledOnBitString = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnBitString<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> d, QArray<Qubit> dmax, Qubit b, QArray<Qubit> GARBAGE)
        {
            return __m__.Run<TC_comparator, (QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>), QVoid>((d, dmax, b, GARBAGE));
        }
    }

    public class TC_add_int : Unitary<(Int64,QArray<Qubit>,Qubit,QArray<Qubit>)>, ICallable
    {
        public TC_add_int(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Qubit>,Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Int64,QArray<Qubit>,Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "TC_add_int";
        String ICallable.FullName => "Final_Project.TC_add_int";
        protected IUnitary<(Boolean,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>)> TC_add_sub
        {
            get;
            set;
        }

        protected IUnitary<(Int64,QArray<Qubit>)> TC_prepare
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

        protected Release Release
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Qubit>,Qubit,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (INT_A,TC_B,carry,TC_target) = __in__;
#line 105 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            var N = TC_B.Length;
#line 106 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            var P = TC_target.Length;
#line 107 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
            if ((N != P))
            {
#line 108 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                throw new ExecutionFailException("Eror: improper TC_add_int usage");
            }

#line hidden
            {
#line 110 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                var TC_A = Allocate.Apply(N);
#line 111 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                TC_prepare.Apply((INT_A, TC_A?.Copy()));
#line 112 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                TC_add_sub.Apply((false, TC_A?.Copy(), TC_B?.Copy(), carry, TC_target?.Copy()));
#line 113 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Tasks_0_twos_complement.qs"
                TC_prepare.Apply((INT_A, TC_A?.Copy()));
#line hidden
                Release.Apply(TC_A);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,QArray<Qubit>,Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (INT_A,TC_B,carry,TC_target) = __in__;
#line hidden
            var N = TC_B.Length;
#line hidden
            var P = TC_target.Length;
#line hidden
            if ((N != P))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper TC_add_int usage");
            }

#line hidden
            {
#line hidden
                var TC_A = Allocate.Apply(N);
#line hidden
                TC_prepare.Adjoint.Apply((INT_A, TC_A?.Copy()));
#line hidden
                TC_add_sub.Adjoint.Apply((false, TC_A?.Copy(), TC_B?.Copy(), carry, TC_target?.Copy()));
#line hidden
                TC_prepare.Adjoint.Apply((INT_A, TC_A?.Copy()));
#line hidden
                Release.Apply(TC_A);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,QArray<Qubit>,Qubit,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(INT_A,TC_B,carry,TC_target)) = __in__;
#line hidden
            var N = TC_B.Length;
#line hidden
            var P = TC_target.Length;
#line hidden
            if ((N != P))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper TC_add_int usage");
            }

#line hidden
            {
#line hidden
                var TC_A = Allocate.Apply(N);
#line hidden
                TC_prepare.Controlled.Apply((__controlQubits__?.Copy(), (INT_A, TC_A?.Copy())));
#line hidden
                TC_add_sub.Controlled.Apply((__controlQubits__?.Copy(), (false, TC_A?.Copy(), TC_B?.Copy(), carry, TC_target?.Copy())));
#line hidden
                TC_prepare.Controlled.Apply((__controlQubits__?.Copy(), (INT_A, TC_A?.Copy())));
#line hidden
                Release.Apply(TC_A);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,QArray<Qubit>,Qubit,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(INT_A,TC_B,carry,TC_target)) = __in__;
#line hidden
            var N = TC_B.Length;
#line hidden
            var P = TC_target.Length;
#line hidden
            if ((N != P))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper TC_add_int usage");
            }

#line hidden
            {
#line hidden
                var TC_A = Allocate.Apply(N);
#line hidden
                TC_prepare.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (INT_A, TC_A?.Copy())));
#line hidden
                TC_add_sub.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (false, TC_A?.Copy(), TC_B?.Copy(), carry, TC_target?.Copy())));
#line hidden
                TC_prepare.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (INT_A, TC_A?.Copy())));
#line hidden
                Release.Apply(TC_A);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.TC_add_sub = this.Factory.Get<IUnitary<(Boolean,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>)>>(typeof(TC_add_sub));
            this.TC_prepare = this.Factory.Get<IUnitary<(Int64,QArray<Qubit>)>>(typeof(TC_prepare));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn((Int64,QArray<Qubit>,Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 INT_A, QArray<Qubit> TC_B, Qubit carry, QArray<Qubit> TC_target)
        {
            return __m__.Run<TC_add_int, (Int64,QArray<Qubit>,Qubit,QArray<Qubit>), QVoid>((INT_A, TC_B, carry, TC_target));
        }
    }
}