using System;

namespace WorkingWithArrays
{
    public static class UsingRanges
    {
        public static int[] GetArrayWithAllElements(int[] array)
        {
            int[] temp = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
            }

            return temp;
        }

        public static int[] GetArrayWithoutFirstElement(int[] array)
        {
            int[] temp = new int[array.Length - 1];

            for (int i = 1, j = 0; i < array.Length; i++, j++)
            {
                temp[j] = array[i];
            }

            return temp;
        }

        public static int[] GetArrayWithoutTwoFirstElements(int[] array)
        {
            int[] temp = new int[array.Length - 2];

            for (int i = 2, j = 0; i < array.Length; i++, j++)
            {
                temp[j] = array[i];
            }

            return temp;
        }

        public static int[] GetArrayWithoutThreeFirstElements(int[] array)
        {
            int[] temp = new int[array.Length - 3];

            for (int i = 3, j = 0; i < array.Length; i++, j++)
            {
                temp[j] = array[i];
            }

            return temp;
        }

        public static int[] GetArrayWithoutLastElement(int[] array)
        {
            int[] temp = new int[array.Length - 1];

            for (int i = 0; i < array.Length - 1; i++)
            {
                temp[i] = array[i];
            }

            return temp;
        }

        public static int[] GetArrayWithoutTwoLastElements(int[] array)
        {
            int[] temp = new int[array.Length - 2];

            for (int i = 0; i < array.Length - 2; i++)
            {
                temp[i] = array[i];
            }

            return temp;
        }

        public static int[] GetArrayWithoutThreeLastElements(int[] array)
        {
            int[] temp = new int[array.Length - 3];

            for (int i = 0; i < array.Length - 3; i++)
            {
                temp[i] = array[i];
            }

            return temp;
        }

        public static bool[] GetArrayWithoutFirstAndLastElements(bool[] array)
        {
            bool[] temp = new bool[array.Length - 2];

            for (int i = 1, j = 0; i < array.Length - 1; i++, j++)
            {
                temp[j] = array[i];
            }

            return temp;
        }

        public static bool[] GetArrayWithoutTwoFirstAndTwoLastElements(bool[] array)
        {
            bool[] temp = new bool[array.Length - 4];

            for (int i = 2, j = 0; i < array.Length - 2; i++, j++)
            {
                temp[j] = array[i];
            }

            return temp;
        }

        public static bool[] GetArrayWithoutThreeFirstAndThreeLastElements(bool[] array)
        {
            bool[] temp = new bool[array.Length - 6];

            for (int i = 3, j = 0; i < array.Length - 3; i++, j++)
            {
                temp[j] = array[i];
            }

            return temp;
        }
    }
}
