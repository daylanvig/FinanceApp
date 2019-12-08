using AutoMapper;
using FinanceApp.ApplicationCore.Specifications;
using FinanceApp.Data;
using FinanceApp.Models.Entities;
using FinanceApp.Models.Interfaces;
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

        public async Task<IReadOnlyList<Account>> LoadAccounts()
        {
            var specification = new AccountLoadSpecification();
            var accounts = await _repo.ListAsync(specification).ConfigureAwait(false);
            return accounts;
        }
    } 
}
