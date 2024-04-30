using FluentValidation;

namespace WebArg.Web.Features.Studios.DtoModels.Validators;

public sealed class SetBindWithMasterDtoValidator : AbstractValidator<SetBindWithMasterDto>
{
    public SetBindWithMasterDtoValidator()
    {
        RuleFor(x => x.IsnStudio)
            .NotEmpty();

        RuleFor(x => x.IsnMaster)
            .NotEmpty();
    }
}
