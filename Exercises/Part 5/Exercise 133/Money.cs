namespace exercise_133
{
  public class Money
  {

    private int euros;
    private int cents;

    public Money(int euros, int cents)
    {
      if (cents > 99)
      {
        euros = euros + cents / 100;
        cents = cents % 100;
      }

      this.euros = euros;
      this.cents = cents;
    }

    public Money Plus(Money addition)
    {
      Money newMoney = new Money(euros + addition.euros, cents + addition.cents);
      if(cents > 99)
            {
                cents -= 100;
                euros++;
            }
      // create a new Money object that has the correct worth
      // return the new Money object
      return newMoney;
    }

    public Money Minus(Money decreaser)
    {
      Money newMoney = new Money(euros - decreaser.euros, cents - decreaser.cents);
      if(cents < 0)
            {
                cents += 100;
                euros--;
            }
      if(euros < 0)
            {
                newMoney = null;
                return newMoney;
            }
      return newMoney;    
    }

    public bool LessThan(Money compared)
    {
      // Do something here
      return (100 * this.euros + this.cents) < (100 * compared.euros + compared.cents);
    }

    public override string ToString()
    {
      string zero = "";
      if (cents < 10)
      {
        zero = "0";
      }

      return euros + "." + zero + cents + "e";
    }
  }
}
