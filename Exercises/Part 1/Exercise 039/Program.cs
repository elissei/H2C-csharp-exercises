using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
            int sum = 0;
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
                }

                 
            }
            Console.WriteLine("Total sum of numbers: " + sum);
    }
  }
}
