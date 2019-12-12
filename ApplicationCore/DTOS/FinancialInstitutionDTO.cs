using System.ComponentModel.DataAnnotations;

namespace FinanceApp.ApplicationCore.DTOS
{
    public class FinancialInstitutionDTO
    {
        public int? Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
    }
}
