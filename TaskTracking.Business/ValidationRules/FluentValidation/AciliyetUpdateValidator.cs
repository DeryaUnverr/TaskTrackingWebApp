using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using TaskTracking.DTO.DTOs.AciliyetDtos;

namespace TaskTracking.Business.ValidationRules.FluentValidation
{
    public class AciliyetUpdateValidator : AbstractValidator<AciliyetUpdateDto>
    {
        public AciliyetUpdateValidator()
        {
            RuleFor(I => I.Tanim).NotNull().WithMessage("Tanım alanı boş geçilemez");
        }
    }
}
