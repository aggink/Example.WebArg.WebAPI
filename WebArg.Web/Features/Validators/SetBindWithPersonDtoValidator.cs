using FluentValidation;
using WebArg.Web.Features.DtoModels.Master;

namespace WebArg.Web.Features.Validators;

public sealed class SetBindWithPersonDtoValidator : AbstractValidator<SetBindWithPersonDto>
{
    public SetBindWithPersonDtoValidator()
    {
        RuleFor(x => x.IsnMaster)
            .NotEmpty();

        RuleFor(x => x.IsnPerson)
            .NotEmpty();
    }
}
