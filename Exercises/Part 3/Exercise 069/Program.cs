using System;
using System.Collections.Generic;

namespace exercise_69
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }
      Console.WriteLine("From where?");
      int a = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where to?");
      int z = Convert.ToInt32(Console.ReadLine());
      while(a <= z)
            {
                if (list.Contains(a))
                {
                    Console.WriteLine(a);
                }
                a++;
            }
      Console.ReadKey();

    }
  }
}
