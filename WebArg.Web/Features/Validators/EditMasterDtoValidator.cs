using FluentValidation;
using WebArg.Web.Features.DtoModels.Master;

namespace WebArg.Web.Features.Validators;

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
