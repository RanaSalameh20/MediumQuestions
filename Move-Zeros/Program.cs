using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            ZeroMoving move = new ZeroMoving();

            //Case 1
            int[] numbers1 = { 0, 1, 0, 3, 12 }; 
            move.MoveZeroesToRight(numbers1);
            move.Print(numbers1);
           
            //Case 2
            int[] numbers2 = { 0 };
            move.MoveZeroesToRight(numbers2);
            move.Print(numbers2);
        }
    }
}
