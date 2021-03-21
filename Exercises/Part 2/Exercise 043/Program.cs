using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
            int num = Convert.ToInt32(Console.ReadLine());
            int outcome = 0;
            if (num < 0)
            {
                outcome = num * -1;
                Console.WriteLine(outcome);
            }
            else
            {
                Console.WriteLine(num);
            }
      
    }
  }
}
