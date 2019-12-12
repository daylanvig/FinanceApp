using System;
using System.ComponentModel.DataAnnotations;

namespace FinanceApp.ApplicationCore.Entities
{
    public class Transaction : BaseEntity
    {
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        [Required, DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        public decimal Amount { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
