using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Models.DTOS
{
    public class FinancialInstitutionDTO
    {
        public int? Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
    }
}
