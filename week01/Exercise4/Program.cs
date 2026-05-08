using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<float> numbers = new List<float>();
        Console.WriteLine("\nEnter a List of number, type 0 when finished. \n");
        float number;

        float totalNumber = 0;
        float average;
        float smallest = 999999999;
        

        do
        {
            Console.Write("Enter Number: ");
            number = float.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
            
        }

        while (number != 0);

        foreach (float num in numbers)
        {
            totalNumber += num;
        }

        average = totalNumber / numbers.Count;

        foreach (float compr in numbers)
        {
            if (smallest > compr && compr > 0)
            {
                smallest = compr;
            }
        }

        
        Console.WriteLine($"The sum is: {totalNumber}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The smallest positive number is: {smallest}");

        if (numbers.Count != 0)
        {
            List<float> sortedList = numbers.OrderBy(x => x).ToList();
            Console.WriteLine("The sorted list is:");
            foreach(float disNum in sortedList)
            {
                Console.WriteLine(disNum);
            }
        }
        

    }
}