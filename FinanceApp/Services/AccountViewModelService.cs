using FinanceApp.ApplicationCore.Entities;
using FinanceApp.ApplicationCore.Interfaces;
using FinanceApp.ApplicationCore.Services;
using FinanceApp.Web.ViewModels;
using System.Threading.Tasks;

namespace FinanceApp.Web.Services
{
    public class AccountViewModelService
    {
        private IAsyncRepository<Account> _repo;
        public AccountViewModelService(IAsyncRepository<Account> repo)
        {
            _repo = repo;
        }
        public async Task<AccountListView> GetView()
        {
            var accounts = await new AccountService(_repo).LoadAccounts();
            var page = new AccountListView(accounts);
            return page;
        }
        public async Task<AccountDetailsView> GetView(int id)
        {
            var account = await new AccountService(_repo).LoadByID(id);
            return new AccountDetailsView(account);
        }
    }
}
