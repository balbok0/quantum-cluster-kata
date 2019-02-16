using System;
using System.IO;
using System.Collections.Generic;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Final_Project
{
    class Driver
    {
        List<double[]> data;

        Driver() {
            data = new List<double[]>();
        }
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                HelloQ.Run(qsim).Wait();
            }
        }

        /// <summary> Method <c>load_csv</c> 
        /// loads a csv file given path to the file, 
        /// and stores it in class.</summary>
        void load_csv(string file_path) {
            using(var reader = new StreamReader(file_path))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    data.Add(Array.ConvertAll(values, Double.Parse));
                }
            }
        }
    }
}
