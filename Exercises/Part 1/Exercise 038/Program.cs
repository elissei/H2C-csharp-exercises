using System;

namespace exercise_38
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
                else if (num < 0)
                {
                    sum += 1;
                }

                 
            }
            Console.WriteLine("Total amount of negative numbers: " + sum);

    }
  }
}
