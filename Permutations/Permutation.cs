using System;
using System.Collections.Generic;

namespace Permutations
{
    internal class Permutation
    {
        public List<List<int>> FindPermutations(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();
            Permute(nums, 0, result);
            return result;
        }

        public void Permute(int[] nums, int start, List<List<int>> result)
        {
            if (start == nums.Length - 1)
            {
                List<int> permutation = new List<int>(nums);
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

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        public void PrintPermutations(List<List<int>> permutations)
        {
          
            var parsedPermutations = new List<string>();
            permutations.ForEach(x => parsedPermutations.Add($"[ {string.Join(" , ", x)} ]"));
            var result = $"[ {string.Join(" , ", parsedPermutations)} ]";
            Console.Write(result);
            Console.WriteLine("");

        }
    }
}