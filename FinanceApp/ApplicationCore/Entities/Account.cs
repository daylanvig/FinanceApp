using FinanceApp.Models.Enums;
using System.Collections.Generic;

namespace FinanceApp.Models.Entities
{
    public class Account : BaseEntity
    {
        public FinancialInstitution Institution { get; set; }
        public string Name { get; set; }
        public AccountType Type { get; set; }
        public List<Transaction> Transactions { get; set; }
        // todo -> balance as a calculated aggregate
        //public decimal Balance { get; set; }
    }
}
