using System;

class EnhancedCalculator
{
    static void Main()
    {
        Console.WriteLine("Enhanced Calculator with Input Validation");
        Console.WriteLine("----------------------------------------");

        while (true)
        {
            try
            {
                Console.WriteLine("\nEnter first number (or 'q' to quit):");
                string input1 = Console.ReadLine();
                if (input1.ToLower() == "q") break;

                double num1 = GetValidNumber(input1, "first");

                double num2;
                bool validSecondNumber = false;
                do
                {
                    Console.WriteLine("Enter second number:");
                    string input2 = Console.ReadLine();
                    num2 = GetValidNumber(input2, "second");
                    
                    // Additional check for division by zero
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Second number cannot be zero (would cause division by zero)");
                    }
                    else
                    {
                        validSecondNumber = true;
                    }
                } while (!validSecondNumber);

                // Perform and display calculations
                DisplayResults(num1, num2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }

    static double GetValidNumber(string input, string numberPosition)
    {
        while (true)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error: Input cannot be empty");
            }
            else if (!double.TryParse(input, out double result))
            {
                Console.WriteLine("Error: Please enter a valid number");
            }
            else
            {
                return result;
            }

            Console.WriteLine($"Please enter the {numberPosition} number again:");
            input = Console.ReadLine();
        }
    }

    static void DisplayResults(double num1, double num2)
    {
        Console.WriteLine($"\nResults for {num1} and {num2}:");
        Console.WriteLine($"Addition: {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1 * num2}");
        Console.WriteLine($"Division: {num1 / num2}");

        // Check if sum is even or odd (only for whole numbers)
        double sum = num1 + num2;
        if (sum % 1 == 0) // Check if it's a whole number
        {
            Console.WriteLine($"The sum {(int)sum} is {(sum % 2 == 0 ? "even" : "odd")}");
        }
        else
        {
            Console.WriteLine($"The sum {sum} is not a whole number (cannot determine even/odd)");
        }
    }
}
