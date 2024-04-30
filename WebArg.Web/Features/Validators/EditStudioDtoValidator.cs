using FluentValidation;
using WebArg.Web.Features.DtoModels.Studio;

namespace WebArg.Web.Features.Validators;

public sealed class EditStudioDtoValidator : AbstractValidator<EditStudioDto>
{
    public EditStudioDtoValidator()
    {
        RuleFor(x => x.IsnNode)
            .NotEmpty();

        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.Location)
            .NotEmpty()
            .MaximumLength(100);
    }
}
