using System;

namespace Largest
{
    public class LargestNumber
    {
        public string GetLargestNumber(int[] nums)
        {

            string[] numbersToStringArray = Array.ConvertAll(nums, x => x.ToString());

            Array.Sort(numbersToStringArray, (x, y) => (y + x).CompareTo(x + y));

            if (numbersToStringArray[0] == "0") return "0";

            return string.Join("", numbersToStringArray);
        }
    }
}