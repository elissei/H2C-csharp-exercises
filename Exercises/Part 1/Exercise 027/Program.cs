using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give a number:");
            String number = Console.ReadLine();
            int num = Convert.ToInt32(number);
            if (num > 0)
            {
                Console.WriteLine("It is positive");
            }
            else
            {
                Console.WriteLine("It is not positive");
                }

    }
  }
}
