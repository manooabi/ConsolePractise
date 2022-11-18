class porgam
{
    public static void Main(string[] args)
    {
        int[][] arr = new int[2][];
        arr[0] = new int[] { 3, 4, 5, 6, 7, 7 };
        arr[1] = new int[] { 3, 4, 5, 6, 7, 8, };

        for (int i = 0; i < arr.Length; i++)
        {
            for (int a = 0; a < arr[i].Length; a++)
            {
                Console.Write(arr[i][a]);
            }
        }
    }
}