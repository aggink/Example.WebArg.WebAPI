using FluentValidation;

namespace WebArg.Web.Features.Masters.Queries.Validators;

public sealed class DeleteMasterQueryValidator : AbstractValidator<DeleteMasterQuery>
{
    public DeleteMasterQueryValidator()
    {
        RuleFor(x => x.IsnMaster)
            .NotEmpty();
    }
}
