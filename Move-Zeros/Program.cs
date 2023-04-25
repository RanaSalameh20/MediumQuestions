using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Zeros
{
    class Program : Move
    {
        static void Main(string[] args)
        {
            Move move = new Move();
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
