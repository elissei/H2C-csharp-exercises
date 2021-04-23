using System;
using System.IO;

namespace exercise_117
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Ask the user for the file name and print the content of the file
      Console.WriteLine("Which file should have its content printed?");
      string file = Console.ReadLine();
      if(file == "data.txt")
            {
                string text = File.ReadAllText("data.txt");
                Console.WriteLine(text);
            }
      if(file == "song.txt")
            {
                string text = File.ReadAllText("song.txt");
                Console.WriteLine(text);
            }
      Console.ReadKey();
    }
  }
}
