using System;

namespace FinanceApp.Models.Interfaces
{
    public interface ITransaction
    {
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
