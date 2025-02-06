namespace BankingSystem
{
    public class Account
    {
        public int AccountId { get; set; }
        public double Balance { get; set; }

        public Account(int accountId, double balance)
        {
            AccountId = accountId;
            Balance = balance;
        }
    }
}
