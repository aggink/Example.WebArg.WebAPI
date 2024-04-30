using FluentValidation;

namespace WebArg.Web.Features.Studios.DtoModels.Validators;

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
