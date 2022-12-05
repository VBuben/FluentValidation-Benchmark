using FluentValidation;
using FluentValidation_Benchmark.Dtos;

namespace FluentValidation_Benchmark.Validators;

public class IntModelValidator : AbstractValidator<IntModel>
{
    public IntModelValidator()
    {
        RuleFor(x => x.IntProperty1).NotNull().GreaterThanOrEqualTo(0).LessThanOrEqualTo(2147483647);
        RuleFor(x => x.IntProperty2).NotNull().GreaterThanOrEqualTo(0).LessThanOrEqualTo(2147483647);
        RuleFor(x => x.IntProperty3).NotNull().GreaterThanOrEqualTo(0).LessThanOrEqualTo(2147483647);
        RuleFor(x => x.IntProperty4).NotNull().GreaterThanOrEqualTo(0).LessThanOrEqualTo(2147483647);
        RuleFor(x => x.IntProperty5).NotNull().GreaterThanOrEqualTo(0).LessThanOrEqualTo(2147483647);
        RuleFor(x => x.IntProperty6).NotNull().GreaterThanOrEqualTo(0).LessThanOrEqualTo(2147483647);
        RuleFor(x => x.IntProperty7).NotNull().GreaterThanOrEqualTo(0).LessThanOrEqualTo(2147483647);
        RuleFor(x => x.IntProperty8).NotNull().GreaterThanOrEqualTo(0).LessThanOrEqualTo(2147483647);
        RuleFor(x => x.IntProperty9).NotNull().GreaterThanOrEqualTo(0).LessThanOrEqualTo(2147483647);
        RuleFor(x => x.IntProperty10).NotNull().GreaterThanOrEqualTo(0).LessThanOrEqualTo(2147483647);
    }
}