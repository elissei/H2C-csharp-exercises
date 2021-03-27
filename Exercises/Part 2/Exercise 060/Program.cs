using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
    {
            //PrintStars(5);
            //PrintStars(3);
            //PrintStars(9);
            //PrintSquare(20);
            //PrintRectangle(17, 3);
            PrintTriangle(4);
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

    public static void PrintSquare(int size)
    {
            int i = 0;
            while(i < size)
            {
                PrintStars(size);
                i++;
            }
    }

    public static void PrintRectangle(int width, int height)
    {
            int i = 0;
            while(i < height)
            {
                PrintStars(width);
                i++;
            }
    }

    public static void PrintTriangle(int size)
    {
            int w = 1;
            int i = 0;
            while(i < size)
            {
                PrintStars(w);
                w++;
                i++;
            }
    }
  }
}
