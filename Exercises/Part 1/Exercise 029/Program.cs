using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give the first number!");
            String int1 = Console.ReadLine();
            Console.WriteLine("Give the second number!");
            String int2 = Console.ReadLine();
            int num1 = Convert.ToInt32(int1);
            int num2 = Convert.ToInt32(int2);
            if (num1 > num2)
            {
                Console.WriteLine("The larger number is " + num1 + "!");
            }
            if (num1 < num2)
            {
                Console.WriteLine("The larger number is " + num2 + "!");
            }
            else
            {
                Console.WriteLine("They are equal!");
            }
    }
  }
}
