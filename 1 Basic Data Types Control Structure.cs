class Factorial_Task_1
{
    public static void Run()
    {

        int factorial(int number)
        {
            if (number == 0) return 1;
            return number * factorial(number - 1);
        }

        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0) Console.WriteLine("Number Should be greater than or equal to 0");
        else
        {
            Console.WriteLine($"Factorial of {number} is {factorial(number)}");
        }
    }
};

