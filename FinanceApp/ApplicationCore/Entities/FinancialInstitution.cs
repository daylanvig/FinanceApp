using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models.Entities
{
    public class FinancialInstitution : BaseEntity
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
