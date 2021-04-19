namespace exercise_108
{
    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            // write code here
            this.balance = openingBalance;
        }

        public override string ToString()
        {
            return "The card has a balance of " + this.balance + " euros";
        }

        public void EatLunch()
        {
            if(this.balance > 0)
            {
                this.balance -= 10.6;
            }
        }

        public void DrinkCoffee()
        {
            if(this.balance > 0)
            {
                this.balance -= 2.0
            }
        }
    }
}