using System;

namespace exercise_120
{
    public class Cube
    {
        public int length;

        public Cube(int edgeLength)
        {
            this.length = edgeLength;
        }

        public int Volume()
        {
            return this.length * this.length * this.length;
        }

        public override string ToString()
        {
            return "The length of the edge is " + this.length + " and the volume " + this.length * this.length * this.length;
        }
    }
}