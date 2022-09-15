using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{       //flued validation rules.
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            RuleFor(p=>p.DailyPrice).GreaterThanOrEqualTo(200000).When(p=>p.BrandId==2);
            RuleFor(p => p.Description).NotEmpty();
        }
    }
}
