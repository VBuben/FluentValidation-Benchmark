using FluentValidation_Benchmark.Helpers;
using FluentValidation_Benchmark.Validators;
using FluentValidation.Results;

namespace FluentValidation_Benchmark.Dtos;

public class IntModel
{
    public int IntProperty1 => RandomGenerator.RandomInt();

    public int IntProperty2 => RandomGenerator.RandomInt();
    
    public int IntProperty3 => RandomGenerator.RandomInt();
    
    public int IntProperty4 => RandomGenerator.RandomInt();
    
    public int IntProperty5 => RandomGenerator.RandomInt();
    
    public int IntProperty6 => RandomGenerator.RandomInt();
    
    public int IntProperty7 => RandomGenerator.RandomInt();
    
    public int IntProperty8 => RandomGenerator.RandomInt();
    
    public int IntProperty9 => RandomGenerator.RandomInt();
    
    public int IntProperty10 => RandomGenerator.RandomInt();
    
    public ValidationResult Validate()
    {
        var validator = new IntModelValidator();
        var validationResult = validator.Validate(this);

        return validationResult;
    }
}