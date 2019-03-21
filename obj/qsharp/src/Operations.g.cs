#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"quant_find_max\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":27,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"m\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"indices\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"distances\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" quant_find_max finds a pair of 2 indices,\",\" which correspond to 2 data points maximizing the distance between them.\",\"\",\" # Input\",\" ## n\",\" Number of qubits required to represent indices.\",\" ## m\",\" Number of qubits required to represent distance between any 2 points.\",\" ## indices\",\" Indices of datapoints over which to look for pair of points.\",\" ## distances\",\" Distances between two points where distances[c] is\",\" distance between points c0, c1, such that c0 = c / n; c1 = c % n.\",\"\",\" # Example\",\" ```Q#\",\" mutable i = 0..15;\",\" mutable a = new Int[256];\",\" let (c0, c1) = quant_find_max(4, 5, i, a);\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"quant_find_max\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":27,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"divisive_clust\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":106,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"m\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"point_idxs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":53}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"distances\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" divisive_clust clusters given dataset into groups,\",\" and returns array of cluster number a datapoint at given index is part of.\",\"\",\" # Input\",\" ## n\",\" Number of qubits required to represent indices.\",\" ## m\",\" Number of qubits required to represent distance between any 2 points.\",\" ## point_idxs\",\" Indices of datapoints over which to look for pair of points.\",\" ## distances\",\" Distances between two points where distances[c] is\",\" distance between points c0, c1, such that c0 = c / n; c1 = c % n.\",\"\",\" # Output\",\" Returns an array of length of point_idxs,\",\" such that result[i] corresponds to cluster tag of data point with index\",\" point_idxs[i]\",\"\",\" # Example\",\" ```Q#\",\" mutable i = 0..15;\",\" mutable a = new Int[256];\",\" let groups = quant_find_max(4, 5, i, a);\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"divisive_clust\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":106,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"prep_indices\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":188,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"idxs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[\" # Summary\",\" prep_indices prepares encodes superposition of idxs into qubits.\",\"\",\" # Input\",\" ## idxs\",\" Array of indices to encode into qubits.\",\" ## qubits\",\" Qubits into which indices should be encoded.\",\"\",\" # Throws\",\" Fails if indices are to big to encode into qubits.\",\"\",\" # Example\",\" ```Q#\",\" mutable a = new Int[4];\",\" for(i in 0 .. Length(a) - 1) {\",\"     set a[i] = i * i;\",\" }\",\" using (qs = Qubit[4]) {\",\"     prep_indices(a, qs);\",\"     ResetAll(qs);\",\" }\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"prep_indices\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":189,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"prep_indices\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":198,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"prep_indices\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":199,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"prep_indices\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":200,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"get_coeffs\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":222,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"idxs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qb_len\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"ComplexPolar\"}]}]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" get_coeffs encodes array of Ints, into array of ComplexPolars,\",\" which contains amplitudes of given states.\",\"\",\" # Input\",\" ## idxs\",\" Array of indices to encode into qubits.\",\" ## qblen\",\" Length of qubit array for which this ComplexPolar array will be used.\",\" Used to figure out the number of possible states.\",\"\",\" # Example\",\" ```Q#\",\" mutable a = new Int[4];\",\" for(i in 0 .. Length(a) - 1) {\",\"     set a[i] = i;\",\" }\",\" let c = get_coeffs(a, 2);\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"get_coeffs\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":222,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"similarity_crit\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":254,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"point_idxs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"distances\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":55}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":66}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" similarity_crit given indices of data points,\",\" returns whether these datapoints are similar enough\",\" to be considered a cluster.\",\"\",\" # Input\",\" ## n\",\" Number of qubits required to represent indices.\",\" ## point_idxs\",\" Array of indices to encode into qubits.\",\" ## distances\",\" Distances between two points where distances[c] is\",\" distance between points c0, c1, such that c0 = c / n; c1 = c % n.\",\"\",\" # Example\",\" ```Q#\",\" mutable a = new Int[4];\",\" mutable b = new Int[16];\",\" for(i in 0 .. Length(a) - 1) {\",\"     set a[i] = i;\",\" }\",\"\",\" similarity_crit(a, b, 4);\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"similarity_crit\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":254,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"quant_find_smallest\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":290,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"m\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"indices\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"distances\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":75}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" quant_find_smallest returns an index of data point,\",\" which minimizes sum of distances to all other points, and\",\" sum of these distances.\",\"\",\" # Input\",\" ## n\",\" Number of qubits required to represent indices.\",\" ## m\",\" Number of qubits required to represent distance between any 2 points.\",\" ## indices\",\" Indices of datapoints over which to look for pair of points.\",\" ## distances\",\" Distances between two points where distances[c] is\",\" distance between points c0, c1, such that c0 = c / n; c1 = c % n.\",\"\",\" # Example\",\" ```Q#\",\" mutable i = 0..15;\",\" mutable a = new Int[256];\",\" let c = quant_find_smallest(4, 5, i, a);\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"quant_find_smallest\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":290,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"class_find_smallest\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":347,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"indices\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"distances\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":65}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" class_find_smallest returns an index of data point,\",\" which minimizes sum of distances to all other points, and\",\" sum of these distances.\",\"\",\" # Input\",\" ## n\",\" Number of qubits required to represent indices.\",\" ## indices\",\" Indices of datapoints over which to look for pair of points.\",\" ## distances\",\" Distances between two points where distances[c] is\",\" distance between points c0, c1, such that c0 = c / n; c1 = c % n.\",\"\",\" # Example\",\" ```Q#\",\" mutable i = 0..15;\",\" mutable a = new Int[256];\",\" let c = class_find_smallest(4, i, a);\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"class_find_smallest\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":347,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Final_Project\",\"Name\":\"quant_find_k_smallest\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":388,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"m\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"indices\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":57}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":67},\"Item2\":{\"Line\":1,\"Column\":68}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"distances\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":76},\"Item2\":{\"Line\":1,\"Column\":85}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" quant_find_k_smallest returns an indices of k unique data point,\",\" which minimize sum of distances to all other points, and\",\" sum of these distances for each returned datapoint.\",\"\",\" # Input\",\" ## n\",\" Number of qubits required to represent indices.\",\" ## m\",\" Number of qubits required to represent distance between any 2 points.\",\" ## indices\",\" Indices of datapoints over which to look for pair of points.\",\" ## distances\",\" Distances between two points where distances[c] is\",\" distance between points c0, c1, such that c0 = c / n; c1 = c % n.\",\"\",\" # Example\",\" ```Q#\",\" mutable i = 0..15;\",\" mutable a = new Int[256];\",\" let c = quant_find_k_smallest(4, 5, i, 2, a);\",\" ```\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Final_Project\",\"Name\":\"quant_find_k_smallest\"},\"SourceFile\":\"/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs\",\"Position\":{\"Item1\":388,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
#line hidden
namespace Final_Project
{
    public class quant_find_max : Operation<(Int64,Int64,QArray<Int64>,QArray<Int64>), (Int64,Int64)>, ICallable
    {
        public quant_find_max(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,QArray<Int64>,QArray<Int64>)>, IApplyData
        {
            public In((Int64,Int64,QArray<Int64>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
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
        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable,Int64)> GroversSearch
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>)> distance_add
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,Qubit)> distance_cmp
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> efficient_adder
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Int64>,QArray<Qubit>)> prep_indices
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Canon.BigEndian, Int64> MicrosoftQuantumCanonMeasureIntegerBE
        {
            get;
            set;
        }

