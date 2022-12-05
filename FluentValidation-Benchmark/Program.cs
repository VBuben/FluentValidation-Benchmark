using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using FluentValidation_Benchmark.Dtos;
using FluentValidation_Benchmark.Validators;
using FluentValidation;

public class Program
{
    public static void Main(string[] arg)
    {
        var results = BenchmarkRunner.Run<MultipleSimpleParameters>();
    }
}