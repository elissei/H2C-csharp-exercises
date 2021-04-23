using System;
using System.IO;

namespace exercise_119
{
    public class Timer
    {
        public ClockHand seconds;
        public ClockHand hundrethsOfaSecond;

        public Timer()
        {
            this.seconds = new ClockHand(60);
            this.hundrethsOfaSecond = new ClockHand(100);
        }

        public override string ToString()
        {
            return this.seconds + ":" + this.hundrethsOfaSecond;
        }

        public void Advance()
        {
            this.hundrethsOfaSecond.Advance();
            if(this.hundrethsOfaSecond.value == 0)
            {
                this.seconds.Advance();
            }
        }
    }
}