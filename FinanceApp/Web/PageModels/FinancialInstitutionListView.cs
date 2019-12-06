using FinanceApp.Models.Entities;
using FinanceApp.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.PageModels
{
    public class FinancialInstitutionListView : IPage
    {
        public string Title { get => "Financial Institutions"; }
        public IReadOnlyList<FinancialInstitution> Institutions { get; }
        public FinancialInstitutionListView(IReadOnlyList<FinancialInstitution> institutions)
        {
            Institutions = institutions;
        }
    }
}
