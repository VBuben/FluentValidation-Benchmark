using BenchmarkDotNet.Attributes;
using FluentValidation_Benchmark.Validators;
using FluentValidation.Results;

namespace FluentValidation_Benchmark.Dtos;

public class SimpleParameter
{
    public SimpleParameter()
    {
        StringModel = new StringModel();
        IntModel = new IntModel();
        DateTimeModel = new DateTimeModel();

        var ids = new List<Guid>();
        for (var i = 0; i < 1000; i++)
        {
            ids.Add(Guid.NewGuid());            
        }

        Ids = ids;
    }
    
    public ICollection<Guid> Ids { get; set; }

    public StringModel StringModel { get; set; }
    
    public IntModel IntModel { get; set; }
    
    public DateTimeModel DateTimeModel { get; set; }

}