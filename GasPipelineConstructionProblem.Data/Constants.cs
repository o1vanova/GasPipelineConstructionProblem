using System.Collections.Generic;

namespace GasPipelineConstructionProblem.Data
{
    public static class Constants
    {
        public static char[] SymbolsWithSpace = new[] { ' ', ',', '\t', '\r', '\n' };

        public static Dictionary<string, string> Examples = new Dictionary<string, string>()
        {
            {"5", "5"},
            {"90, 100, 110", "100"},
            {@"12,15,11,2,9,5,0,7,3,21,44,40,1,18,20,32,19,35,37,39,
               13,16,14,8,10,26,6,33,4,27,49,46,52,25,51,34,43,56,72,79,
               17,23,24,28,29,30,31,36,42,47,50,55,58,60,63,65,66,67,81,83,
               22,45,38,53,61,41,62,82,54,48,59,57,71,78,64,80,70,76,85,87,
               96,95,94,86,89,69,68,97,73,92,74,88,99,84,75,90,77,93,98,91", "49"},
        };
    }
}
