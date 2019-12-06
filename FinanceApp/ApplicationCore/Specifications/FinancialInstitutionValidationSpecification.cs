using FinanceApp.Models.Entities;
using FinanceApp.Models.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.ApplicationCore.Specifications
{
    public class FinancialInstitutionValidationSpecification : BaseSpecification<FinancialInstitution>
    {
        public FinancialInstitutionValidationSpecification(string name, int? id = null) : base(f => f.Name.ToLower() == name.ToLower() && f.Id != id)
        {

        }
    }
}
