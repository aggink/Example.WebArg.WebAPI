using FluentValidation;

namespace WebArg.Web.Features.Studios.Queries.Validators;

public sealed class GetEditStudioQueryValidator : AbstractValidator<GetEditStudioQuery>
{
    public GetEditStudioQueryValidator()
    {
        RuleFor(x => x.IsnStudio)
            .NotEmpty();
    }
}
