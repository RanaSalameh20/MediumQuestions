using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {

        // Case 1
        // Input: nums = [10,2]
        // Output: "210"


        //Case 2 
        //Input:nums = [3,30,34,5,9]
        //Output: "9534330"
        }


        public static string LargestNumber(int[] nums)
        {
            
                // Convert the integer array to a string array
                string[] numsStr = Array.ConvertAll(nums, x => x.ToString());

                // Define a custom comparison function
                Array.Sort(numsStr, (x, y) => (y + x).CompareTo(x + y));

                // Check if the largest number is zero, if yes return "0"
                if (numsStr[0] == "0") return "0";

                // Concatenate the sorted numbers to form the largest number
                return string.Join("", numsStr);
        }
    }
}
