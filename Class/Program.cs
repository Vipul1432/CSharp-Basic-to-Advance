public class Student
{
    int id; //data member (also instance variable)
    string? name; //data member(also instance variable)

    public static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.id = 153;
        s1.name = "Vipul Kumar";
        Console.WriteLine(s1.id);
        Console.WriteLine(s1.name);
    }
}
