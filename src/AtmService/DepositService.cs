namespace AtmService
{
    public class DepositService : IDepositService
    {
        public bool Deposit(string cardNumber, string securityCode, Money amount)
        {
            // Validate card number and security code
            // ...

            // Debit account
            // ...

            // Instruct ATM to hand out money

            return true;
        }
    }
}
