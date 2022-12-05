using FluentValidation;
using FluentValidation_Benchmark.Dtos;

namespace FluentValidation_Benchmark.Validators;

public class StringModelValidator : AbstractValidator<StringModel>
{
    public StringModelValidator()
    {
        RuleFor(x => x.StringProperty1).NotEmpty().MinimumLength(0).MaximumLength(255);
        RuleFor(x => x.StringProperty2).NotEmpty().MinimumLength(0).MaximumLength(255);
        RuleFor(x => x.StringProperty3).NotEmpty().MinimumLength(0).MaximumLength(255);
        RuleFor(x => x.StringProperty4).NotEmpty().MinimumLength(0).MaximumLength(255);
        RuleFor(x => x.StringProperty5).NotEmpty().MinimumLength(0).MaximumLength(255);
        RuleFor(x => x.StringProperty6).NotEmpty().MinimumLength(0).MaximumLength(255);
        RuleFor(x => x.StringProperty7).NotEmpty().MinimumLength(0).MaximumLength(255);
        RuleFor(x => x.StringProperty8).NotEmpty().MinimumLength(0).MaximumLength(255);
        RuleFor(x => x.StringProperty9).NotEmpty().MinimumLength(0).MaximumLength(255);
        RuleFor(x => x.StringProperty10).NotEmpty().MinimumLength(0).MaximumLength(255);
    }
}