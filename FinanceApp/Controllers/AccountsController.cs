using FinanceApp.ApplicationCore.Entities;
using FinanceApp.ApplicationCore.Interfaces;
using FinanceApp.Data;
using FinanceApp.Infrastructure.Data;
using FinanceApp.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinanceApp.Web.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IAsyncRepository<Account> _repo;
        public AccountsController(Repository<Account> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ViewResult> Index()
        {
            return View(await new AccountViewModelService(_repo).GetView());
        }

        [HttpGet, ActionName("Details")]
        public async Task<ViewResult> DetailView(int id)
        {
            return View(await new AccountViewModelService(_repo).GetView(id));
        }

    }
}
