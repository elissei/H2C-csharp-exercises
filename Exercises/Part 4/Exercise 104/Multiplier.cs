namespace exercise_104
{
    public class Multiplier
    {
        public int multiplier;
        public int instance;

        public Multiplier(int number)
        {
            this.multiplier = number;
        }

        public int Multiply(int number)
        {
            this.instance = this.multiplier * number;
            multiplier = instance;
            return instance;
            
        }
    }
}