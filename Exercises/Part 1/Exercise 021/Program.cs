using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give the first number!");
            String num1 = Console.ReadLine();
            Console.WriteLine("Give the second number!");
            String num2 = Console.ReadLine();
            int int1 = Convert.ToInt32(num1);
            int int2 = Convert.ToInt32(num2);
            int result = (int1 + int2) / 2;
            Console.WriteLine("The average is " + result);

    }
  }
}
