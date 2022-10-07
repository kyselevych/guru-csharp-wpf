using System.Collections.Generic;
using GuruCSharp.Data;

namespace GuruCSharp.Interfaces;

public interface ITest : IQuestion, IOrderly
{
    public string Text { get; set; }
    
    public List<TestVariant> Variants { get; set; }
}