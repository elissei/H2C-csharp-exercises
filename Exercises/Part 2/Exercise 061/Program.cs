using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
            //PrintStars(4);
            //PrintRightTriangle(40);
            ChristmasTree(12);
            Console.ReadKey();

    }

    public static void PrintStars(int number)
    {
            int i = 0;
            while(i < number)
            {
                Console.Write("*");
                i++;
            }
            Console.WriteLine("");
    }

    public static void PrintSpaces(int number)
    {
            int x = 0;
            while(x < number)
            {
                Console.Write(" ");
                x++;
            }
    }

    public static void PrintRightTriangle(int size)
    {
            int i = 1;
            while (i <= size) 
            {
                PrintSpaces(size - i);
                PrintStars(i);
                i++;
             }
    }

    public static void ChristmasTree(int height)
    {
            int i = 1;
            while (i <= height) {
            PrintSpaces(height - i);
            PrintStars(i + (i - 1));
            i++;
            }

            PrintSpaces(height - 2);
            PrintStars(3);
            PrintSpaces(height - 2);
            PrintStars(3);
    }
  }
}
