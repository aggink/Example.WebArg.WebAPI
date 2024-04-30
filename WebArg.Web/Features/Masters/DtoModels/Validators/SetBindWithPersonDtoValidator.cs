using FluentValidation;

namespace WebArg.Web.Features.Masters.DtoModels.Validators;

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
