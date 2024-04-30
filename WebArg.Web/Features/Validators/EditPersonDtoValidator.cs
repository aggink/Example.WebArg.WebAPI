using FluentValidation;
using WebArg.Web.Features.DtoModels.Person;

namespace WebArg.Web.Features.Validators;

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
