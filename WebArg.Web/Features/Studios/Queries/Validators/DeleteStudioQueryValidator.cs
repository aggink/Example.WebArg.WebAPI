using FluentValidation;

namespace WebArg.Web.Features.Studios.Queries.Validators;

public sealed class DeleteStudioQueryValidator : AbstractValidator<DeleteStudioQuery>
{
    public DeleteStudioQueryValidator()
    {
        RuleFor(x => x.IsnStudio)
            .NotEmpty();
    }
}
