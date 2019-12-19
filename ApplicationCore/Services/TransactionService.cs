using FinanceApp.ApplicationCore.DTOS;
using FinanceApp.ApplicationCore.Entities;
using FinanceApp.ApplicationCore.Interfaces;
using System.Collections;
using System.Collections.Generic;
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
        public async Task AddTransactions(int accountID, IEnumerable<TransactionDTO> transactions)
        {

        }
   
    }
}
