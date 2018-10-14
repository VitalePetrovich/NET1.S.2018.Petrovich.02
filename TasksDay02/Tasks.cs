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
        /// <returns></returns>
        public static int InsertNumber(int numberSource, int numberInsert, int i, int j)
        {
            if (i > j)
            {
                int temp = j;
                j = i;
                i = temp;
            }

            if (j > 31 || i < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            numberInsert = numberInsert << i;
            int mask = 0;
            for (int k = i; k <= j; k++)
            {
                mask += (int)Math.Pow(2, k);
            }
            
            numberInsert = numberInsert & mask;
            numberInsert = numberInsert ^ numberSource;
            numberInsert = numberInsert & mask;
            numberSource = numberInsert ^ numberSource;
            
            return numberSource;
        }

        //Task2
        private static T[] SubArray<T>(T[] sourceArr, int startIndex, int endIndex)
        {
            T[] tempArr = new T[endIndex - startIndex + 1];
            for (int i = startIndex, currIndex = 0; i <= endIndex; i++, currIndex++)
            {
                tempArr[currIndex] = sourceArr[i];
            }

            return tempArr;
        }

        /// <summary>
        /// Return largest element of the array.
        /// </summary>
        /// <param name="arr">
        /// Array-source.
        /// </param>
        /// <returns></returns>
        public static int MaxElement(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return arr[0];
            }

            int temp1 = MaxElement(SubArray(arr, 0, arr.Length / 2 - 1));
            int temp2 = MaxElement(SubArray(arr, arr.Length / 2, arr.Length - 1));

            return (temp1 > temp2)?temp1:temp2;
        }

        //Task3 (NOT FINISHED)
        /// <summary>
        /// Method finds index of element, the sums of elements to the right and left of which are equal.
        /// </summary>
        /// <param name="sourceArr">
        /// Array-source.
        /// </param>
        /// <returns></returns>
        public static int MiddleSum(double[] sourceArr)
        {
            int currIndex = sourceArr.Length / 2;
            double sumLeft = SubArray(sourceArr, 0, currIndex - 1).Sum();
            double sumRight = SubArray(sourceArr, currIndex + 1, sourceArr.Length - 1).Sum();

            while (sumLeft != sumRight)
            {
                double diffBeforeMoving = sumRight - sumLeft;

                if (currIndex < 1 || currIndex >= sourceArr.Length - 1)
                {
                    return -1;
                }

                if (sumLeft > sumRight)
                {
                    sumRight += sourceArr[currIndex--];
                    sumLeft -= sourceArr[currIndex];
                }
                else
                {
                    sumLeft += sourceArr[currIndex++];
                    sumRight -= sourceArr[currIndex];
                }

                if (diffBeforeMoving * (sumRight - sumLeft) < 0)
                {
                    return -1;
                }
            }

            return currIndex;
        }

        //Task4
        /// <summary>
        /// Concatenation two string. Returns string with unique symbols.
        /// </summary>
        /// <param name="str1">
        /// 1st string.
        /// </param>
        /// <param name="str2">
        /// 2nd string.
        /// </param>
        /// <returns></returns>
        public static string UniqConcat(string str1, string str2)
        {
            return new string((str1 + str2).Distinct().ToArray());
        }
    }
}
