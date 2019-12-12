using FinanceApp.ApplicationCore.Entities;

namespace FinanceApp.ApplicationCore.Specifications
{
    public class FinancialInstitutionValidationSpecification : BaseSpecification<FinancialInstitution>
    {
        public FinancialInstitutionValidationSpecification(string name, int? id = null) : base(f => f.Name.ToLower() == name.ToLower() && f.Id != id)
        {

        }
    }
}
