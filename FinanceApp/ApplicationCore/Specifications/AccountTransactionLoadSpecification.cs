using FinanceApp.Models.Entities;
using FinanceApp.Models.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.ApplicationCore.Specifications
{
    public class AccountTransactionLoadSpecification : BaseSpecification<Account>
    {
        public AccountTransactionLoadSpecification(int accountID) : base(a => a.Id == accountID)
        {
            AddInclude(a => a.Transactions);
        }
    }
}
