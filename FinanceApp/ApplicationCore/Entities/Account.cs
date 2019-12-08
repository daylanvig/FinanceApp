using FinanceApp.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace FinanceApp.Models.Entities
{
    public class Account : BaseEntity
    {
        public FinancialInstitution Institution { get; set; }
        public string Name { get; set; }
        public AccountType Type { get; set; }
        public bool IsHidden { get; set; }
        public List<Transaction> Transactions { get; set; }
        [NotMapped]
        public decimal Balance
        {
            get => Transactions == null ? 0.00m : Transactions.Sum(t => t.Amount);
        }
    }
}
