using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
            Console.WriteLine("How many times?");
            int i = Convert.ToInt32(Console.ReadLine());
            
 
    }

    // Write your method here:
    public static void PrintPhrase(int i) {
            int x = 0;
            while (x < i) 
            { 
                Console.WriteLine("In a hole in the ground there lived a method");
                x++;
                }
    }
  }
}
