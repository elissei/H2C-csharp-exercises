namespace exercise_126
{
  public class PaymentCard
  {
    public double balance { get; private set; }

    public PaymentCard(double balance)
    {
      this.balance = balance;
    }

    public void AddMoney(double increase)
    {
      this.balance = this.balance + increase;
    }

    public bool TakeMoney(double amount)
    {
      if(this.balance < amount)
            {
                return false;
            }
            this.balance -= amount;
            return true;
    }
  }
}