using FinanceApp.ApplicationCore.Entities;

namespace FinanceApp.Web.ViewModels
{
    public class AccountDetailsView 
    {
        public Account Account { get; }
        public AccountDetailsView(Account account)
        {
            Account = account;
        }
    }
}
