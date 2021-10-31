using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using TaskTracking.DTO.DTOs.RaporDtos;

namespace TaskTracking.Business.ValidationRules.FluentValidation
{
    public class RaporUpdateValidator : AbstractValidator<RaporUpdateDto>
    {
        public RaporUpdateValidator()
        {
            RuleFor(I => I.Tanim).NotNull().WithMessage("Tanım alanı boş geçilemez");
            RuleFor(I => I.Detay).NotNull().WithMessage("Detay alanı boş geçilemez");
        }
    }
}
