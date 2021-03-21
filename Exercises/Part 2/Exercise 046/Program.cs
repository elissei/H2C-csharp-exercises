using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {
            int num = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (num <= 100)
                {
                    Console.WriteLine(num++);
                }
            }

    }
  }
}
