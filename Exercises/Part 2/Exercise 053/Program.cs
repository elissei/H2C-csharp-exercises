using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Division(x, y);
            Console.ReadKey();

    }

    // Write your method here:
    public static void Division(int numerator, int denominator)
        {
            double result = numerator / denominator;
            Console.WriteLine(result);
        }

  }
}