        protected ICallable Length
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

        public override Func<(Int64,Int64,QArray<Int64>,QArray<Int64>), (Int64,Int64)> Body => (__in__) =>
        {
            var (n,m,indices,distances) = __in__;
#line 29 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var prev_i = 0L;
#line 30 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var prev_j = 0L;
#line 32 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            if ((indices.Length < 2L))
            {
#line 33 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                throw new ExecutionFailException("There need to be at least 2 indices to be found.");
            }

#line 37 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            if ((indices.Length == 2L))
            {
#line 38 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                return (indices[0L], indices[1L]);
            }

#line hidden
            {
#line 42 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                var (i,j) = (Allocate.Apply(n), Allocate.Apply(n));
#line hidden
                {
#line 45 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    var d_max = Allocate.Apply(m);
#line 46 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    while (true)
                    {
#line hidden
                        {
#line 47 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                            var (dist,phase_qubit) = (Allocate.Apply(m), Allocate.Apply());
#line 48 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                            prep_indices.Apply((indices?.Copy(), i?.Copy()));
#line 49 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                            prep_indices.Apply((indices?.Copy(), j?.Copy()));
#line 51 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                            distance_add.Apply((i?.Copy(), j?.Copy(), dist?.Copy(), distances?.Copy()));
#line 52 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                            GroversSearch.Apply((dist?.Copy(), d_max?.Copy(), phase_qubit, distance_cmp, ((indices.Length * indices.Length) / 2L)));
#line 53 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                            var trash = MicrosoftQuantumCanonMeasureIntegerBE.Apply(new Microsoft.Quantum.Canon.BigEndian(dist?.Copy()));
#line 55 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                            prev_i = MicrosoftQuantumCanonMeasureIntegerBE.Apply(new Microsoft.Quantum.Canon.BigEndian(i?.Copy()));
#line 56 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                            prev_j = MicrosoftQuantumCanonMeasureIntegerBE.Apply(new Microsoft.Quantum.Canon.BigEndian(j?.Copy()));
#line 59 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                            ResetAll.Apply(d_max?.Copy());
#line 60 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                            efficient_adder.Apply((d_max?.Copy(), dist?.Copy()));
#line 62 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                            Reset.Apply(phase_qubit);
#line 63 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                            ResetAll.Apply(dist?.Copy());
#line hidden
                            Release.Apply(dist);
#line hidden
                            Release.Apply(phase_qubit);
                        }

                        if ((prev_i != prev_j))
                        {
                            break;
                        }
                        else
                        {
                        }
                    }

#line 69 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    ResetAll.Apply(d_max?.Copy());
#line hidden
                    Release.Apply(d_max);
                }

#line 71 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                ResetAll.Apply(i?.Copy());
#line 72 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                ResetAll.Apply(j?.Copy());
#line hidden
                Release.Apply(i);
#line hidden
                Release.Apply(j);
            }

#line 75 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            Message.Apply(("Length: " + MicrosoftQuantumExtensionsConvertToStringI.Apply(indices.Length)));
#line 76 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            Message.Apply(((("i: " + MicrosoftQuantumExtensionsConvertToStringI.Apply(prev_i)) + " j: ") + MicrosoftQuantumExtensionsConvertToStringI.Apply(prev_j)));
#line 78 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            return (prev_i, prev_j);
        }

