class prougram
{
    public void Printzminimum(int[] arr) 
    {
        int min = arr[0];
        for(int i = 1; i < arr.Length; i++)
        {
            if(min > arr[i])
            {
                min = arr[i];
            }
            
        }
        Console.WriteLine("Minimum element" + min);
    }
    public static void Main(string[] args)
    {
        int[] arr = { 10, 20, 50, 90, 3 };
        int[] arr2 = { 70, 90, 100, 30, 40 };
        prougram p = new prougram();
        p.Printzminimum(arr);
        p.Printzminimum(arr2);
    }
}