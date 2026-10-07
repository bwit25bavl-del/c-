// Console.Write("enter your name: ");

// string? name=Console.ReadLine();

// Console.Write("enter your age");

// int age =Convert.ToInt32(Console.ReadLine());
// if(age>=18){
//     Console.WriteLine($"hello {name}, old");
// }
// else{
//     Console.WriteLine($"hello {name}, young");
// }

using System;

class Program
{
    static void Main()
    {

        // 1. Get the first number
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // 2. Get the operator
        Console.Write("Enter an operator (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        // 3. Get the second number
        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // 4. Check operators using if-else if conditions
        if (op == '+')
        {
            double result = num1 + num2;
            Console.WriteLine($"Result: {num1} + {num2} = {result}");
        }
        else if (op == '-')
        {
            double result = num1 - num2;
            Console.WriteLine($"Result: {num1} - {num2} = {result}");
        }
        else if (op == '*')
        {
            double result = num1 * num2;
            Console.WriteLine($"Result: {num1} * {num2} = {result}");
        }
        else if (op == '/')
        {
            // Check to prevent division by zero
            if (num2 != 0)
            {
                double result = num1 / num2;
                Console.WriteLine($"Result: {num1} / {num2} = {result}");
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by zero!");
            }
        }
        else
        {
            // Catches any invalid symbols (like letters or other symbols)
            Console.WriteLine("Invalid operator! Please use +, -, *, or /.");
        }
    }
}
