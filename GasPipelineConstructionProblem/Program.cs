using System;
using System.Diagnostics;
using System.Linq;
using GasPipelineConstructionProblem.Data;

namespace GasPipelineConstructionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Start-----------");
            Console.WriteLine("Implement of HoarCalculateLocationAlgorithm:");

            var housesGroups = Constants.Examples.Keys.Select(points => points.GetArrayFromString<uint>().ToList());
            var project = new GasPipelineConstruction(new HoarCalculateLocationAlgorithm());

            var time = new Stopwatch();

            foreach (var houses in housesGroups)
            {
                time.Start();
                Console.WriteLine($"\nMedian is {project.CalculateLocations(houses)}");
                time.Stop();

                Console.WriteLine($"Time of decision, ms - {time.ElapsedMilliseconds}");
            }

            Console.WriteLine("----------End------------");
            Console.ReadLine();
        }
    }
}
