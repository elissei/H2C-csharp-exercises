using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
            int oldest = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "")
                {
                    break;
                }
                string[] parts = input.Split(',');
                int age = Convert.ToInt32(parts[1]);
                for (int i = 0; i < parts.Length; i++) 
			    {
                    if(age > oldest)
                    {
                        oldest = age;
                    }
			    }
            }
            Console.WriteLine("Age of the oldest: " + oldest);
            Console.ReadKey();
    }
  }





}



