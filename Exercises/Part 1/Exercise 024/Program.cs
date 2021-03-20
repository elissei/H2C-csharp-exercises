using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Your speed:");
            String speed = Console.ReadLine();
            int spd = Convert.ToInt32(speed);
            if (spd > 120)
            {
                Console.WriteLine("Speeding!");
            }
      
    }
  }
}
