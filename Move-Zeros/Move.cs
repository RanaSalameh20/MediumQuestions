using System;

namespace Move_Zeros
{
    public class Move
    {
        public void MoveZeroesToRight(int[] numbers)
        {
            int j = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    Swap(numbers, i, j); // Partitioning the array
                    j++;
                }
            }

        }
         void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        internal void Print(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number + ",");

            }
        }
    }
}