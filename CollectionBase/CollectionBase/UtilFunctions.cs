using System;

namespace CollectionBase
{
    public class UtilFunctions
    {
        public static int[] BuildArray(int length)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = i;
            }

            return array;
        }

        public static void DisplayNums(int[] array)
        {
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
