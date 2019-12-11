using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FinanceApp.Data;
using FinanceApp.Models.DTOS;
using FinanceApp.Models.Entities;
using FinanceApp.Models.Interfaces;
using FinanceApp.Models.Services;
using FinanceApp.Web;
using FinanceApp.Web.PageModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    public class FinancialInstitutionsController : Controller
    {
        public Repository<FinancialInstitution> _DAL;

        private FinancialInstitutionService _institutionService;
        public FinancialInstitutionsController(DataContext context, IMapper mapper)
        {
            _DAL = new Repository<FinancialInstitution>(context);
            _institutionService = new FinancialInstitutionService(_DAL, mapper);
        }

        // GET: FinancialInstitutions/
        [HttpGet]
        public async Task<ViewResult> Index()
        {
            var institutions = await _DAL.ListAllAsync().ConfigureAwait(false);
            var page = new FinancialInstitutionListView(institutions);
            return View(page);
        }

        // GET: /FinancialInstitutions/5
        [HttpGet("/{id}")]
        public async Task<JsonResult> Edit(int id)
        {
            var institution = await _DAL.GetByIdAsync(id).ConfigureAwait(false);
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
