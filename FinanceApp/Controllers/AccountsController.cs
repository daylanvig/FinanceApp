using AutoMapper;
using FinanceApp.ApplicationCore.DTOS;
using FinanceApp.ApplicationCore.Entities;
using FinanceApp.ApplicationCore.Interfaces;
using FinanceApp.ApplicationCore.Services;
using FinanceApp.Data;
using FinanceApp.Infrastructure.Data;
using FinanceApp.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinanceApp.Web.Controllers
{
    public class AccountsController : Controller
    {
        private IAsyncRepository<Account> _DAL;
        public AccountsController(DataContext context)
        {
            _DAL = new Repository<Account>(context);
        }

        [HttpGet]
        public async Task<ViewResult> Index()
        {
            return View(await new AccountViewModelService(_DAL).GetView());
        }

        [HttpGet, ActionName("Details")]
        public async Task<ViewResult> DetailView(int id)
        {
            return View(await new AccountViewModelService(_DAL).GetView(id));
        }

    }
}
