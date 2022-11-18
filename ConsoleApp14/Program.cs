class program
{
    public void show(out int val)
    {
        int square = 5;
        val = square;
        val *= val;
        Console.WriteLine("Value inside the show function" + val);
    }
    public static void Main(string[] args)
    {
        int val = 50;
        program p = new program();
        Console.WriteLine("Value before calling the function" + val);
       
        Console.WriteLine("value after calling the function" + val);
        p.show(out val);
        Console.WriteLine("value after  2 calling the function" + val);


    }
}
