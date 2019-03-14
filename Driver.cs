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
            List<Int64> data = load_csv("data_2_peak_binom_close.txt");

            long[] distances = get_distances(data);

            int n = (int) Math.Ceiling(Math.Log(data.Count, 2));
            int m = (int) Math.Ceiling(Math.Log(distances.Max(), 2));

            using (var qsim = new QuantumSimulator())
            {
                long[] indices = new long[data.Count];
                for (int i = 0; i < data.Count; i++) {
                    indices[i] = i;
                }
                QArray<long> result = divisive_clust.Run(qsim, 4, 4, new QArray<long>(indices), new QArray<long>(distances)).Result;
                Console.WriteLine("Result:");
                Console.Write("[");
                Console.Write(String.Join(", ", result));
                Console.WriteLine("]");
                // tests.Run(qsim).Wait();
            }
        }

        /// <summary> Method <c>load_csv</c> 
        /// loads a csv file given path to the file, 
        /// and stores it in class.</summary>
        static List<Int64> load_csv(string file_path) {
            List<Int64> data = new List<Int64>();
            using(var reader = new StreamReader(file_path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    foreach (int a in Array.ConvertAll(values, Int64.Parse)) {
                        data.Add(a);
                    }
                }
            }
            return data;
        }

        static Int64[] get_distances(List<Int64> arr) {
            long[] result = new long[arr.Count * arr.Count];
            for(int i = 0; i < arr.Count; i++) {
                for(int j = 0; j < arr.Count; j++) {
                    result[16 * i + j] = Math.Abs(arr[i] - arr[j]);
                }    
            }
            return result;
        }
    }
}
