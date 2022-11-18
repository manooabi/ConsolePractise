class program
{
    public static void Main(string[] args)
    {
        int[][] arr = new int[2][];
        arr[0] = new int[] { 11, 23, 45, 6, 7, 8 };
        arr[1] = new int[] { 45, 55, 6, 78, 9 };

        for (int i = 0; i < arr.Length; i++)
        {
            for (int a = 0; a < arr[i].Length; a++)
            {
                Console.WriteLine(arr[i][a]);
            }
        }
    }
}