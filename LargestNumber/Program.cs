using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Case 1
            int[] numbers1 = { 10, 2 };
            LargestNumber largest = new LargestNumber();

            var result = largest.GetLargestNumber(numbers1);
            Console.WriteLine(result);

            //Case 2 
            int[] numbers2 = { 3, 30, 34, 5, 9 };

            result = largest.GetLargestNumber(numbers2);
            Console.WriteLine(result);
        }
    }
}
