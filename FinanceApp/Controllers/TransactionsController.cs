using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.ApplicationCore.DTOS;
using FinanceApp.ApplicationCore.Entities;
using FinanceApp.ApplicationCore.Interfaces;
using FinanceApp.Data;
using FinanceApp.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class TransactionsController : Controller
    {
        private readonly IAsyncRepository<Transaction> _repo;
        public TransactionsController(Repository<Transaction> repo)
        {
            _repo = repo;
        }
        // POST api/<controller>
        [HttpPost]
        public IActionResult Post(int id, [FromBody] IReadOnlyList<TransactionDTO> transactions)
        {

            return Ok(); 
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
