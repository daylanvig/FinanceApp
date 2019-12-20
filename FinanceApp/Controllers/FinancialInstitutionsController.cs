using AutoMapper;
using FinanceApp.ApplicationCore.DTOS;
using FinanceApp.ApplicationCore.Entities;
using FinanceApp.Data;
using FinanceApp.Infrastructure.Data;
using FinanceApp.Models.Services;
using FinanceApp.Web.HelperMethods;
using FinanceApp.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinanceApp.Web.Controllers
{
    public class FinancialInstitutionsController : Controller
    {
        public Repository<FinancialInstitution> _repo;

        private FinancialInstitutionService _institutionService;
        public FinancialInstitutionsController(Repository<FinancialInstitution> repo, IMapper mapper)
        {
            _repo = repo;
            _institutionService = new FinancialInstitutionService(_repo, mapper);
        }

        // GET: FinancialInstitutions/
        [HttpGet]
        public async Task<ViewResult> Index()
        {
            var institutions = await _repo.ListAllAsync().ConfigureAwait(false);
            var page = new FinancialInstitutionListView(institutions);
            return View(page);
        }

        // GET: /FinancialInstitutions/5
        [HttpGet("/{id}")]
        public async Task<JsonResult> Edit(int id)
        {
            var institution = await _repo.GetByIdAsync(id).ConfigureAwait(false);
            return Json(institution);
        }

        // Put: /FinancialInstitutions/5
        [HttpPut("/{id}")] 
        public async Task<IActionResult> Edit(int id, [FromForm] FinancialInstitutionDTO financialInstitution)
        {
            if (ModelState.IsValid)
            {
                var updateResult = await _institutionService.TryEdit(id, financialInstitution);
                if (!updateResult.IsValid)
                {
                    ModelState.AddModelErrors(updateResult.Errors);
                }
            }
            return View(financialInstitution);
        }

        // POST: /FinancialInstitutions/
        [HttpPost("/")]
        public async Task<IActionResult> Create([FromForm] FinancialInstitutionDTO financialInstitution)
        {
            if (ModelState.IsValid)
            {
                var addResult = await _institutionService.TryAdd(financialInstitution);
                if (!addResult.IsValid)
                {
                    ModelState.AddModelErrors(addResult.Errors);
                }
            }
            return View(financialInstitution);
        }

        // DELETE: /FinancialInstitutions/5
        [HttpDelete("/{id}")]
        public async Task Delete(int id)
        {
            await _institutionService.DeleteByID(id);
        }

    }
}
