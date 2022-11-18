using System;

namespace functionExample
{
    class program
    {
        public void method()
        {
            Console.WriteLine("Non paramterised method");
        }
        public static void Main(string[] args)
        {
            program p1 = new program();
            p1.method();
        }
    }
}