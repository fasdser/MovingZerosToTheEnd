using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingZerosToTheEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
            Console.ReadKey();
        }

        public static int[] MoveZeroes(int[] arr)
        {
            var list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]!=0)
                {
                    list.Add(arr[i]);
                }
            }         

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j]==0)
                {
                    list.Add(arr[j]);
                }
            }
            foreach(int number in list)
                Console.WriteLine(number);
            return list.ToArray();
        }


        public static int[] MoveZeroes1(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }

        public static int[] MoveZeroes2(int[] arr)
        {
            return arr.Where(x => x != 0).Concat(arr.Where(x => x == 0)).ToArray();
        }

        public static int[] MoveZeroes3(int[] arr)
        {
            // This solution makes use of C#'s behaviour with unassigned ints in arrays: They are 0 by default.
            // So we basically only have to create a new array with the same size, and write non-zero values
            // in their usual order. Simple.
            int[] zeroesAtEnd = new int[arr.Length];
            int currIndex = -1;
            foreach (int num in arr)
            {
                if (num != 0)
                {
                    currIndex++;
                    zeroesAtEnd[currIndex] = num;
                }
            }
            return zeroesAtEnd;
        }
    }
}
