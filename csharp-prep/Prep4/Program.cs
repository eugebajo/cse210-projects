using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
       
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            // Only add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        if (numbers.Count > 0)
        {

            // Part 1: Compute the sum
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"The sum is: {sum}");

            // Part 2: Compute the average
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // Part 3: Find the max
            
            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    // if this number is greater than the max, we have found the new max!
                    max = number;
                }
            }

            Console.WriteLine($"The max is: {max}");
            // Part 4: 
            int smallestPositive = int.MaxValue; 
            foreach (int number in numbers)
            {
                
                if (number > 0 && number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }

            // If we find a positive number, show it
            if (smallestPositive != int.MaxValue)
            {
                Console.WriteLine($"The positive number closest to 0 is: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("No positive numbers were entered.");
            }

            // Part 5:
            numbers.Sort();
            Console.WriteLine("Ordered list of numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
