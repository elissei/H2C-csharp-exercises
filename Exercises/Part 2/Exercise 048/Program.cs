using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give numbers:"); 
            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == -1)
                {
                    break;
                }
            }
            Console.WriteLine("Thx! Bye!");
  }  
  }
}
