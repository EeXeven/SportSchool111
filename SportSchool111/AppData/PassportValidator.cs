using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SportSchool111.Model;

public class PassportValidator : AbstractValidator<Students>
{
    public PassportValidator()
    {
        RuleFor(x => x.PassportNumber)
            .NotEmpty().WithMessage("Поле паспорта должно быть заполнено")
            .Matches(@"^\d{2} \d{2} \d{6}$").WithMessage("Неверный формат паспорта");
    }
}


}
