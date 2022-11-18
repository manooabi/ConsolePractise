class program
{
    public void PrintMin(int[] arr)
    {
        int min = arr[0];
        for(int i = 1; i < arr.Length; i++)
        {
            if(min > arr[i])
            {
                min = arr[i];
            }
        }
        Console.WriteLine("Print minimum number"+min);
    }
   public void PrintMax(int[] arr)
    {
        int max = arr[0];
        for(int i = 1; i < arr.Length; i++)
        {
            if(max < arr[i])
            {
                max = arr[i];
            }
        }
        Console.WriteLine("Print maximum number"+max);
    }
    public static void Main(string[] args)
    {
        int[] arr2 = { 40, 30, 50, 60, 20, 10 };
        int[] arr3 = { 90, 100, 80, 110, 70, 120, 50 };

        program p = new program();
        p.PrintMin(arr2);
        p.PrintMin(arr3);

       // p.PrintMax(arr2);

    }
}
