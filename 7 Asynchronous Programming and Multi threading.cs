class AsynchronassProgrammingAndMultiThreading_Task_7
{
    async static Task<string> function1()
    {
        Console.WriteLine("Collecting data from function1");
        await Task.Delay(10000);
        return "Hello from function1";
    }
    async static Task<string> function2()
    {
        Console.WriteLine("Collecting data from function2");
        await Task.Delay(15000);
        return "Hello from function2";
    }

    public static async Task Run()
    {

        try
        {
            var task1 = function1();
            var task2 = function2();
            var result = await Task.WhenAll(task1, task2);
            Console.WriteLine(result[0] + " " + result[1]);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}