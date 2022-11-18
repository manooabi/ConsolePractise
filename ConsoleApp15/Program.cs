class prog
{
    static void PrintArray(int[] arr)
    {
        Console.WriteLine("Printing array");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    public static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
        int[] arr2 = { 20, 30, 40, 50, 50, 30 };
        prog prog = new prog();
        PrintArray(arr1);
        PrintArray(arr2);


    }
}
