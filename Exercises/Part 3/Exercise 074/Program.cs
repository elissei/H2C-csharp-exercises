using System;
using System.Collections.Generic;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
      Console.WriteLine("Search for?");
      string input1 = Console.ReadLine();
            if (list.Contains(input1))
            {
                Console.WriteLine(input1 + " was found!");
                Console.ReadKey();
            }
            Console.WriteLine(input1 + " was not found!");
            Console.ReadKey();
    }
  }
}

