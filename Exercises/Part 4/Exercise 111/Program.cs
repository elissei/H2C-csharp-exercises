using System;
using System.Collections.Generic;

namespace exercise_111
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<PersonalInformation> list = new List<PersonalInformation>();
            while (true)
            {
                Console.WriteLine("First name:");
                string fname = Console.ReadLine();
                if(fname == "")
                {
                    break;
                }
                Console.WriteLine("Last name:");
                string lname = Console.ReadLine();
                Console.WriteLine("Identification number:");
                string id = Console.ReadLine();
                list.Add(new PersonalInformation(fname, lname, id));
            }
            Console.WriteLine("");
            foreach(PersonalInformation person in list)
            {       
                Console.WriteLine(person.firstName + " " + person.lastName);
            }
            Console.ReadKey();
    }
  }
}




