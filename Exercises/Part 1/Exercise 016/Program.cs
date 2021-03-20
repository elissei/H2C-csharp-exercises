using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

            int day = 24 * 60 * 60;
            Console.WriteLine("How many days?");
            String days = Console.ReadLine();
            int days1 = Convert.ToInt32(days);
            int seconds = days1 * day;
            Console.WriteLine(seconds);

    }
  }
}
