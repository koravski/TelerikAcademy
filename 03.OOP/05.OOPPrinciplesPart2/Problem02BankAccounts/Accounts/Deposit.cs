namespace Problem02BankAccounts.Accounts
{
    using Problem02BankAccounts.Customers;

    public class Deposit : Account
    {
        // Constructor
        public Deposit(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate) { }

        // Methods
        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }
    }
}