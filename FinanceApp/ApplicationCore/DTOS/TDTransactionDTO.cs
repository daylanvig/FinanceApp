using FinanceApp.Models.Interfaces;
using System;

namespace FinanceApp.Models.DTOS
{
  
    public class TDTransactionDTO : ITransaction
    {
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public decimal? WithdrawalAmount { get; set; }
        public decimal? DepositAmount { get; set; }
        public decimal Amount { 
            get =>(WithdrawalAmount ?? DepositAmount).Value; 
            set { 
                if(value > 0)
                {
                    DepositAmount = value;
                }
                else
                {
                    WithdrawalAmount = value;
                }
            } 
        }
    }
}