        ;
        public override void Init()
        {
            this.GroversSearch = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable,Int64)>>(typeof(GroversSearch));
            this.distance_add = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>)>>(typeof(distance_add));
            this.distance_cmp = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,Qubit)>>(typeof(distance_cmp));
            this.efficient_adder = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(efficient_adder));
            this.prep_indices = this.Factory.Get<IUnitary<(QArray<Int64>,QArray<Qubit>)>>(typeof(prep_indices));
            this.MicrosoftQuantumCanonMeasureIntegerBE = this.Factory.Get<ICallable<Microsoft.Quantum.Canon.BigEndian, Int64>>(typeof(Microsoft.Quantum.Canon.MeasureIntegerBE));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn((Int64,Int64,QArray<Int64>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut((Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Int64 n, Int64 m, QArray<Int64> indices, QArray<Int64> distances)
        {
            return __m__.Run<quant_find_max, (Int64,Int64,QArray<Int64>,QArray<Int64>), (Int64,Int64)>((n, m, indices, distances));
        }
    }

    public class divisive_clust : Operation<(Int64,Int64,QArray<Int64>,QArray<Int64>), QArray<Int64>>, ICallable
    {
        public divisive_clust(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,QArray<Int64>,QArray<Int64>)>, IApplyData
        {
            public In((Int64,Int64,QArray<Int64>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "divisive_clust";
        String ICallable.FullName => "Final_Project.divisive_clust";
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

        protected ICallable<QArray<Int64>, Int64> Sum
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,QArray<Int64>,QArray<Int64>), QArray<Int64>> self
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,QArray<Int64>,QArray<Int64>), (Int64,Int64)> quant_find_max
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,QArray<Int64>,Int64), Boolean> similarity_crit
        {
            get;
            set;
        }

        protected ICallable<QArray<Int64>, Int64> MicrosoftQuantumCanonMax
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,QArray<Int64>,QArray<Int64>), QArray<Int64>> Body => (__in__) =>
        {
            var (n,m,point_idxs,distances) = __in__;
#line 108 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var groupings = new QArray<Int64>(point_idxs.Length);
#line 110 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            if ((similarity_crit.Apply((point_idxs?.Copy(), distances?.Copy(), PowI.Apply((2L, n)))) || (point_idxs.Length <= 1L)))
            {
#line 111 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                return groupings;
            }

#line 115 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var (i,j) = quant_find_max.Apply((n, m, point_idxs?.Copy(), distances?.Copy()));
#line 118 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            foreach (var idx in new Range(0L, (point_idxs.Length - 1L)))
#line hidden
            {
#line 119 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                if ((distances[((SqrtI.Apply(distances.Length) * i) + point_idxs[idx])] > distances[((SqrtI.Apply(distances.Length) * j) + point_idxs[idx])]))
                {
#line 120 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    groupings[idx] = 1L;
                }
                else
                {
#line 122 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    groupings[idx] = 0L;
                }
            }

#line 127 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var points_j = new QArray<Int64>(Sum.Apply(groupings));
#line 128 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var points_i = new QArray<Int64>((point_idxs.Length - points_j.Length));
#line 129 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var idx_i = 0L;
#line 130 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var idx_j = 0L;
#line 131 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            foreach (var idx in new Range(0L, (point_idxs.Length - 1L)))
#line hidden
            {
#line 132 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                if ((groupings[idx] == 0L))
                {
#line 133 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    points_i[idx_i] = point_idxs[idx];
#line 134 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    idx_i = (idx_i + 1L);
                }
                else
                {
#line 136 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    points_j[idx_j] = point_idxs[idx];
#line 137 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    idx_j = (idx_j + 1L);
                }
            }

#line 142 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var grouping_i = self.Apply<QArray<Int64>>((n, m, points_i?.Copy(), distances?.Copy()));
#line 143 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var grouping_j = self.Apply<QArray<Int64>>((n, m, points_j?.Copy(), distances?.Copy()));
#line 146 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var max_i = MicrosoftQuantumCanonMax.Apply(grouping_i);
#line 147 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            foreach (var idx in new Range(0L, (grouping_j.Length - 1L)))
#line hidden
            {
#line 148 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                grouping_j[idx] = ((grouping_j[idx] + max_i) + 1L);
            }

#line 152 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            idx_i = 0L;
#line 153 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            idx_j = 0L;
#line 154 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            foreach (var idx in new Range(0L, (groupings.Length - 1L)))
#line hidden
            {
#line 155 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                if ((groupings[idx] == 0L))
                {
#line 156 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    groupings[idx] = grouping_i[idx_i];
#line 157 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    idx_i = (idx_i + 1L);
                }
                else
                {
#line 159 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    groupings[idx] = grouping_j[idx_j];
#line 160 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    idx_j = (idx_j + 1L);
                }
            }

#line 163 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            return groupings;
        }

        ;
        public override void Init()
        {
            this.PowI = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(PowI));
            this.SqrtI = this.Factory.Get<ICallable<Int64, Int64>>(typeof(SqrtI));
            this.Sum = this.Factory.Get<ICallable<QArray<Int64>, Int64>>(typeof(Sum));
            this.self = this;
            this.quant_find_max = this.Factory.Get<ICallable<(Int64,Int64,QArray<Int64>,QArray<Int64>), (Int64,Int64)>>(typeof(quant_find_max));
            this.similarity_crit = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Int64>,Int64), Boolean>>(typeof(similarity_crit));
            this.MicrosoftQuantumCanonMax = this.Factory.Get<ICallable<QArray<Int64>, Int64>>(typeof(Microsoft.Quantum.Canon.Max));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((Int64,Int64,QArray<Int64>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, Int64 n, Int64 m, QArray<Int64> point_idxs, QArray<Int64> distances)
        {
            return __m__.Run<divisive_clust, (Int64,Int64,QArray<Int64>,QArray<Int64>), QArray<Int64>>((n, m, point_idxs, distances));
        }
    }

    public class prep_indices : Unitary<(QArray<Int64>,QArray<Qubit>)>, ICallable
    {
        public prep_indices(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Int64>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "prep_indices";
        String ICallable.FullName => "Final_Project.prep_indices";
        protected ICallable<(Int64,Int64), Int64> PowI
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,Int64), QArray<Microsoft.Quantum.Canon.ComplexPolar>> get_coeffs
        {
            get;
            set;
        }

        protected ICallable<QArray<Int64>, Int64> MicrosoftQuantumCanonMax
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Microsoft.Quantum.Canon.ComplexPolar>,Microsoft.Quantum.Canon.BigEndian)> MicrosoftQuantumCanonPrepareArbitraryState
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (idxs,qubits) = __in__;
#line 191 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            if ((MicrosoftQuantumCanonMax.Apply(idxs) >= PowI.Apply((2L, qubits.Length))))
            {
#line 192 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                throw new ExecutionFailException("Not enough qubits to encode given indices");
            }

#line 195 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var coeffs = get_coeffs.Apply((idxs?.Copy(), qubits.Length));
#line 197 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            MicrosoftQuantumCanonPrepareArbitraryState.Apply((coeffs?.Copy(), new Microsoft.Quantum.Canon.BigEndian(qubits?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Int64>,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (idxs,qubits) = __in__;
#line hidden
            if ((MicrosoftQuantumCanonMax.Apply(idxs) >= PowI.Apply((2L, qubits.Length))))
            {
#line hidden
                throw new ExecutionFailException("Not enough qubits to encode given indices");
            }

#line hidden
            var coeffs = get_coeffs.Apply((idxs?.Copy(), qubits.Length));
#line hidden
            MicrosoftQuantumCanonPrepareArbitraryState.Adjoint.Apply((coeffs?.Copy(), new Microsoft.Quantum.Canon.BigEndian(qubits?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(idxs,qubits)) = __in__;
#line hidden
            if ((MicrosoftQuantumCanonMax.Apply(idxs) >= PowI.Apply((2L, qubits.Length))))
            {
#line hidden
                throw new ExecutionFailException("Not enough qubits to encode given indices");
            }

#line hidden
            var coeffs = get_coeffs.Apply((idxs?.Copy(), qubits.Length));
#line hidden
            MicrosoftQuantumCanonPrepareArbitraryState.Controlled.Apply((__controlQubits__?.Copy(), (coeffs?.Copy(), new Microsoft.Quantum.Canon.BigEndian(qubits?.Copy()))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(idxs,qubits)) = __in__;
#line hidden
            if ((MicrosoftQuantumCanonMax.Apply(idxs) >= PowI.Apply((2L, qubits.Length))))
            {
#line hidden
                throw new ExecutionFailException("Not enough qubits to encode given indices");
            }

#line hidden
            var coeffs = get_coeffs.Apply((idxs?.Copy(), qubits.Length));
#line hidden
            MicrosoftQuantumCanonPrepareArbitraryState.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (coeffs?.Copy(), new Microsoft.Quantum.Canon.BigEndian(qubits?.Copy()))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.PowI = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(PowI));
            this.get_coeffs = this.Factory.Get<ICallable<(QArray<Int64>,Int64), QArray<Microsoft.Quantum.Canon.ComplexPolar>>>(typeof(get_coeffs));
            this.MicrosoftQuantumCanonMax = this.Factory.Get<ICallable<QArray<Int64>, Int64>>(typeof(Microsoft.Quantum.Canon.Max));
            this.MicrosoftQuantumCanonPrepareArbitraryState = this.Factory.Get<IUnitary<(QArray<Microsoft.Quantum.Canon.ComplexPolar>,Microsoft.Quantum.Canon.BigEndian)>>(typeof(Microsoft.Quantum.Canon.PrepareArbitraryState));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((QArray<Int64>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Int64> idxs, QArray<Qubit> qubits)
        {
            return __m__.Run<prep_indices, (QArray<Int64>,QArray<Qubit>), QVoid>((idxs, qubits));
        }
    }

    public class get_coeffs : Function<(QArray<Int64>,Int64), QArray<Microsoft.Quantum.Canon.ComplexPolar>>, ICallable
    {
        public get_coeffs(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64)>, IApplyData
        {
            public In((QArray<Int64>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "get_coeffs";
        String ICallable.FullName => "Final_Project.get_coeffs";
        protected ICallable<(Int64,Int64), Int64> PowI
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Int64), QArray<Microsoft.Quantum.Canon.ComplexPolar>> Body => (__in__) =>
        {
            var (idxs,qb_len) = __in__;
#line 224 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var coeffs = new QArray<Microsoft.Quantum.Canon.ComplexPolar>(PowI.Apply((2L, qb_len)));
#line 225 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            foreach (var i in new Range(0L, (idxs.Length - 1L)))
#line hidden
            {
#line 226 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                coeffs[idxs[i]] = new Microsoft.Quantum.Canon.ComplexPolar(((1D / MicrosoftQuantumExtensionsConvertToDouble.Apply(idxs.Length)), 0D));
            }

#line 228 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            return coeffs;
        }

        ;
        public override void Init()
        {
            this.PowI = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(PowI));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Microsoft.Quantum.Canon.ComplexPolar> data) => data;
        public static System.Threading.Tasks.Task<QArray<Microsoft.Quantum.Canon.ComplexPolar>> Run(IOperationFactory __m__, QArray<Int64> idxs, Int64 qb_len)
        {
            return __m__.Run<get_coeffs, (QArray<Int64>,Int64), QArray<Microsoft.Quantum.Canon.ComplexPolar>>((idxs, qb_len));
        }
    }

    public class similarity_crit : Function<(QArray<Int64>,QArray<Int64>,Int64), Boolean>, ICallable
    {
        public similarity_crit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,QArray<Int64>,Int64)>, IApplyData
        {
            public In((QArray<Int64>,QArray<Int64>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "similarity_crit";
        String ICallable.FullName => "Final_Project.similarity_crit";
        protected ICallable<QArray<Int64>, Int64> MicrosoftQuantumCanonMax
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,QArray<Int64>,Int64), Boolean> Body => (__in__) =>
        {
            var (point_idxs,distances,n) = __in__;
#line 257 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var idx_dist = 0L;
#line 258 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            foreach (var i in new Range(0L, (point_idxs.Length - 2L)))
#line hidden
            {
#line 259 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                foreach (var j in new Range(i, (point_idxs.Length - 1L)))
#line hidden
                {
#line 260 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    if ((distances[((n * i) + j)] > idx_dist))
                    {
#line 261 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                        idx_dist = distances[((n * i) + j)];
                    }
                }
            }

#line 266 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            return (((MicrosoftQuantumCanonMax.Apply(distances) * 2L) / 3L) > idx_dist);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonMax = this.Factory.Get<ICallable<QArray<Int64>, Int64>>(typeof(Microsoft.Quantum.Canon.Max));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((QArray<Int64>,QArray<Int64>,Int64) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, QArray<Int64> point_idxs, QArray<Int64> distances, Int64 n)
        {
            return __m__.Run<similarity_crit, (QArray<Int64>,QArray<Int64>,Int64), Boolean>((point_idxs, distances, n));
        }
    }

    public class quant_find_smallest : Operation<(Int64,Int64,QArray<Int64>,QArray<Int64>), (Int64,Int64)>, ICallable
    {
        public quant_find_smallest(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,QArray<Int64>,QArray<Int64>)>, IApplyData
        {
            public In((Int64,Int64,QArray<Int64>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "quant_find_smallest";
        String ICallable.FullName => "Final_Project.quant_find_smallest";
        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable,Int64)> GroversSearch
        {
            get;
            set;
        }

        protected IUnitary<(Int64,QArray<Qubit>)> IntegerIncrementBE
        {
            get;
            set;
        }

        protected ICallable<(Int64,QArray<Int64>,QArray<Int64>), (Int64,Int64)> class_find_smallest
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>)> distance_add
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,Qubit)> distance_cmp
        {
            get;
            set;
        }

        protected IUnitary<QArray<Qubit>> negateBE
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Int64>,QArray<Qubit>)> prep_indices
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Canon.BigEndian, Int64> MicrosoftQuantumCanonMeasureIntegerBE
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

        public override Func<(Int64,Int64,QArray<Int64>,QArray<Int64>), (Int64,Int64)> Body => (__in__) =>
        {
            var (n,m,indices,distances) = __in__;
#line 292 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var result_dist = 0L;
#line 293 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var result_idx = 0L;
#line hidden
            {
#line 294 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                var i = Allocate.Apply(n);
#line 295 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                prep_indices.Apply((indices?.Copy(), i?.Copy()));
#line hidden
                {
#line 296 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    var (dist,d_min,phase_qubit) = (Allocate.Apply(m), Allocate.Apply(m), Allocate.Apply());
#line 297 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    foreach (var idx in new Range(0L, (indices.Length - 1L)))
#line hidden
                    {
#line hidden
                        {
#line 298 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                            var j = Allocate.Apply(n);
#line 299 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                            IntegerIncrementBE.Apply((indices[idx], j?.Copy()));
#line 300 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                            distance_add.Apply((i?.Copy(), j?.Copy(), dist?.Copy(), distances?.Copy()));
#line 301 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                            IntegerIncrementBE.Adjoint.Apply((indices[idx], j?.Copy()));
#line hidden
                            Release.Apply(j);
                        }
                    }

#line 305 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    negateBE.Apply(dist?.Copy());
#line 308 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    var (_,x) = class_find_smallest.Apply((n, indices?.Copy(), distances?.Copy()));
#line 309 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    IntegerIncrementBE.Apply(((x - 1L), d_min?.Copy()));
#line 311 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    GroversSearch.Apply((dist?.Copy(), d_min?.Copy(), phase_qubit, distance_cmp, indices.Length));
#line 313 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    negateBE.Apply(dist?.Copy());
#line 314 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    result_dist = MicrosoftQuantumCanonMeasureIntegerBE.Apply(new Microsoft.Quantum.Canon.BigEndian(dist?.Copy()));
#line 315 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    result_idx = MicrosoftQuantumCanonMeasureIntegerBE.Apply(new Microsoft.Quantum.Canon.BigEndian(i?.Copy()));
#line 317 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    ResetAll.Apply(dist?.Copy());
#line 318 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    ResetAll.Apply(d_min?.Copy());
#line 319 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    Reset.Apply(phase_qubit);
#line hidden
                    Release.Apply(dist);
#line hidden
                    Release.Apply(d_min);
#line hidden
                    Release.Apply(phase_qubit);
                }

#line 322 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                ResetAll.Apply(i?.Copy());
#line hidden
                Release.Apply(i);
            }

#line 325 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            return (result_idx, result_dist);
        }

        ;
        public override void Init()
        {
            this.GroversSearch = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit,IAdjointable,Int64)>>(typeof(GroversSearch));
            this.IntegerIncrementBE = this.Factory.Get<IUnitary<(Int64,QArray<Qubit>)>>(typeof(IntegerIncrementBE));
            this.class_find_smallest = this.Factory.Get<ICallable<(Int64,QArray<Int64>,QArray<Int64>), (Int64,Int64)>>(typeof(class_find_smallest));
            this.distance_add = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,QArray<Int64>)>>(typeof(distance_add));
            this.distance_cmp = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,Qubit)>>(typeof(distance_cmp));
            this.negateBE = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(negateBE));
            this.prep_indices = this.Factory.Get<IUnitary<(QArray<Int64>,QArray<Qubit>)>>(typeof(prep_indices));
            this.MicrosoftQuantumCanonMeasureIntegerBE = this.Factory.Get<ICallable<Microsoft.Quantum.Canon.BigEndian, Int64>>(typeof(Microsoft.Quantum.Canon.MeasureIntegerBE));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn((Int64,Int64,QArray<Int64>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut((Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Int64 n, Int64 m, QArray<Int64> indices, QArray<Int64> distances)
        {
            return __m__.Run<quant_find_smallest, (Int64,Int64,QArray<Int64>,QArray<Int64>), (Int64,Int64)>((n, m, indices, distances));
        }
    }

    public class class_find_smallest : Function<(Int64,QArray<Int64>,QArray<Int64>), (Int64,Int64)>, ICallable
    {
        public class_find_smallest(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Int64>,QArray<Int64>)>, IApplyData
        {
            public In((Int64,QArray<Int64>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "class_find_smallest";
        String ICallable.FullName => "Final_Project.class_find_smallest";
        protected ICallable<QArray<Int64>, Int64> MicrosoftQuantumCanonMax
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Int64>,QArray<Int64>), (Int64,Int64)> Body => (__in__) =>
        {
            var (n,indices,distances) = __in__;
#line 349 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var min_i = 0L;
#line 350 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var min_dist = (indices.Length * MicrosoftQuantumCanonMax.Apply(distances));
#line 351 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            foreach (var i in new Range(0L, (indices.Length - 1L)))
#line hidden
            {
#line 352 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                var dist_i = 0L;
#line 354 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                foreach (var j in new Range(0L, (indices.Length - 1L)))
#line hidden
                {
#line 355 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    dist_i = (dist_i - distances[((indices[i] * n) + indices[j])]);
                }

#line 358 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                if ((dist_i < min_dist))
                {
#line 359 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    min_dist = dist_i;
#line 360 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    min_i = indices[i];
                }
            }

#line 364 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            return (min_i, min_dist);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonMax = this.Factory.Get<ICallable<QArray<Int64>, Int64>>(typeof(Microsoft.Quantum.Canon.Max));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((Int64,QArray<Int64>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut((Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Int64 n, QArray<Int64> indices, QArray<Int64> distances)
        {
            return __m__.Run<class_find_smallest, (Int64,QArray<Int64>,QArray<Int64>), (Int64,Int64)>((n, indices, distances));
        }
    }

    public class quant_find_k_smallest : Operation<(Int64,Int64,QArray<Int64>,Int64,QArray<Int64>), QArray<QArray<Int64>>>, ICallable
    {
        public quant_find_k_smallest(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,QArray<Int64>,Int64,QArray<Int64>)>, IApplyData
        {
            public In((Int64,Int64,QArray<Int64>,Int64,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "quant_find_k_smallest";
        String ICallable.FullName => "Final_Project.quant_find_k_smallest";
        protected ICallable<(QArray<Int64>,Int64), QArray<Int64>> Remove
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,QArray<Int64>,QArray<Int64>), (Int64,Int64)> quant_find_smallest
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
#line 390 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            if ((k > indices.Length))
            {
#line 391 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                throw new ExecutionFailException("Not enough indices given to find k values.");
            }

#line 394 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var result = new QArray<QArray<Int64>>(k);
#line 395 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            if ((k == indices.Length))
            {
#line 396 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                foreach (var i in new Range(0L, (k - 1L)))
#line hidden
                {
#line 397 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    result[i] = new QArray<Int64>(2L);
#line 398 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    result[i][0L] = indices[i];
#line 399 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    var result_i = 0L;
#line 400 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    foreach (var j in new Range(0L, (indices.Length - 1L)))
#line hidden
                    {
#line 401 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                        result_i = (result_i + distances[((n * indices[i]) + indices[j])]);
                    }

#line 403 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    result[i][1L] = result_i;
                }

#line 405 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                return result;
            }

#line 408 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            var curr_indices = indices?.Copy();
#line 409 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            foreach (var i in new Range(0L, (k - 1L)))
#line hidden
            {
#line 410 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                result[i] = new QArray<Int64>(2L);
#line 411 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                (result[i][0L], result[i][1L]) = quant_find_smallest.Apply((n, m, curr_indices?.Copy(), distances?.Copy()));
#line 412 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                curr_indices = Remove.Apply((curr_indices?.Copy(), result[i][0L]));
#line 415 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                foreach (var j in new Range(0L, (i - 1L)))
#line hidden
                {
#line 416 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
                    result[i][1L] = (result[i][1L] + distances[((indices[i] * n) + indices[j])]);
                }
            }

#line 419 "/Users/john/Desktop/CSE490Q/quantum-cluster-kata/Operations.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Remove = this.Factory.Get<ICallable<(QArray<Int64>,Int64), QArray<Int64>>>(typeof(Remove));
            this.quant_find_smallest = this.Factory.Get<ICallable<(Int64,Int64,QArray<Int64>,QArray<Int64>), (Int64,Int64)>>(typeof(quant_find_smallest));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((Int64,Int64,QArray<Int64>,Int64,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QArray<QArray<Int64>> data) => data;
        public static System.Threading.Tasks.Task<QArray<QArray<Int64>>> Run(IOperationFactory __m__, Int64 n, Int64 m, QArray<Int64> indices, Int64 k, QArray<Int64> distances)
        {
            return __m__.Run<quant_find_k_smallest, (Int64,Int64,QArray<Int64>,Int64,QArray<Int64>), QArray<QArray<Int64>>>((n, m, indices, k, distances));
        }
    }
}