using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();

        float x = float.Parse(percentage);

        if (x >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if (x >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (x >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (x >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }

        if (x >= 70)
        {
            Console.WriteLine("Congratualtions! You passed the class.");
        }
        else
        {
            Console.WriteLine("You did not pass the class.");
        }
    }
}