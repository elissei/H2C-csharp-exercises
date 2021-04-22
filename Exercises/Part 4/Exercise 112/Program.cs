using System;
using System.Collections.Generic;

namespace exercise_112
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<TelevisionProgram> list = new List<TelevisionProgram>();
            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                 
                if(name == "")
                {
                    break;
                }
                Console.Write("Duration: ");
                int duration = Convert.ToInt32(Console.ReadLine());
                list.Add(new TelevisionProgram(name, duration));
            }
            Console.Write("Program's maximum duration? ");
            int max = Convert.ToInt32(Console.ReadLine());
            foreach(TelevisionProgram televisionProgram in list)
            {
                if(televisionProgram.duration <= max)
                {
                    Console.WriteLine(televisionProgram);
                }
            }
            Console.ReadKey();
    }
        
  }
}




