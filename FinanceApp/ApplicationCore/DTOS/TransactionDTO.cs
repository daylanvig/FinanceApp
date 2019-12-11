using FinanceApp.Models.Interfaces;
using System;

namespace FinanceApp.Models.DTOS
{

    public class TransactionDTO : ITransaction
    {
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
