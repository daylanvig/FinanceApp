using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Models.DTOS
{
    public class TDTransactionDTO
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal? WithdrawalAmount { get; set; }
        public decimal? DepositAmount { get; set; }
        public decimal Balance { get; set; }
    }
}
