using FinanceApp.ApplicationCore.Entities;
using System.Collections.Generic;

namespace FinanceApp.Web.ViewModels
{
    public class AccountListView
    {
        public IReadOnlyList<Account> Accounts { get; }
        public AccountListView(IReadOnlyList<Account> accounts)
        {
            Accounts = accounts;
        }
    }
}
