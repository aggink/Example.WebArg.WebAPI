using FluentValidation;

namespace WebArg.Web.Features.Persons.Queries.Validators;

public sealed class GetInfoPersonQueryValidator : AbstractValidator<GetInfoPersonQuery>
{
    public GetInfoPersonQueryValidator()
    {
        RuleFor(x => x.IsnPerson)
            .NotEmpty();
    }
}
