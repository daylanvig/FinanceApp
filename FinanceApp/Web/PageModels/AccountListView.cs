using FinanceApp.Models.Entities;
using FinanceApp.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.PageModels
{
    public class AccountListView : IPage
    {
        public string Title { get => "Accounts"; }
        public IReadOnlyList<Account> Accounts { get; }
        public AccountListView(IReadOnlyList<Account> accounts)
        {
            Accounts = accounts;
        }
    }
}
