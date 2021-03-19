using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give a number!");
            string number = Console.ReadLine();
            double value = Convert.ToDouble(number);
            Console.WriteLine("You gave " + value);

    }
  }
}
