﻿using System;
using System.Collections.Generic;

namespace exercise_71
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
      Console.WriteLine("Search for?");
      int value = Convert.ToInt32(Console.ReadLine());
      int i = list.IndexOf(value);
            if (list.Contains(value))
            {
                Console.WriteLine(value + " is at index " + i);
                Console.ReadKey();
            }

    }
  }
}
