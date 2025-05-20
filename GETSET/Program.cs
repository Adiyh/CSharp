public class Student
{
    public int id { get; set; }
    public string name { get; set; }
    public int age { get; set; }

    public string course { get; set; }

    public void Display()
    {
        Console.WriteLine($"id:{id}");
        Console.WriteLine($"name:{name}");
        Console.WriteLine($"age:{age}");
        Console.WriteLine($"course:{course}");

    }
    public void run()
    {
        Student student = new Student();
        student.id = 45;
        student.name = "Adarsha";
        student.age = 12;
        student.course = "Computer";

    }

}
