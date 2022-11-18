class program
{
    public void PrintMin(int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
        }
        Console.WriteLine("Print minimum number" + min);
    }
    public void PrintMax(int[] arr)
    {
        int max = arr[0];
        for(int i = 0; i < arr.Length; i++)
        {
            if(max < arr[i])
            {
                max = arr[i];
            }
        }
    }
    public static void Main(string[] args)
    {
        int[] arr = new int[10];

        Console.WriteLine("Enter Number");
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Elements are");
            for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        program p = new program();
        p.PrintMin(arr);
        p.PrintMax(arr);
    }
}
