using FinanceApp.Models.Entities;
using FinanceApp.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.PageModels
{
    public class AccountDetailsView :IPage
    {
        public string Title { get; }
        public Account Account { get; }
        public AccountDetailsView(Account account)
        {
            Title = $"Account Details - {account.Name}";
            Account = account;
        }
    }
}
