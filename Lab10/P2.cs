using System;

class LoopExamples
{
    static void Main()
    {
        // Print numbers 1-10
        Console.WriteLine("Numbers 1 to 10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        
        // While loop for user input
        string input = "";
        while (input.ToLower() != "exit")
        {
            Console.WriteLine("Enter a number to calculate factorial or 'exit' to quit:");
            input = Console.ReadLine();
            
            if (input.ToLower() != "exit")
            {
                if (int.TryParse(input, out int number))
                {
                    long fact = CalculateFactorial(number);
                    Console.WriteLine($"Factorial of {number} is {fact}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number or 'exit'");
                }
            }
        }
    }
    
    static long CalculateFactorial(int n)
    {
        if (n < 0)
            return -1; // Factorial not defined for negative numbers
        if (n == 0 || n == 1)
            return 1;
            
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}
