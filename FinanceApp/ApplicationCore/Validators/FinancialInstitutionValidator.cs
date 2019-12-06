﻿using FinanceApp.ApplicationCore.Specifications;
using FinanceApp.Models.DTOS;
using FinanceApp.Models.Entities;
using FinanceApp.Models.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.ApplicationCore.Validators
{
    public class FinancialInstitutionValidator
    {
        private ValidationResult _result = new ValidationResult();
        private IAsyncRepository<FinancialInstitution> _repo;
        public FinancialInstitutionValidator(IAsyncRepository<FinancialInstitution> repo)
        {
            _repo = repo;
        }
        public async Task<ValidationResult> Validate(FinancialInstitutionDTO dto, int? id = null)
        {
            // if more constraints change in future uniqueSpec to be generalized
            var uniqueSpecification = new FinancialInstitutionValidationSpecification(dto.Name, id);
            var isNameInUse = await _repo.AnyAsync(uniqueSpecification);
            if (isNameInUse)
            {
                _result.AddError(nameof(dto.Name), "That institution already exists.");
            }
            return _result;
        }

    }
}
