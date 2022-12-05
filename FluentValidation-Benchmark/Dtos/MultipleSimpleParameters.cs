using BenchmarkDotNet.Attributes;
using FluentValidation_Benchmark.Validators;
using FluentValidation.Results;

namespace FluentValidation_Benchmark.Dtos;

public class MultipleSimpleParameters
{
    public ICollection<SimpleParameter> Parameters { get; set; }

    [Params(100, 500, 1000, 2500, 5000)]
    public int N;
    
    [GlobalSetup]
    public void Setup()
    {
        Parameters = GenerateParameters(N);
    }
    
    [Benchmark]
    public ValidationResult Validation()
    {
        var validator = new MultipleSimpleParametersValidator();
        var validationResult = validator.Validate(this);
        return validationResult;
    }
    
    public ICollection<SimpleParameter> GenerateParameters(int parameterCount)
    {
        var parameters = new List<SimpleParameter>();
        
        for (int i = 0; i < parameterCount; i++)
        {
            parameters.Add(new SimpleParameter());
        }

        return parameters;
    }
}