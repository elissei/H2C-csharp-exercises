using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Where to?");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where from?");
            int start = Convert.ToInt32(Console.ReadLine());
            while (start <= num)
            {
                Console.WriteLine(start++);
            }
    }
  }
}
