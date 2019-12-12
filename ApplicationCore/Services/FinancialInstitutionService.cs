using AutoMapper;
using FinanceApp.ApplicationCore.Validators;
using FinanceApp.ApplicationCore.DTOS;
using FinanceApp.ApplicationCore.Entities;
using FinanceApp.ApplicationCore.Interfaces;
using System.Threading.Tasks;

namespace FinanceApp.Models.Services
{
    public class FinancialInstitutionService
    {
        private IAsyncRepository<FinancialInstitution> _repo;
        private IMapper _mapper;
        public FinancialInstitutionService(IAsyncRepository<FinancialInstitution> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<ValidationResult> TryAdd(FinancialInstitutionDTO dto)
        {
            var institution = _mapper.Map<FinancialInstitutionDTO, FinancialInstitution>(dto);
            var validationSummary = await new FinancialInstitutionValidator(_repo).Validate(dto);
            if (validationSummary.IsValid)
            {
                await _repo.AddAsync(institution);
            }
            return validationSummary;
        }
        public async Task<ValidationResult> TryEdit(int id, FinancialInstitutionDTO dto)
        {
            var institution = _mapper.Map<FinancialInstitutionDTO, FinancialInstitution>(dto);
            institution.Id = id;
            var validationSummary = await new FinancialInstitutionValidator(_repo).Validate(dto, id);
            if (validationSummary.IsValid)
            {
                await _repo.UpdateAsync(institution);
            }
            return validationSummary;
        }

        public async Task DeleteByID(int id)
        {
            var institution = new FinancialInstitution { Id = id };
            await _repo.DeleteAsync(institution);
        }
    }
}
