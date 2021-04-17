using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
            string name = "";
            int oldest = 0;
            int longest = 0;
            int currentYear = 2020;
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "")
                {
                    break;
                }
                string[] parts = input.Split(',');
                int yearOfBirth = Convert.ToInt32(parts[1]);
                int age = currentYear - yearOfBirth;
                for (int i = 0; i < parts.Length; i++) 
			    {
                    if(age > oldest)
                    {
                        oldest = age;                        
                    }
			    }
                if(input.Length > 0)
                {
                    int lengthOfTheName = parts[0].Length;
                    if(longest < lengthOfTheName)
                    {
                        longest = lengthOfTheName;
                        name = parts[0];
                    }
                }
            }
            Console.WriteLine("Longest name: " + name);
            Console.WriteLine("Highest age: " + oldest);
            Console.ReadKey();
    }
  }
}



