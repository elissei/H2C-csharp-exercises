using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
            int sum = 0;
            int counter = 0;
            int ave = 0;
            int even = 0;
            int odd = 0;
            Console.WriteLine("Give numbers:"); 
            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == -1)
                {
                    break;
                }
                else if (num % 2 == 0)
                {
                    even += 1;
                }
                sum += num;
                counter++;
                odd++;
                ave = sum / counter;
            }
            Console.WriteLine("Thx! Bye!");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Numbers: " + counter);
            Console.WriteLine("Average: " + ave);
            Console.WriteLine("Even: " + even);
            Console.WriteLine("Odd: " + odd);
  }  
  }
}
