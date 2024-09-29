using System;

class Program
{
    static void Main()
    {
        // Step 1: Initialize test data
        int num = 15;

        // Step 2: Check if the number is even or odd
        if (num % 2 == 0)
        {
            // Step 3: Print result for even number
            Console.WriteLine($"{num} is an even integer");
        }
        else
        {
            // Step 4: Print result for odd number
            Console.WriteLine($"{num} is an odd integer");
        }
    }
}
