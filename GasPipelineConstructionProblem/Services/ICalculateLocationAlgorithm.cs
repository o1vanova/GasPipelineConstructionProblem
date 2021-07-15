using System;
using System.Collections.Generic;

namespace GasPipelineConstructionProblem
{
    public interface ICalculateLocationAlgorithm
    {
        T Calculate<T>(IList<T> list) where T : IComparable<T>;
    }
}
