using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give a string:");
            String word = Console.ReadLine();
            Console.WriteLine("Give an integer:");
            String number = Console.ReadLine();
            Console.WriteLine("Give a double:");
            String decimal23 = Console.ReadLine();
            Console.WriteLine("Give a boolean:");
            String boo = Console.ReadLine();
            int number1 = Convert.ToInt32(number);
            double deci = Convert.ToDouble(decimal23);
            Boolean boo1 = Convert.ToBoolean(boo);
            Console.WriteLine("Your string: " + word);
            Console.WriteLine("Your integer: " + number1);
            Console.WriteLine("Your double: " + deci);
            Console.WriteLine("Your boolean: " + boo1);

    }
  }
}
