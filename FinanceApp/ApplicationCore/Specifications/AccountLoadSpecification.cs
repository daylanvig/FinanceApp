using FinanceApp.Models.Entities;
using FinanceApp.Models.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.ApplicationCore.Specifications
{
    public class AccountLoadSpecification : BaseSpecification<Account>
    {
        public AccountLoadSpecification() : base(a => !a.IsHidden)
        {
            AddInclude(a => a.Institution);
        }
    }
}
