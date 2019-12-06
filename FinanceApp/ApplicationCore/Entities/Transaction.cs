using FinanceApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Models.Entities
{
    public class Transaction : BaseEntity, ITransaction
    {
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
