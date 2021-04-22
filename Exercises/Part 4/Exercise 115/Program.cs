using System;

namespace exercise_115
{
  class Program
  {
    public static void Main(string[] args)
    {
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "end")
                {
                    break;
                }
                int x = Convert.ToInt32(input);
                int z = x * x * x;
                Console.WriteLine(z);
            }
            Console.ReadKey();
    }
  }
}
