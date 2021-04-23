namespace exercise_126
{
  public class PaymentTerminal
  {
    public double money { get; private set; }  // amount of cash
    public int coffeeAmount { get; private set; } // number of sold coffees
    public int lunchAmount { get; private set; }  // number of sold lunches

    public PaymentTerminal()
    {
      this.money = 1000;
    }

    public double DrinkCoffee(double payment)
    {
      if(payment < 2.5)
            {
                return payment;
            }
      this.money += 2.5;
      this.coffeeAmount++;
      return payment - 2.5;
    }

    public double EatLunch(double payment)
    {
        if(payment < 10.3)
            {
                return payment;
            }
      this.money += 10.3;
      this.lunchAmount++;
      return payment - 10.3;
    }

    public bool DrinkCoffee(PaymentCard card)
    {
        if(card.balance < 2.5)
            {
                return false;
            }
        card.TakeMoney(2.5);
        this.coffeeAmount++;
        return true;
    }

    public bool EatLunch(PaymentCard card)
    {
        if(card.balance < 10.3)
            {
                return false;
            }
        card.TakeMoney(10.3);
        this.lunchAmount++;
        return true;
    }

    public void AddMoneyToCard(PaymentCard card, double sum)
    {
      if(sum < 0)
            {
                return;
            }
      card.AddMoney(sum);
      this.money += sum;

    }

    public override string ToString()
    {
      return "money: " + money + ", number of sold coffees: " + coffeeAmount + ", number of sold lunches: " + lunchAmount;
    }
  }
}