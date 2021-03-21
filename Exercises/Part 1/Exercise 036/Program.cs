using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
            while (true)
            {
                Console.WriteLine("Give a number:");
                string input = Console.ReadLine();
                int num = Convert.ToInt32(input);
                int num1 = 0;
                if (num == 0)
                {
                    break;
                }
                else if (num % 2 != 0)
                {
                    Console.WriteLine("That is negative");
                }
                else
                {
                    num1 = num * num;
                    Console.WriteLine(num1);
                }

                 
            }

    }
  }
}
