using FluentValidation;

namespace WebArg.Web.Features.Persons.Queries.Validators;

public sealed class GetEditPersonQueryValidator : AbstractValidator<GetEditPersonQuery>
{
    public GetEditPersonQueryValidator()
    {
        RuleFor(x => x.IsnPerson)
            .NotEmpty();
    }
}
