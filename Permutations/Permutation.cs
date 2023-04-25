using System;
using System.Collections.Generic;

namespace Permutations
{
    internal class Permutation
    {
        public IList<IList<int>> FindPermutations(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Permute(nums, 0, result);
            return result;
        }

        public void Permute(int[] nums, int start, IList<IList<int>> result)
        {
            if (start == nums.Length - 1)
            {
                IList<int> permutation = new List<int>(nums);
                result.Add(permutation);
                return;
            }

            for (int i = start; i < nums.Length; i++)
            {
                Swap(nums, start, i);
                Permute(nums, start + 1, result);
                Swap(nums, start, i);
            }
        }

        public void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        internal void PrintPermutations(IList<IList<int>> permutations)
        {
            Console.Write("[");
            foreach (IList<int> permutation in permutations)
            {
                Console.Write("[");
                for (int i = 0; i < permutation.Count; i++)
                {
                    Console.Write(permutation[i]);
                    if (i != permutation.Count - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.Write("]");
                //Console.WriteLine();
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}