using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine();

        Console.WriteLine("Enter a list of numbes, type 0 when finished.");

        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter number: ");
            int newNumber = int.Parse(Console.ReadLine());

            if (newNumber == 0)
            {
                break;
            }

            numbers.Add(newNumber);
        }

        int sum = 0;
        int largest = int.MinValue;
        int smallestPositive = int.MaxValue;

        foreach(int number in numbers)
        {
            sum += number;

            if (number > largest)
            {
                largest = number;
            }

            if (number >= 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");

        int average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largest}");

        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        numbers.Sort();
        Console.WriteLine("The sorted list is: ");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}