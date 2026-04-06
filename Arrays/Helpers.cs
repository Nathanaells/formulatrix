namespace Arrays
{
    public class ArrayHelper
    {
        public static void Print2DArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public int GetMaxValue(int angka)
        {
            int max = int.MinValue;
            
            for (int i = 0; i < angka; i++)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }
    }
}