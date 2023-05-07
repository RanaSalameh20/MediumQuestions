using System;

namespace Zeros
{
    public class ZeroMoving
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
        public void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public void Print(int[] numbers)
        {
            string numbersString = string.Join(",", numbers);
            Console.WriteLine(numbersString);
        }
    }
}