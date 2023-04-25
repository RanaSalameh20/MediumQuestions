using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case 1
            int[] nums1 = { 0, 1, 0, 3, 12 }; // out: [1,3,12,0,0]
            MoveZeroes(nums1);

            foreach(int num in nums1)
            {
                Console.Write(num + ",");
                
            }
            Console.WriteLine() ;

            //Case 2
            int[] nums2 = { 0 }; // out: [0]
            MoveZeroes(nums2);
            foreach (int num in nums2)
            {
                Console.Write(num + ",");

            }

        }
        public static void MoveZeroes(int[] nums)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    Swap(nums, i, j); // Partitioning the array
                    j++;
                }
            }

        }
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
