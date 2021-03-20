using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give your age:");
            String age = Console.ReadLine();
            int num = Convert.ToInt32(age);
            if (num < 1900)
            {
                Console.WriteLine("You're old!");
            }
            

    }
  }
}
