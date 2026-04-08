
class stringList
{
    List<string> NameList;
    public stringList()
    {
        NameList = new List<string>();
    }
    public void addName(string name)
    {
        if (NameList.Contains(name))
        {
            Console.WriteLine($"{name} already present in the list");
            return;
        }
        name = name.ToLower();
        name = name.Trim();
        name = name.Replace(" ", "");
        NameList.Add(name);
        Console.WriteLine($" {name} added successfully");
    }
    public void removeName(string name)
    {
        name = name.ToLower();
        name = name.Trim();
        name = name.Replace(" ", "");
        if (NameList.Contains(name))
        {
            NameList.Remove(name);
            Console.WriteLine($"{name} removed successfully");
        }
        else
        {
            Console.WriteLine($"{name} not present in the list");
        }
    }
    public void displayList()
    {
        Console.WriteLine("List of names: ");
        foreach (string name in NameList)
        {
            Console.WriteLine(name);
        }
    }
}
class CollectionStringManipulation_Task_3
{
    public static void Run()
    {
        stringList nameList = new stringList();
        Console.WriteLine("\n1.Add Name\n2.Remove Name\n3.Display List\n4.Exit \nEnter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        while (choice != 4)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter name to add: ");
                    string name = Console.ReadLine() ?? "";
                    nameList.addName(name);
                    break;
                case 2:
                    Console.WriteLine("Enter name to remove: ");
                    string name2 = Console.ReadLine() ?? "";
                    nameList.removeName(name2);
                    break;
                case 3:
                    nameList.displayList();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.WriteLine("\n--------------------Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
        }
    }
}