﻿using System;
using System.Collections.Generic;

namespace exercise_86
{
  class Program
  {
    public static void Main(string[] args)
    {
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "")
                {
                    break;
                }
                string[] parts = input.Split();
                foreach(string part in parts)
                {
                    Console.WriteLine(part);
                }
                Console.ReadKey();
            }


    }
  }
}

