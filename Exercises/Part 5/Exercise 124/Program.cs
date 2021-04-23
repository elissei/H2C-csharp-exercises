using System;
using System.Collections.Generic;

namespace exercise_124
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Implement your program here!
      List<string> lines = new List<string>();
      lines.Add("Sometimes programming really frustrates me");
      lines.Add("But somehow, I just get over it");
      lines = null;
      foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
      Console.ReadKey();

      
    }
  }
}
