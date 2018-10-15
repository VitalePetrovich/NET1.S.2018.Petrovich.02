using System;
using System.Linq;

namespace TasksDay02
{
    public static class Tasks
    {
        //Task1
        /// <summary>
        /// The method inserts one number into another bitwise.
        /// </summary>
        /// <param name="numberSource">
        /// Number-source.
        /// </param>
        /// <param name="numberInsert">
        /// Number to insert.
        /// </param>
        /// <param name="i">
        /// Insertion starts with this bit.
        /// </param>
        /// <param name="j">
        /// Insertion ends with this bit
        /// </param>
        /// <returns>
        /// New number.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Throws, when at least one of start or end bit are out of array.
        /// </exception>>
        public static int InsertNumber(int numberSource, int numberInsert, int i, int j)
        {
            if (i > j)
            {
                Swap(ref i, ref j);
            }

            if (j > 31 || i < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            numberInsert = numberInsert << i;

            int mask = MaskGenerate(i, j);
            
            numberInsert = numberInsert & mask;
            numberInsert = numberInsert ^ numberSource;
            numberInsert = numberInsert & mask;
            numberSource = numberInsert ^ numberSource;
            
            return numberSource;
        }

        private static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        private static int MaskGenerate(int startBit, int endBit)
        {
            int mask = 0;
            for (int k = startBit; k <= endBit; k++)
            {
                mask += (int)Math.Pow(2, k);
            }

            return mask;
        }
    }
}
