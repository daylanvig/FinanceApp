using AutoMapper;
using FinanceApp.ApplicationCore.Services;
using FinanceApp.Data;
using FinanceApp.Models.Entities;
using FinanceApp.Models.Interfaces;
using FinanceApp.Web.PageModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Controllers
{
    public class AccountsController : Controller
    {
        private IAsyncRepository<Account> _DAL;
        public AccountsController(DataContext context, IMapper mapper)
        {
            _DAL = new Repository<Account>(context);
        }
        public async Task<ViewResult> Index()
        {
            var accounts = await new AccountService(_DAL).LoadAccounts();
            var page = new AccountListView(accounts);
            return View(page);
        }
    }
}
