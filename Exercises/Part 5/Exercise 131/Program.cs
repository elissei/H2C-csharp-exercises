using System;
using System.Collections.Generic;

namespace exercise_131
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<Item> items = new List<Item>();
            while (true) 
            { 
                Console.WriteLine("Indentifier? (empty will stop):");
                string identifier = Console.ReadLine();                
                if(identifier == "")
                {
                    break;
                }
                Console.WriteLine("Name? (empty will stop):");
                string name = Console.ReadLine();
                if(identifier == " ")
                {
                    break;
                }
                Item item = new Item(identifier, name);
                if (!(items.Contains(item)))
                {
                    items.Add(item);
                }
                else
                {
                    continue;
                }
            }
      // The end printing is ready, don't touch this
      Console.WriteLine("==Items==");
      foreach (Item item in items)
      {
        Console.WriteLine(item);
      }
      Console.ReadKey();
    }
  }
}
