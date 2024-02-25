using System;
using System.Collections.Generic;
using System.Linq;

namespace StatisticsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage of the Statistics class
            var statistics = new Statistics();
            var numbers = new List<double> { 1, 2, 3, 4, 5 };

            var mean = statistics.Mean(numbers);
            var variance = statistics.Variance(numbers);
            var standardDeviation = statistics.StandardDeviation(numbers);

            Console.WriteLine($"Mean: {mean}");
            Console.WriteLine($"Variance: {variance}");
            Console.WriteLine($"Standard Deviation: {standardDeviation}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }


    public class Statistics
    {
        public double Mean(List<double> numbers)
        {
            return numbers.Average();
        }
        public double Variance(List<double> numbers)
        {
            double mean = Mean(numbers);
            return numbers.Sum(num => Math.Pow(num - mean, 2)) / numbers.Count;
        }
        public double StandardDeviation(List<double> numbers)
        {
            double variance = Variance(numbers);
            return Math.Sqrt(variance);
        }


    }

}
