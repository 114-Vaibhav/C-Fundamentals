class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
    public int Age { get; set; }

    public Student(string name, int marks, int age)
    {
        Name = name;
        Marks = marks;
        Age = age;
    }

}

class CollectionLinq_Task_4
{
    public static void Run()
    {
        List<string> first_name = ["Vaibhav", "Sakshi", "Ram", "Astik", "Sahil"];
        List<string> last_name = ["Gupta", "Arora", "Mittal", "Katiyar"];

        List<Student> students = new List<Student>();

        for (int i = 0; i < 20; i++)
        {
            Random rnd = new Random();
            string name = first_name[Random.Shared.Next(first_name.Count)] + " " + last_name[Random.Shared.Next(last_name.Count)];
            Student student = new Student(name, rnd.Next(35, 100), rnd.Next(20, 30));
            students.Add(student);
        }
        Console.WriteLine("List of students with marks greater than 60: ");
        var result = from student in students where student.Marks > 60 orderby student.Marks descending select student;

        foreach (var student in result)
        {
            Console.WriteLine($"Name: {student.Name}, Marks: {student.Marks}, Age: {student.Age}");
        }
    }
}