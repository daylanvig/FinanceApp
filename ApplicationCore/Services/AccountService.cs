using FinanceApp.ApplicationCore.Entities;
using FinanceApp.ApplicationCore.Interfaces;
using FinanceApp.ApplicationCore.Specifications;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinanceApp.ApplicationCore.Services
{
    public class AccountService
    {
        private IAsyncRepository<Account> _repo;
        public AccountService(IAsyncRepository<Account> repo)
        {
            _repo = repo;
        }
        public async Task<IReadOnlyList<Account>> LoadAccounts()
        {
            var specification = new AccountLoadSpecification();
            var accounts = await _repo.ListAsync(specification).ConfigureAwait(false);
            return accounts;
        }

        public async Task<Account> LoadByID(int accountID)
        {
            var specification = new AccountTransactionLoadSpecification(accountID);
            var account = await _repo.GetAsync(specification);
            return account;
        }
    } 
}
