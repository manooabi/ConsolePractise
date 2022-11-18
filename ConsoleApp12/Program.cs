class program
{
    public void show(int num)
    {
        num *= num;
        Console.WriteLine("Vaue inside show function" + num);
    }
    public static void Main(string[] args)
    {
        int num = 100;
        Console.WriteLine("Value before calling the function" + num);
        program p = new program();
        p.show(num);
        Console.WriteLine("Value after calling the function" + num);

    }
}
