using FluentValidation;

namespace WebArg.Web.Features.Persons.Queries.Validators;

public sealed class DeleteРersonQueryValidator : AbstractValidator<DeleteРersonQuery>
{
    public DeleteРersonQueryValidator()
    {
        RuleFor(x => x.IsnPerson)
            .NotEmpty();
    }
}
