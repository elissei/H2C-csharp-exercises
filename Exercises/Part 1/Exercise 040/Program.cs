using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {
            int sum = 0;
            int amount = 0;
            while (true)
            {
                Console.WriteLine("Give a number:");
                string input = Console.ReadLine();
                int num = Convert.ToInt32(input);
                if (num == 0)
                {
                    break;
                }
                else
                {
                    sum += num;
                    amount += 1;
                }

                 
            }
            Console.WriteLine("Total sum of numbers: " + sum);
            Console.WriteLine("Total amount of numbers: " + amount);
    }
  }
}
