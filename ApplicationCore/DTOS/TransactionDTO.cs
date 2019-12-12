using FinanceApp.ApplicationCore.Interfaces;
using System;

namespace FinanceApp.ApplicationCore.DTOS
{

    public class TransactionDTO : ITransaction
    {
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
