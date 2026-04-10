public interface Entity
{
    int id { get; set; }
    string name { get; set; }

}
public interface IRepository<T> where T : Entity
{
    // int id { get; set; }
    // List<T> list { get; set; }
    void display();
    void Add(T entity);
    void Remove(int id);
    void Update(T entity);
    T Get(int id);
}

class Product : Entity
{
    public int id { get; set; }
    public string name { get; set; }

    public int price { get; set; }

    public Product()
    {
    }

}

class Student1 : Entity
{
    public int id { get; set; }
    public string name { get; set; }

    public string email { get; set; }

    public Student1()
    {

    }
    // public Student(int id, string name, string email)
    // {
    //     this.id = id;
    //     this.name = name;
    //     this.email = email;
    // }
}

class genClass<T> : IRepository<T> where T : Entity
{
    List<T> list = new List<T>();
    public void Add(T entity)
    {
        list.Add(entity);

    }
    public void Remove(int id)
    {
        var item = list.Find(x => x.id == id);

        if (item != null)
        {
            list.Remove(item);
            Console.WriteLine("Id removed successfully");
        }
        else
        {
            Console.WriteLine("Id not found");
        }
    }
    public void Update(T entity)
    {
        int index = list.FindIndex(x => x.id == entity.id);

        if (index != -1)
        {
            list[index] = entity;
            Console.WriteLine("Id updated successfully");
        }
        else
        {
            Console.WriteLine("Id not found");
        }
    }
    public void display()
    {
        foreach (var item in list)
        {
            Console.WriteLine(item.id + " " + item.name);
        }
    }
    public T Get(int id)
    {
        return list.Find(x => x.id == id);
    }

}
class Generics_and_Interfaces_Task_8
{
    public static void Run()
    {
        genClass<Product> product = new genClass<Product>();
        genClass<Student1> student = new genClass<Student1>();
        student.Add(new Student1 { id = 1, name = "Vaibhav", email = "VgW6a@example.com" });
        student.Add(new Student1 { id = 2, name = "Sakshi", email = "sakshi@in.com" });
        student.Add(new Student1 { id = 3, name = "Ram", email = "ram@in.com" });
        student.Add(new Student1 { id = 4, name = "Astik", email = "astik@in.com" });
        student.Add(new Student1 { id = 5, name = "Sahil", email = "sahil@in.com" });
        product.Add(new Product { id = 1, name = "Laptop", price = 100000 });
        product.Add(new Product { id = 2, name = "Mobile", price = 50000 });
        product.Add(new Product { id = 3, name = "Tablet", price = 30000 });
        product.Add(new Product { id = 4, name = "Camera", price = 20000 });
        product.Add(new Product { id = 5, name = "Watch", price = 15000 });
        student.display();
        product.display();
        student.Remove(1);
        product.Remove(1);
        student.display();
        product.display();
        student.Update(new Student1 { id = 1, name = "Vaibhav Gupta", email = "VgW6a@example.com" });
        product.Update(new Product { id = 1, name = "Laptop", price = 100000 });
        Console.WriteLine("After updating");
        student.display();
        product.display();

    }
}