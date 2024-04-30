using FluentValidation;

namespace WebArg.Web.Features.Masters.Queries.Validators;

public sealed class GetEditMasterQueryValidator : AbstractValidator<GetEditMasterQuery>
{
    public GetEditMasterQueryValidator()
    {
        RuleFor(x => x.IsnMaster)
            .NotEmpty();
    }
}
