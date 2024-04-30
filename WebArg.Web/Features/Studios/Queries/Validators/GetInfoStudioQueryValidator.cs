using FluentValidation;

namespace WebArg.Web.Features.Studios.Queries.Validators;

public sealed class GetInfoStudioQueryValidator : AbstractValidator<GetInfoStudioQuery>
{
    public GetInfoStudioQueryValidator()
    {
        RuleFor(x => x.IsnStudio)
            .NotEmpty();
    }
}
