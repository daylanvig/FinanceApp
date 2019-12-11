using AutoMapper;
using FinanceApp.ApplicationCore.DTOS;
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

        [HttpGet("/Accounts/")]
        public async Task<ViewResult> Index()
        {
            return View(await new AccountService(_DAL).GetView());
        }

        [HttpGet, ActionName("Details")]
        public async Task<ViewResult> DetailView(int id)
        {
            return View(await new AccountService(_DAL).GetView(id));
        }
        [HttpPut]
        public async Task<JsonResult> AddTransactions([FromForm] AccountTransactionDTO transactionData)
        {
            throw new NotImplementedException();
        }
        
    }
}
