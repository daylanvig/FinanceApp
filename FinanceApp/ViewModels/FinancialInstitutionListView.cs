using FinanceApp.ApplicationCore.Entities;
using System.Collections.Generic;

namespace FinanceApp.Web.ViewModels
{
    public class FinancialInstitutionListView
    {
        public IReadOnlyList<FinancialInstitution> Institutions { get; }
        public FinancialInstitutionListView(IReadOnlyList<FinancialInstitution> institutions)
        {
            Institutions = institutions;
        }
    }
}
