using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using GasPipelineConstructionProblem.Data;

namespace GasPipelineConstructionProblem.Tests
{
    [TestFixture]
    public class TestBlock
    {
        [Test]
        public void FindMedians()
        {
            var project = new GasPipelineConstruction(new HoarCalculateLocationAlgorithm());
            var housesGroups = Constants.Examples.Select((group) =>
              new { houses = group.Key.GetArrayFromString<uint>().ToList(), median = group.Value });

            foreach (var housesGroup in housesGroups)
            {
                var result = project.CalculateLocations(housesGroup.houses);
                var expectedResult = housesGroup.median;
                Console.WriteLine($"\nResult: {result};\nExpected result: {expectedResult}");
                Assert.AreEqual(expectedResult, result, $"Median isn't right");
            }
        }
    }
}
