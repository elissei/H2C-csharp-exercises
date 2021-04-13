using System;
using System.Collections.Generic;

namespace exercise_75
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Example method calls for testing your method.
      List<int> numbers = new List<int> {0,1,2,3,4,5,6,7,8,9};
      

      Console.WriteLine("The numbers in the range [0, 5]");
      PrintNumbersInRange(numbers, 0, 5);
      Console.ReadKey();

      //Console.WriteLine("The numbers in the range [3, 10]");
      //PrintNumbersInRange(numbers, 3, 10);
    }

    public static void PrintNumbersInRange(List<int> numbers, int lowerLimit, int upperLimit)
        {
            foreach(int number in numbers)
            {
                if(number >= lowerLimit && number <= upperLimit) Console.WriteLine(number);
            }

        }

    
  }
}

