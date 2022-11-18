class program
{
    public void show(int val)
    {
        val *= val;
        Console.WriteLine("Value inside the show function"+val);
    }
    public static void Main(string[] args)
    {
        int val = 50;
        program p = new program();
        Console.WriteLine("Value before callig the function" + val);
        p.show(val);
        Console.WriteLine("Value after calling the function"+ val);

    }
}
