using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a username: ");
        string un = Console.ReadLine();
        Console.WriteLine("Enter password: ");
        string pas = Console.ReadLine();
        if((un == "alex" && pas == "sunshine") || (un == "emma" && pas == "haskell"))
            {
                Console.WriteLine("You have successfully logged in!");
            }
            else
            {
                Console.WriteLine("Incorrect username or password!");
            }
           Console.ReadKey();

    }
  }
}

