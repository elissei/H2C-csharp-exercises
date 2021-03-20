using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give the first number!");
            String num1 = Console.ReadLine();
            Console.WriteLine("Give the second number!");
            String num2 = Console.ReadLine();
            int int1 = Convert.ToInt32(num1);
            int int2 = Convert.ToInt32(num2);
            int sum = int1 + int2;
            int multiply = int1 * int2;
            int subtract = int1 - int2;
            int divide = int1 / int2;
            Console.WriteLine(int1 + "+" + int2 + "=" + sum);
            Console.WriteLine(int1 + "-" + int2 + "=" + subtract);
            Console.WriteLine(int1 + "*" + int2 + "=" + multiply);
            Console.WriteLine(int1 + "/" + int2 + "=" + divide);

    }
  }
}
