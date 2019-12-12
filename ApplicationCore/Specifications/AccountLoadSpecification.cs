using FinanceApp.ApplicationCore.Entities;

namespace FinanceApp.ApplicationCore.Specifications
{
    public class AccountLoadSpecification : BaseSpecification<Account>
    {
        public AccountLoadSpecification() : base(a => !a.IsHidden)
        {
            AddInclude(a => a.Institution);
        }
    }
}
