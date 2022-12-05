using BenchmarkDotNet.Attributes;
using FluentValidation_Benchmark.Helpers;
using FluentValidation_Benchmark.Validators;
using FluentValidation.Results;

namespace FluentValidation_Benchmark.Dtos;

public class StringModel
{
    [Params(10, 25, 50, 100)]
    public int Length { get; set; }
    
    public string StringProperty1 => RandomGenerator.RandomString(Length);

    public string StringProperty2 => RandomGenerator.RandomString(Length);
    
    public string StringProperty3 => RandomGenerator.RandomString(Length);
    
    public string StringProperty4 => RandomGenerator.RandomString(Length);
    
    public string StringProperty5 => RandomGenerator.RandomString(Length);
    
    public string StringProperty6 => RandomGenerator.RandomString(Length);
    
    public string StringProperty7 => RandomGenerator.RandomString(Length);
    
    public string StringProperty8 => RandomGenerator.RandomString(Length);
    
    public string StringProperty9 => RandomGenerator.RandomString(Length);
    
    public string StringProperty10 => RandomGenerator.RandomString(Length);
    
    public ValidationResult Validate()
    {
        var validator = new StringModelValidator();
        var validationResult = validator.Validate(this);

        return validationResult;
    }
}