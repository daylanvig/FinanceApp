using FinanceApp.ApplicationCore.Entities;
using FinanceApp.ApplicationCore.Interfaces;

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
