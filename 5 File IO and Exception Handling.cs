class FileIOAndExceptionHandling_Task_5
{
    static int countWords(string content)
    {
        string[] words = content.Split(' ');
        return words.Length;
    }
    public static void Run()
    {
        try
        {
            using (File.Create("temp.txt")) { }
            File.WriteAllText("temp.txt", "Vaibhav Gupta wrote this file.");
            Console.WriteLine("File Created and written successfully.");
            Console.WriteLine("Here is the content of the file: ");
            string content = File.ReadAllText("temp.txt");
            Console.WriteLine(content);
            int wordCount = countWords(content);
            Console.WriteLine($"\nNumber of words in the file: {wordCount}");
            File.AppendAllText("temp.txt", "Number of words in the file: " + wordCount);
            Console.WriteLine("\nHere is the content of the file after appending: ");
            content = File.ReadAllText("temp.txt");
            Console.WriteLine(content);
            File.Delete("temp.txt");
            Console.WriteLine("File deleted successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }

    }
}
