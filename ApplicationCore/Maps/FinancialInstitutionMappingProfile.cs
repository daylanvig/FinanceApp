using AutoMapper;
using FinanceApp.ApplicationCore.DTOS;
using FinanceApp.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.ApplicationCore.Maps
{
    public class FinancialInstitutionMappingProfile : Profile
    {
        public FinancialInstitutionMappingProfile()
        {
            CreateMap<FinancialInstitutionDTO, FinancialInstitution>()
                .ForMember(d => d.Accounts, o => o.Ignore())
                .ForMember(d => d.Id, o => o.Ignore());
        }
    }
}
