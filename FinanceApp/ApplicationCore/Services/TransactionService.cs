using FinanceApp.Models.DTOS;
using FinanceApp.Models.Entities;
using FinanceApp.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.ApplicationCore.Services
{
    public class TransactionService
    {
        private IAsyncRepository<Transaction> _repository;
        public TransactionService(IAsyncRepository<Transaction> repository)
        {
            _repository = repository;
        }

   
    }
}
