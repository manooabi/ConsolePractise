class student
{
    string name = "SIlva";
    int age = 25;
    public student()
    {
        name = "perera";
        age = 45;
        Console.WriteLine(name);
        Console.WriteLine(age);
    }
    public student(string x, int y)
    {
        name = x;
        age = y;
        Console.WriteLine("Name is"+name);   
        Console.WriteLine("Age is"+ age);

    }
    public student(student s)
    {
        name=s.name;
        age = s.age;
        Console.WriteLine("Name is"+ name);
        Console.WriteLine("Age is" + age);
    }
}
class program
{
    public static void Main()
    {
        student s1 = new student();
        student s2 = new student("Manoo",24);
        student s3 = new student(s1);


    }
}
