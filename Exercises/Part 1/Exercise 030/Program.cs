using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give your percent [0 - 100]:");
            string input = Console.ReadLine();
            int percent = Convert.ToInt32(input);
            if (percent < 0)
            {
                Console.WriteLine("Impossible");
            }
            else if (percent < 50)
            {
                Console.WriteLine("Fail");
            }
            else if (percent < 60)
            {
                Console.WriteLine("Grade: 1");
            }
            else if (percent < 70)
            {
                Console.WriteLine("Grade: 2");
            }
            else if (percent < 80)
            {
                Console.WriteLine("Grade: 3");
            }
            else if (percent < 90)
            {
                Console.WriteLine("Grade: 4");
            }
            else if (percent < 100)
            {
                Console.WriteLine("Grade: 5");
            }
            else
            {
                Console.WriteLine("Outstanding!");
            }
    }
  }
}
