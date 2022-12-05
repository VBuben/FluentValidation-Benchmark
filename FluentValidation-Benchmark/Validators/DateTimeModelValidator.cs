using FluentValidation;
using FluentValidation_Benchmark.Dtos;

namespace FluentValidation_Benchmark.Validators;

public class DateTimeModelValidator : AbstractValidator<DateTimeModel>
{
    public readonly DateTime MinimumDateTime = new DateTime(1, 1, 1);
    public readonly DateTime MaximumDateTime = new DateTime(3000, 1, 1);
    
    public DateTimeModelValidator()
    {
        RuleFor(x => x.DateTimeProperty1).NotNull().LessThan(MinimumDateTime).GreaterThan(MaximumDateTime);
        RuleFor(x => x.DateTimeProperty2).NotNull().LessThan(MinimumDateTime).GreaterThan(MaximumDateTime);
        RuleFor(x => x.DateTimeProperty3).NotNull().LessThan(MinimumDateTime).GreaterThan(MaximumDateTime);
        RuleFor(x => x.DateTimeProperty4).NotNull().LessThan(MinimumDateTime).GreaterThan(MaximumDateTime);
        RuleFor(x => x.DateTimeProperty5).NotNull().LessThan(MinimumDateTime).GreaterThan(MaximumDateTime);
        RuleFor(x => x.DateTimeProperty6).NotNull().LessThan(MinimumDateTime).GreaterThan(MaximumDateTime);
        RuleFor(x => x.DateTimeProperty7).NotNull().LessThan(MinimumDateTime).GreaterThan(MaximumDateTime);
        RuleFor(x => x.DateTimeProperty8).NotNull().LessThan(MinimumDateTime).GreaterThan(MaximumDateTime);
        RuleFor(x => x.DateTimeProperty9).NotNull().LessThan(MinimumDateTime).GreaterThan(MaximumDateTime);
        RuleFor(x => x.DateTimeProperty10).NotNull().LessThan(MinimumDateTime).GreaterThan(MaximumDateTime);
    }
}