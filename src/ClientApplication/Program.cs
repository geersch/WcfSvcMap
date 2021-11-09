using System;
using ClientApplication.WithdrawalServiceReference;
using ClientApplication.DepositServiceReference;

namespace ClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Withraw 100 Euro
            using (var proxy = new WithdrawalServiceClient())
            {
                var amount = new WithdrawalServiceReference.Money();
                amount.Amount = 100;
                amount.Currency = WithdrawalServiceReference.Currency.Euro;
                if (proxy.Withdraw("MasterCard", "1234", amount))
                {
                    Console.WriteLine("Withdrawal succeeded.");
                }
                else
                {
                    Console.WriteLine("Withdrawal failed.");
                }
            }

            Console.WriteLine();

            // Deposit 500 Euro
            using (var proxy = new DepositServiceClient())
            {
                var amount = new DepositServiceReference.Money();
                amount.Amount = 100;
                amount.Currency = DepositServiceReference.Currency.Euro;
                if (proxy.Deposit("MasterCard", "1234", amount))
                {
                    Console.WriteLine("Deposit succeeded.");
                }
                else
                {
                    Console.WriteLine("Deposit failed.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
