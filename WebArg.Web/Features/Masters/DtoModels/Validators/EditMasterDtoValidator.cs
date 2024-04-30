using FluentValidation;

namespace WebArg.Web.Features.Masters.DtoModels.Validators;

public sealed class EditMasterDtoValidator : AbstractValidator<EditMasterDto>
{
    public EditMasterDtoValidator()
    {
        RuleFor(x => x.IsnNode)
            .NotEmpty();

        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.Qualification)
            .NotEmpty()
            .MaximumLength(100);
    }
}
