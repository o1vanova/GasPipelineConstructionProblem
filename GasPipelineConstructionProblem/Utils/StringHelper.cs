using System;
using System.Collections.Generic;
using System.ComponentModel;
using GasPipelineConstructionProblem.Data;

namespace GasPipelineConstructionProblem
{
    public static class StringHelper
    {
        public static IEnumerable<T> GetArrayFromString<T>(this string input) where T : struct
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in input.GetParts(Constants.SymbolsWithSpace))
            {
                yield return (T)converter.ConvertFrom(item);
            }
        }

        private static IEnumerable<string> GetParts(this string s, char[] symbols)
        {
            return s.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
