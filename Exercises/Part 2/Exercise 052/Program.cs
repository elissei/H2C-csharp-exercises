using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
            int x = Convert.ToInt32(Console.ReadLine());
            PrintFromNumberToOne(x);

    }

    // Write your method here:
    public static void PrintFromNumberToOne(int number)
        {
            int i = 1;
            while (number > i)
            {
                Console.WriteLine(number);
                number--;
            }

        }

  }
}
