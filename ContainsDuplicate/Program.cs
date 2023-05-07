using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Duplicates duplicate = new Duplicates();

            // Case 1
            int[] numbers1 = { 1, 2, 3, 1 };
            bool result = duplicate.CheckForDuplicates(numbers1);
            Console.WriteLine(result);

            // Case2 
            int[] numbers2 = { 1, 2, 3, 4 };
            result = duplicate.CheckForDuplicatesUsingLINQ(numbers2);
            Console.WriteLine(result);


            //Case3
            int[] numbers3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            result = duplicate.CheckForDuplicatesUsingLINQ(numbers3);
            Console.WriteLine(result);

        }
    }
}
