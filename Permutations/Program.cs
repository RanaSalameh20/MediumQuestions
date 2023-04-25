using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    class Program
    {
  
        static void Main(string[] args)
        {
            //case 1 
            Permutation permutationObject = new Permutation();
            int[] nums = { 1, 2, 3 };
            IList<IList<int>> permutations = permutationObject.FindPermutations(nums);
            permutationObject.PrintPermutations(permutations);

            

            //Case 2
            int[] nums1 = { 0, 1 };
            IList<IList<int>> permutations1 = permutationObject.FindPermutations(nums1);
            permutationObject.PrintPermutations(permutations1);

         

            //case 3 
            int[] nums2 = { 1 };
            IList<IList<int>> permutations2 = permutationObject.FindPermutations(nums2);
            permutationObject.PrintPermutations(permutations2);

        }
    }
}
