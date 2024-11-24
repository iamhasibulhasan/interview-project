namespace interview_project.Domain
{
    public abstract class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string AccountHolder { get; private set; }
        protected double Balance { get; set; }

        public BankAccount(string accountNumber, string accountHolder)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
        }

        // Abstract methods
        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
    }

    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountNumber, string accountHolder)
            : base(accountNumber, accountHolder) { }
        public override void Deposit(double amount)
        {
            Balance += amount;
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
