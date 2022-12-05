using FluentValidation;
using FluentValidation_Benchmark.Dtos;

namespace FluentValidation_Benchmark.Validators;

public class MultipleSimpleParametersValidator : AbstractValidator<MultipleSimpleParameters>
{
    public MultipleSimpleParametersValidator()
    {
        RuleFor(x => x.Parameters)
            .NotEmpty()
            .Must(x => x.Count is > 0 and <= 1000)
            .ForEach(p => p.SetValidator(new SimpleParameterValidator()));

            // Everything that is in SimpleParameterValidator can be achieved in ChildRules 
            // .ChildRules(parameters =>
            // {
            //     parameters.RuleFor()
            // });
    }
}