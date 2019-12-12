using FinanceApp.ApplicationCore.Entities;

namespace FinanceApp.ApplicationCore.Specifications
{
    public class AccountTransactionLoadSpecification : BaseSpecification<Account>
    {
        public AccountTransactionLoadSpecification(int accountID) : base(a => a.Id == accountID)
        {
            AddInclude(a => a.Transactions);
        }
    }
}
