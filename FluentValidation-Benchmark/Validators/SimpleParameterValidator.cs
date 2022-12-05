using FluentValidation;
using FluentValidation_Benchmark.Dtos;

namespace FluentValidation_Benchmark.Validators;

public class SimpleParameterValidator : AbstractValidator<SimpleParameter>
{
    public SimpleParameterValidator()
    {
        RuleFor(x => x.Ids).NotEmpty().Must(x => x.Count is > 0 and <= 1000).DependentRules(() =>
        {
            RuleFor(x => x.StringModel).SetValidator(new StringModelValidator());
            RuleFor(x => x.IntModel).SetValidator(new IntModelValidator());
            RuleFor(x => x.DateTimeModel).SetValidator(new DateTimeModelValidator());
        });
    }
}