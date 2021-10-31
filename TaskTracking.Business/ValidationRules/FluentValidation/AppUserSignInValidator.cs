using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using TaskTracking.DTO.DTOs.AppUserDtos;

namespace TaskTracking.Business.ValidationRules.FluentValidation
{
    public class AppUserSignInValidator : AbstractValidator<AppUserSignInDto>
    {
        public AppUserSignInValidator()
        {
            RuleFor(I => I.UserName).NotNull().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(I => I.Password).NotNull().WithMessage("Şifre alanı boş geçilemez");
        }
    }
}
