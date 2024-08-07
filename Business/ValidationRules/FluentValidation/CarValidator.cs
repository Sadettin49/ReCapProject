using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            //RuleFor(p =>p.ProductName).NotEmpty();
            //RuleFor(p =>p.ProductName).MinimumLength(2);
            //RuleFor(p =>p.UnitPrice).NotEmpty();
            //RuleFor(p =>p.UnitPrice).GreaterThan(0);
            RuleFor(p =>p.BrandId).GreaterThanOrEqualTo(10).When(p=>p.Id==1).WithMessage("deneme kodu");
            //RuleFor(p => p.CarName).Must(UpperCaseOrLowerCase).WithMessage("Ürünler büyük küçük harf duyarlı");
            //RuleFor(p => p.CarName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");



        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}

        private bool UpperCaseOrLowerCase(string arg)
        {
          return arg.StartsWith("A") || arg.StartsWith("a");
            
        }
    }
}