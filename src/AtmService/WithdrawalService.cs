namespace AtmService
{
    public class WithdrawalService : IWithdrawalService
    {
        public bool Withdraw(string cardNumber, string securityCode, Money amount)
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
