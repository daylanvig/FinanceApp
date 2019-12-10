using AutoMapper;
using FinanceApp.ApplicationCore.Specifications;
using FinanceApp.Data;
using FinanceApp.Models.Entities;
using FinanceApp.Models.Interfaces;
using FinanceApp.Web.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<AccountListView> GetView()
        {
            var accounts = await LoadAccounts();
            var page = new AccountListView(accounts);
            return page;
        }
        public async Task<AccountDetailsView> GetView(int id)
        {
            var account = await LoadByID(id);
            return new AccountDetailsView(account);
        }
        private async Task<IReadOnlyList<Account>> LoadAccounts()
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
