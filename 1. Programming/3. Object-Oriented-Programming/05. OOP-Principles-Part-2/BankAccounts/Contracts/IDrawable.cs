namespace BankAccounts.Contracts
{
    public interface IDrawable
    {
        void Withdraw(decimal amount);
    }
}