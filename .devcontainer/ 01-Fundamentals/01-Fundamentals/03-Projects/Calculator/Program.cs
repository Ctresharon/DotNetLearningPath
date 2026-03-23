// ========================================
// PROJECT 1: Simple Calculator
// ========================================

using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("╔════════════════════════════╗");
        Console.WriteLine("║   SIMPLE CALCULATOR        ║");
        Console.WriteLine("╚════════════════════════════╝\n");

        // Get first number
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine() ?? "0");

        // Get operation
        Console.WriteLine("\nOperations:");
        Console.WriteLine("1. Add (+)");
        Console.WriteLine("2. Subtract (-)");
        Console.WriteLine("3. Multiply (*)");
        Console.WriteLine("4. Divide (/)");
        Console.Write("\nSelect operation (1-4): ");
        int choice = int.Parse(Console.ReadLine() ?? "1");

        // Get second number
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine() ?? "0");

        // Calculate result
        double result = choice switch
        {
            1 => num1 + num2,
            2 => num1 - num2,
            3 => num1 * num2,
            4 => num2 != 0 ? num1 / num2 : 0,
            _ => 0
        };

        string operation = choice switch
        {
            1 => "+",
            2 => "-",
            3 => "*",
            4 => "/",
            _ => "?"
        };

        Console.WriteLine($"\n{num1} {operation} {num2} = {result}");
        Console.WriteLine("\nThank you for using Calculator! ✅");
    }
}
