using System;

namespace exercise_35
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
                if (input == "42")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

    }
  }
}
