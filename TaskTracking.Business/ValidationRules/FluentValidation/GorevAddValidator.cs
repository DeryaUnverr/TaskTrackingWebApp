using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using TaskTracking.DTO.DTOs.GorevDtos;

namespace TaskTracking.Business.ValidationRules.FluentValidation
{
    public class GorevAddValidator : AbstractValidator<GorevAddDto>
    {

        public GorevAddValidator()
        {
            RuleFor(I => I.Ad).NotNull().WithMessage("Ad alanı gereklidir");
            RuleFor(I => I.AciliyetId).ExclusiveBetween(0, int.MaxValue).WithMessage("Lütfen bir aciliyet durumu seçiniz");
        }
    }
}
