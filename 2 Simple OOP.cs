class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public string Profession { get; set; }

    public Person(string name, int age, string profession)
    {
        Name = name;
        Age = age;
        Profession = profession;
        Console.WriteLine($"Person Object with name {Name} created");
    }
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name} and I'm {Age} years old. I'm a {Profession}");
    }
}

class OOP_Task_2
{
    public static void Run()
    {
        Person VG = new Person("Vaibhav Gupta", 20, "Software Engineer");
        Person SK = new Person("Sakshi", 20, "Software Dev Engineer");
        VG.Introduce();
        SK.Introduce();
    }
}
