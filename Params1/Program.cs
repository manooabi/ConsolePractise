class program
{
    public void show(params int[] Val)
    {
        for(int i = 0; i < Val.Length; i++)
        {
            Console.WriteLine(Val[i]);
        }
    }
    public static void Main(string[] args)
    {
        program program = new program();
        program.show(2, 3, 4, 5, 6, 7);
    }
}