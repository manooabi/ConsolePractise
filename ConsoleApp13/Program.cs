class progra
{
    public void show(ref int num)
    {
        num *= num;
        Console.WriteLine("Value inside the show function" + num);
    }
    public static void Main(string[] args)
    {
        int num = 40;
        Console.WriteLine("Value before calling the function" + num);
        progra p = new progra();
        p.show(ref num);
        Console.WriteLine("Value after calling the function" + num);

    }
}
