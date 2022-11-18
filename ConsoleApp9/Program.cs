class program
{
    public string display(string message)
    {
        Console.WriteLine("Inside dispplat function");
        return message;
    }
    public static void Main(string[] args)
    {
        program program1 = new program();
        string message1 = program1.display("Manoo");
        Console.WriteLine("Hello"+message1);

    }
}
