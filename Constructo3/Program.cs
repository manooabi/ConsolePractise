class Employee
{
    string name = "Abhi";
    int age = 24;
    public Employee()
    {
        name = "Manoo";
        age = 20;
        Console.WriteLine(name);
        Console.WriteLine(age);

    }
    public Employee(string x, int y)
    {
        name=x;
        age=y;
        Console.WriteLine(name);
        Console.WriteLine(age);    }
}
class Program
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee();
        Employee emp2 = new Employee("Sathya",23); 
    }
}
