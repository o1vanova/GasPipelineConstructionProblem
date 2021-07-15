using System;
using System.Collections.Generic;

namespace GasPipelineConstructionProblem
{
    public class GasPipelineConstruction
    {
        private ICalculateLocationAlgorithm algorithm;

        public GasPipelineConstruction(ICalculateLocationAlgorithm algorithm)
        {
            this.algorithm = algorithm;
        }

        public void SetAlgorithm(ICalculateLocationAlgorithm algorithm)
        {
            this.algorithm = algorithm;
        }

        public T CalculateLocations<T>(IList<T> houses) where T : IComparable<T>
        {
            return algorithm.Calculate<T>(houses);
        }
    }
}
