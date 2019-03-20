using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Final_Project
{
    class Driver
    {

        Driver() {
        }

        static void Main(string[] args)
        {
            List<List<Int64>> data = load_csv("data_2d_binom.txt");

            long[] distances = get_distances(data);

            int n = (int) Math.Ceiling(Math.Log(data.Count, 2));
            int m = (int) Math.Ceiling(Math.Log(distances.Max(), 2));

            using (var qsim = new QuantumSimulator())
            {
                long[] indices = new long[data.Count];
                for (int i = 0; i < data.Count; i++) {
                    indices[i] = i;
                }

                // Resource Estimator - finish pls?
                // ResourcesEstimator estimator = new ResourcesEstimator();
                // QArray<long> result = divisive_clust.Run(estimator, 4, 4, new QArray<long>(indices), new QArray<long>(distances)).Result;
                // var estimator_data = estimator.Data;
                // Console.WriteLine($"QubitCliffords: {estimator_data.Rows.Find("QubitClifford")["Sum"]}");
                // Console.WriteLine($"Ts: {estimator_data.Rows.Find("T")["Sum"]}");
                // Console.WriteLine($"CNOTs: {estimator_data.Rows.Find("CNOT")["Sum"]}");

                // DEMO - Divisive Clustering
                // QArray<long> result = divisive_clust.Run(qsim, 4, 5, new QArray<long>(indices), new QArray<long>(distances)).Result;
                // Console.WriteLine("Result:");
                // Console.Write("[");
                // Console.Write(String.Join(", ", result));
                // Console.WriteLine("]");

                // DEMO - Outlier Detection
                QArray<long> result = quantum_detection_outlier.Run(qsim, 4, 5, new QArray<long>(indices), new QArray<long>(distances)).Result;
                Console.WriteLine("Result:");
                Console.Write("[");
                Console.Write(String.Join(", ", result));
                Console.WriteLine("]");

                // DEMO - Adder Compare etc.
                // tests.Run(qsim).Wait();
            }
        }

        /// <summary> Method <c>load_csv</c> 
        /// loads a csv file given path to the file, 
        /// and stores it in class.</summary>
        static List<List<Int64>> load_csv(string file_path) {
            List<List<Int64>> data = new List<List<Int64>>();
            using(var reader = new StreamReader(file_path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    data.Add(Array.ConvertAll(values, Int64.Parse).ToList());
                }
            }
            return data;
        }

        static Int64[] get_distances(List<List<Int64>> arr) {
            long[] result = new long[arr.Count * arr.Count];
            for(int i = 0; i < arr.Count; i++) {
                for(int j = 0; j < arr.Count; j++) {
                    long dist = 0;
                    for(int idx = 0; idx < arr[i].Count; idx++) {
                        dist += (arr[i][idx] - arr[j][idx]) * (arr[i][idx] - arr[j][idx]);
                    }
                    result[16 * i + j] = (long) Math.Sqrt(dist);
                }
            }
            return result;
        }
    }
}
