using System;
using System.Collections.Generic;
using System.Linq;

namespace GasPipelineConstructionProblem
{
    public class HoarCalculateLocationAlgorithm : ICalculateLocationAlgorithm
    {
        public T Calculate<T>(IList<T> list) where T : IComparable<T>
        {
            if (list == null || !list.Any())
            {
                throw new ArgumentException("Your list must have at least 1 item");
            }
            var len = list.Count;
            return FindKthElement(list, 0, len - 1, (len - 1) / 2);
        }

        private T FindKthElement<T>(IList<T> list, int left, int right, int k) where T : IComparable<T>
        {
            while (true)
            {
                var pivotIndex = Partition(list, left, right);
                if (pivotIndex == k)
                    return list[pivotIndex];

                if (k < pivotIndex)
                    right = pivotIndex - 1;
                else
                    left = pivotIndex + 1;
            }
        }

        private int Partition<T>(IList<T> list, int left, int right, Random rnd = null) where T : IComparable<T>
        {
            if (rnd != null)
            {
                var randIndex = rnd.Next(left, right + 1);
                Swap(list, right, randIndex);
            }

            var pivot = list[right];
            var storeIndex = left - 1;
            for (var i = left; i < right; i++)
            {
                if (list[i].CompareTo(pivot) <= 0)
                {
                    Swap(list, i, ++storeIndex);
                }
            }
            Swap(list, right, ++storeIndex);
            return storeIndex;
        }

        private void Swap<T>(IList<T> list, int i, int j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
