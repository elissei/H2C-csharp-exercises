using System;
using System.IO;
using System.Threading.Tasks;

namespace exercise_116
{
  class Program
  {
    public static void Main(string[] args)
    {
           string text = File.ReadAllText("data.txt");
            Console.WriteLine(text);           
            Console.ReadKey();
    }    
  }
}
