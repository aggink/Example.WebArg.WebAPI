using FluentValidation;
using WebArg.Web.Features.DtoModels.Studio;

namespace WebArg.Web.Features.Validators;

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
