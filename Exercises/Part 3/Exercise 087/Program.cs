using System;
using System.Collections.Generic;

namespace exercise_87
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
                    if (part.Contains("av")) 
                    { 
                    Console.WriteLine(part);
                    }
                }
                Console.ReadKey();
            }
    }
  }

}

