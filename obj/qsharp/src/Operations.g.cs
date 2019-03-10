#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"quant_find_max\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"dist_oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Controlled\"},{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Controlled\"},{\"Case\":\"Adjoint\"}]]}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"quant_find_max\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"GroversHelper\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":19,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"i\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"j\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"GroversHelper\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":21,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"GroversHelper\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":25,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"OracleConverterImpl_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markingOracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":55}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"i\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":105},\"Item2\":{\"Line\":1,\"Column\":106}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"j\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":118},\"Item2\":{\"Line\":1,\"Column\":119}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"OracleConverterImpl_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":29,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"OracleConverterImpl_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":45,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"OracleConverter_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markingOracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"ReturnType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"OracleConverter_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"GroversSearch_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":53,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"i\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"j\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":66}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"iterations\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":116},\"Item2\":{\"Line\":1,\"Column\":126}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"GroversSearch_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":55,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"GroversSearch_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":65,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"GroverIteration_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":68,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"i\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"j\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":64},\"Item2\":{\"Line\":1,\"Column\":70}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"GroverIteration_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":70,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"GroverIteration_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":81,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"HadamardTransform_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":84,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":48}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"HadamardTransform_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":86,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"HadamardTransform_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":90,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"ConditionalPhaseFlip_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":93,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"i\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"j\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"ConditionalPhaseFlip_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":94,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"ConditionalPhaseFlip_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":105,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"Oracle_ArbitraryPattern_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":108,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":44}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"i\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"j\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":60}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":71},\"Item2\":{\"Line\":1,\"Column\":77}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"pattern_i\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":87},\"Item2\":{\"Line\":1,\"Column\":96}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"pattern_j\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":107},\"Item2\":{\"Line\":1,\"Column\":116}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"Oracle_ArbitraryPattern_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":110,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"Oracle_ArbitraryPattern_Reference\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":114,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace Final_Project
{
    public class quant_find_max : Operation<(Int64,IUnitary), (Int64,Int64)>, ICallable
    {
        public quant_find_max(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IUnitary)>, IApplyData
        {
            public In((Int64,IUnitary) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        public class Out : QTuple<(Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "quant_find_max";
        String ICallable.FullName => "Final_Project.quant_find_max";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        public override Func<(Int64,IUnitary), (Int64,Int64)> Body => (__in__) =>
        {
            var (n,dist_oracle) = __in__;
#line 7 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var d_max = 0D;
#line hidden
            {
#line 8 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                var d_max_qubit = Allocate.Apply();
#line hidden
                {
#line 9 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    var (i,j,dist_qubit,phase_qubit) = (Allocate.Apply(n), Allocate.Apply(n), Allocate.Apply(), Allocate.Apply());
#line 10 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    dist_oracle.Apply((i?.Copy(), j?.Copy(), dist_qubit));
#line 11 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    MicrosoftQuantumPrimitiveH.Apply(phase_qubit);
#line 13 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    MicrosoftQuantumPrimitiveH.Apply(phase_qubit);
#line 14 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    dist_oracle.Adjoint.Apply((i?.Copy(), j?.Copy(), dist_qubit));
#line hidden
                    Release.Apply(i);
#line hidden
                    Release.Apply(j);
#line hidden
                    Release.Apply(dist_qubit);
#line hidden
                    Release.Apply(phase_qubit);
                }

#line hidden
                Release.Apply(d_max_qubit);
            }

#line 17 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            return (0L, 0L);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn((Int64,IUnitary) data) => new In(data);
        public override IApplyData __dataOut((Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Int64 n, IUnitary dist_oracle)
        {
            return __m__.Run<quant_find_max, (Int64,IUnitary), (Int64,Int64)>((n, dist_oracle));
        }
    }

    public class GroversHelper : Adjointable<(QArray<Qubit>,QArray<Qubit>,IAdjointable)>, ICallable
    {
        public GroversHelper(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,IAdjointable)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "GroversHelper";
        String ICallable.FullName => "Final_Project.GroversHelper";
        public override Func<(QArray<Qubit>,QArray<Qubit>,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (i,j,oracle) = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,IAdjointable), QVoid> AdjointBody => (__in__) =>
        {
            var (i,j,oracle) = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> i, QArray<Qubit> j, IAdjointable oracle)
        {
            return __m__.Run<GroversHelper, (QArray<Qubit>,QArray<Qubit>,IAdjointable), QVoid>((i, j, oracle));
        }
    }

    public class OracleConverterImpl_Reference : Adjointable<(IAdjointable,QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public OracleConverterImpl_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((IAdjointable,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "OracleConverterImpl_Reference";
        String ICallable.FullName => "Final_Project.OracleConverterImpl_Reference";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(IAdjointable,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markingOracle,i,j) = __in__;
#line hidden
            {
#line 31 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                var target = Allocate.Apply();
#line 33 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                MicrosoftQuantumPrimitiveX.Apply(target);
#line 34 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                MicrosoftQuantumPrimitiveH.Apply(target);
#line 38 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                markingOracle.Apply((i?.Copy(), j?.Copy(), target));
#line 41 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                MicrosoftQuantumPrimitiveH.Apply(target);
#line 42 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                MicrosoftQuantumPrimitiveX.Apply(target);
#line hidden
                Release.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (markingOracle,i,j) = __in__;
#line hidden
            {
#line hidden
                var target = Allocate.Apply();
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(target);
#line hidden
                MicrosoftQuantumPrimitiveH.Adjoint.Apply(target);
#line hidden
                markingOracle.Adjoint.Apply((i?.Copy(), j?.Copy(), target));
#line hidden
                MicrosoftQuantumPrimitiveH.Adjoint.Apply(target);
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(target);
#line hidden
                Release.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((IAdjointable,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable markingOracle, QArray<Qubit> i, QArray<Qubit> j)
        {
            return __m__.Run<OracleConverterImpl_Reference, (IAdjointable,QArray<Qubit>,QArray<Qubit>), QVoid>((markingOracle, i, j));
        }
    }

    public class OracleConverter_Reference : Function<IAdjointable, IAdjointable>, ICallable
    {
        public OracleConverter_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "OracleConverter_Reference";
        String ICallable.FullName => "Final_Project.OracleConverter_Reference";
        protected IAdjointable<(IAdjointable,QArray<Qubit>,QArray<Qubit>)> OracleConverterImpl_Reference
        {
            get;
            set;
        }

        public override Func<IAdjointable, IAdjointable> Body => (__in__) =>
        {
            var markingOracle = __in__;
#line 51 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            return OracleConverterImpl_Reference.Partial(new Func<(QArray<Qubit>,QArray<Qubit>), (IAdjointable,QArray<Qubit>,QArray<Qubit>)>((__arg1__) => (markingOracle, __arg1__.Item1, __arg1__.Item2)));
        }

        ;
        public override void Init()
        {
            this.OracleConverterImpl_Reference = this.Factory.Get<IAdjointable<(IAdjointable,QArray<Qubit>,QArray<Qubit>)>>(typeof(OracleConverterImpl_Reference));
        }

        public override IApplyData __dataIn(IAdjointable data) => new QTuple<IAdjointable>(data);
        public override IApplyData __dataOut(IAdjointable data) => new QTuple<IAdjointable>(data);
        public static System.Threading.Tasks.Task<IAdjointable> Run(IOperationFactory __m__, IAdjointable markingOracle)
        {
            return __m__.Run<OracleConverter_Reference, IAdjointable, IAdjointable>(markingOracle);
        }
    }

    public class GroversSearch_Reference : Adjointable<(QArray<Qubit>,QArray<Qubit>,IAdjointable,Int64)>, ICallable
    {
        public GroversSearch_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,IAdjointable,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,IAdjointable,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "GroversSearch_Reference";
        String ICallable.FullName => "Final_Project.GroversSearch_Reference";
        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>,IAdjointable)> GroverIteration_Reference
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> HadamardTransform_Reference
        {
            get;
            set;
        }

        protected ICallable<IAdjointable, IAdjointable> OracleConverter_Reference
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,IAdjointable,Int64), QVoid> Body => (__in__) =>
        {
            var (i,j,oracle,iterations) = __in__;
#line 57 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var phaseOracle = OracleConverter_Reference.Apply(oracle);
#line 58 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            HadamardTransform_Reference.Apply(i?.Copy());
#line 59 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            HadamardTransform_Reference.Apply(j?.Copy());
#line 61 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            foreach (var __arg1__ in new Range(1L, iterations))
#line hidden
            {
#line 62 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                GroverIteration_Reference.Apply((i?.Copy(), j?.Copy(), phaseOracle));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,IAdjointable,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (i,j,oracle,iterations) = __in__;
#line hidden
            var phaseOracle = OracleConverter_Reference.Apply(oracle);
#line hidden
            foreach (var __arg1__ in RangeReverse.Apply(new Range(1L, iterations)))
#line hidden
            {
#line hidden
                GroverIteration_Reference.Adjoint.Apply((i?.Copy(), j?.Copy(), phaseOracle));
            }

#line hidden
            HadamardTransform_Reference.Adjoint.Apply(j?.Copy());
#line hidden
            HadamardTransform_Reference.Adjoint.Apply(i?.Copy());
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.GroverIteration_Reference = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>,IAdjointable)>>(typeof(GroverIteration_Reference));
            this.HadamardTransform_Reference = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(HadamardTransform_Reference));
            this.OracleConverter_Reference = this.Factory.Get<ICallable<IAdjointable, IAdjointable>>(typeof(OracleConverter_Reference));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,IAdjointable,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> i, QArray<Qubit> j, IAdjointable oracle, Int64 iterations)
        {
            return __m__.Run<GroversSearch_Reference, (QArray<Qubit>,QArray<Qubit>,IAdjointable,Int64), QVoid>((i, j, oracle, iterations));
        }
    }

    public class GroverIteration_Reference : Adjointable<(QArray<Qubit>,QArray<Qubit>,IAdjointable)>, ICallable
    {
        public GroverIteration_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,IAdjointable)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "GroverIteration_Reference";
        String ICallable.FullName => "Final_Project.GroverIteration_Reference";
        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>)> ConditionalPhaseFlip_Reference
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> HadamardTransform_Reference
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (i,j,oracle) = __in__;
#line 72 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            oracle.Apply((i?.Copy(), j?.Copy()));
#line 73 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            HadamardTransform_Reference.Apply(i?.Copy());
#line 74 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            HadamardTransform_Reference.Apply(j?.Copy());
#line 76 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            ConditionalPhaseFlip_Reference.Apply((i?.Copy(), j?.Copy()));
#line 78 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            HadamardTransform_Reference.Apply(i?.Copy());
#line 79 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            HadamardTransform_Reference.Apply(j?.Copy());
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,IAdjointable), QVoid> AdjointBody => (__in__) =>
        {
            var (i,j,oracle) = __in__;
#line hidden
            HadamardTransform_Reference.Adjoint.Apply(j?.Copy());
#line hidden
            HadamardTransform_Reference.Adjoint.Apply(i?.Copy());
#line hidden
            ConditionalPhaseFlip_Reference.Adjoint.Apply((i?.Copy(), j?.Copy()));
#line hidden
            HadamardTransform_Reference.Adjoint.Apply(j?.Copy());
#line hidden
            HadamardTransform_Reference.Adjoint.Apply(i?.Copy());
#line hidden
            oracle.Adjoint.Apply((i?.Copy(), j?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ConditionalPhaseFlip_Reference = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>)>>(typeof(ConditionalPhaseFlip_Reference));
            this.HadamardTransform_Reference = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(HadamardTransform_Reference));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> i, QArray<Qubit> j, IAdjointable oracle)
        {
            return __m__.Run<GroverIteration_Reference, (QArray<Qubit>,QArray<Qubit>,IAdjointable), QVoid>((i, j, oracle));
        }
    }

    public class HadamardTransform_Reference : Adjointable<QArray<Qubit>>, ICallable
    {
        public HadamardTransform_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "HadamardTransform_Reference";
        String ICallable.FullName => "Final_Project.HadamardTransform_Reference";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var register = __in__;
#line 88 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveH, register?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var register = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveH, register?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> register)
        {
            return __m__.Run<HadamardTransform_Reference, QArray<Qubit>, QVoid>(register);
        }
    }

    public class ConditionalPhaseFlip_Reference : Adjointable<(QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public ConditionalPhaseFlip_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ConditionalPhaseFlip_Reference";
        String ICallable.FullName => "Final_Project.ConditionalPhaseFlip_Reference";
        protected ICallable<IAdjointable, IAdjointable> OracleConverter_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Boolean>,QArray<Boolean>)> Oracle_ArbitraryPattern_Reference
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (i,j) = __in__;
#line 97 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var pattern_i = new QArray<Boolean>(i.Length);
#line 98 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var pattern_j = new QArray<Boolean>(j.Length);
#line 100 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var allZerosOracle = Oracle_ArbitraryPattern_Reference.Partial(new Func<(QArray<Qubit>,QArray<Qubit>,Qubit), (QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Boolean>,QArray<Boolean>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, __arg1__.Item3, pattern_i?.Copy(), pattern_j?.Copy())));
#line 103 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var flipOracle = OracleConverter_Reference.Apply(allZerosOracle);
#line 104 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            flipOracle.Apply((i?.Copy(), j?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.OracleConverter_Reference = this.Factory.Get<ICallable<IAdjointable, IAdjointable>>(typeof(OracleConverter_Reference));
            this.Oracle_ArbitraryPattern_Reference = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Boolean>,QArray<Boolean>)>>(typeof(Oracle_ArbitraryPattern_Reference));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> i, QArray<Qubit> j)
        {
            return __m__.Run<ConditionalPhaseFlip_Reference, (QArray<Qubit>,QArray<Qubit>), QVoid>((i, j));
        }
    }

    public class Oracle_ArbitraryPattern_Reference : Adjointable<(QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Boolean>,QArray<Boolean>)>, ICallable
    {
        public Oracle_ArbitraryPattern_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Boolean>,QArray<Boolean>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Boolean>,QArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "Oracle_ArbitraryPattern_Reference";
        String ICallable.FullName => "Final_Project.Oracle_ArbitraryPattern_Reference";
        protected ICallable MicrosoftQuantumCanonControlledOnBitString
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Boolean>,QArray<Boolean>), QVoid> Body => (__in__) =>
        {
            var (i,j,target,pattern_i,pattern_j) = __in__;
#line 112 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>(((pattern_i + pattern_j), MicrosoftQuantumPrimitiveX)).Apply(((i + j), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Boolean>,QArray<Boolean>), QVoid> AdjointBody => (__in__) =>
        {
            var (i,j,target,pattern_i,pattern_j) = __in__;
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>(((pattern_i + pattern_j), MicrosoftQuantumPrimitiveX)).Adjoint.Apply(((i + j), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonControlledOnBitString = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnBitString<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Boolean>,QArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> i, QArray<Qubit> j, Qubit target, QArray<Boolean> pattern_i, QArray<Boolean> pattern_j)
        {
            return __m__.Run<Oracle_ArbitraryPattern_Reference, (QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Boolean>,QArray<Boolean>), QVoid>((i, j, target, pattern_i, pattern_j));
        }
    }
}