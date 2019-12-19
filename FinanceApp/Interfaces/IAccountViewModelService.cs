using FinanceApp.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.Interfaces
{
    public interface IAccountViewModelService
    {
        public Task<AccountListView> GetView();
        public Task<AccountDetailsView> GetView(int id);
    }
}
