using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 + number2;
            double squareRoot = Math.Sqrt(sum);
            Console.WriteLine(squareRoot);
    
    }
  }
}
