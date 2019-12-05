using AutoMapper;
using FinanceApp.Models.DTOS;
using FinanceApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Maps
{
    public class TransactionMappingProfile : Profile
    {
        public TransactionMappingProfile()
        {
            CreateMap<TDTransactionDTO, Transaction>()
                .ForMember(d => d.Amount, o => o.MapFrom(s => s.DepositAmount ?? s.WithdrawalAmount.Value * -1)); // if deposit amount is null, is a withdrawal
        }
    }
}
