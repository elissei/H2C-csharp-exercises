﻿using System;
using System.Collections.Generic;

namespace exercise_83
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.Write("Give a word: ");
        string word = Console.ReadLine();
        Console.WriteLine(word + word + word);
        Console.ReadKey();
    }

  }
}

