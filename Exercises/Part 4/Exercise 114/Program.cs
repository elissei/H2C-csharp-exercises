using System;
using System.Collections.Generic;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> strings = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "end")
                {
                    break;
                }
                strings.Add(input);
            }
            Console.WriteLine(strings.Count);
            Console.ReadKey();
        }
    }
}
