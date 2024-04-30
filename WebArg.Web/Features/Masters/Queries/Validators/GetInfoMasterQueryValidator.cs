using FluentValidation;

namespace WebArg.Web.Features.Masters.Queries.Validators;

public sealed class GetInfoMasterQueryValidator : AbstractValidator<GetInfoMasterQuery>
{
    public GetInfoMasterQueryValidator()
    {
        RuleFor(x => x.IsnMaster)
            .NotEmpty();
    }
}
