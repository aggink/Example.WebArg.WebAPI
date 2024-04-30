using FluentValidation;

namespace WebArg.Web.Features.Persons.DtoModels.Validators;

public sealed class EditPersonDtoValidator : AbstractValidator<EditPersonDto>
{
    public EditPersonDtoValidator()
    {
        RuleFor(x => x.IsnNode)
            .NotEmpty();

        RuleFor(x => x.IsnStudio)
            .NotEmpty();

        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.LastVisit)
            .NotEmpty();
    }
}
