using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class RunnableAttribute : Attribute
{
}


[AttributeUsage(AttributeTargets.Method)]
public class MyAttribute : Attribute
{
    private string name;
    private string action;

    public MyAttribute(string name, string action)
    {
        this.name = name;
        this.action = action;
    }

    public string Name
    {
        get { return name; }
    }

    public string Action
    {
        get { return action; }
    }
}

class Student2
{
    private int rollNo;
    private string stuName;
    private double marks;

    [Runnable]
    [MyAttribute("Modifier", "Assigns the Student Details")]
    public void setDetails()
    {
        rollNo = 1;
        stuName = "Vaibhav";
        marks = 92.5;
        Console.WriteLine("setDetails executed");
    }

    [Runnable]
    [MyAttribute("Accessor", "Returns Value of rollNo")]
    public void getRollNo()
    {
        Console.WriteLine("Roll Number: " + rollNo);
    }

    [Runnable]
    [MyAttribute("Accessor", "Returns Value of stuName")]
    public void getStuName()
    {
        Console.WriteLine("Name: " + stuName);
    }

    [Runnable]
    [MyAttribute("Accessor", "Returns Value of marks")]
    public void getMarks()
    {
        Console.WriteLine("Marks: " + marks);
    }
}

class Reflection_and_Custom_Attributes
{
    public static void Run()
    {
        Console.WriteLine("---- Executing Runnable Methods ----");

        Assembly assembly = Assembly.GetExecutingAssembly();

        foreach (Type type in assembly.GetTypes())
        {

            object obj = null;

            try
            {
                obj = Activator.CreateInstance(type);
            }
            catch
            {
                continue;
            }

            foreach (MethodInfo method in type.GetMethods())
            {

                if (method.GetCustomAttribute(typeof(RunnableAttribute)) != null)
                {
                    Console.WriteLine($"\nExecuting Method: {method.Name}");

                    method.Invoke(obj, null);
                    var attrs = method.GetCustomAttributes(typeof(MyAttribute), false);

                    foreach (MyAttribute attr in attrs)
                    {
                        Console.WriteLine("Type: " + attr.Name);
                        Console.WriteLine("Description: " + attr.Action);
                    }
                }
            }
        }
    }
}
