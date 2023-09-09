namespace WorkingWithArrays
{
    public static class UsingIndexerForAccessingArrayElement
    {
        public static int GetFirstArrayElement(int[] array)
        {
            return array[0];
        }

        public static int GetSecondArrayElement(int[] array)
        {
            return array[1];
        }

        public static int GetThirdArrayElement(int[] array)
        {
            return array[2];
        }

        public static int GetLastElement(int[] array)
        {
            return array[array.Length];
        }

        public static int GetNextToLastElement(int[] array)
        {
            return array[array.Length - 1];
        }

        public static int GetNthArrayElement(int[] array, int n)
        {
            return array[n];
        }

        public static bool GetFirstArrayElement(bool[] array)
        {
            return array[0];
        }

        public static bool GetSecondArrayElement(bool[] array)
        {
            return array[1];
        }

        public static bool GetSixthArrayElement(bool[] array)
        {
            return array[5];
        }

        public static bool GetLastElement(bool[] array)
        {
            return array[array.Length];
        }

        public static bool GetNextToLastElement(bool[] array)
        {
            return array[array.Length - 1];
        }

        public static bool GetNthArrayElement(bool[] array, int n)
        {
            return array[n];
        }

        public static string GetFirstArrayElement(string[] array)
        {
            return array[0];
        }

        public static string GetForthArrayElement(string[] array)
        {
            return array[3];
        }

        public static string GetLastElement(string[] array)
        {
            return array[array.Length];
        }

        public static string GetNextToLastElement(string[] array)
        {
            return array[array.Length];
        }

        public static char GetFirstArrayElement(char[] array)
        {
            return array[0];
        }

        public static char GetSeventhArrayElement(char[] array)
        {
            return array[6];
        }

        public static char GetLastElement(char[] array)
        {
            return array[array.Length];
        }

        public static char GetNextToLastElement(char[] array)
        {
            return array[array.Length - 1];
        }

        public static double GetFirstArrayElement(double[] array)
        {
            return array[0];
        }

        public static double GetSeventhArrayElement(double[] array)
        {
            return array[7];
        }

        public static double GetLastElement(double[] array)
        {
            return array[array.Length];
        }

        public static double GetNextToLastElement(double[] array)
        {
            return array[array.Length - 1];
        }

        public static float GetFirstArrayElement(float[] array)
        {
            return array[0];
        }

        public static float GetNinthArrayElement(float[] array)
        {
            return array[8];
        }

        public static float GetLastElement(float[] array)
        {
            return array[array.Length];
        }

        public static float GetNextToLastElement(float[] array)
        {
            return array[array.Length - 1];
        }

        public static decimal GetLastElement(decimal[] array)
        {
            return array[array.Length];
        }

        public static decimal GetNextToLastElement(decimal[] array)
        {
            return array[array.Length - 1];
        }

        public static decimal GetThirdElementFromEnd(decimal[] array)
        {
            return array[array.Length - 3];
        }

        public static decimal GetFourthElementFromEnd(decimal[] array)
        {
            return array[array.Length - 4];
        }
    }
}
