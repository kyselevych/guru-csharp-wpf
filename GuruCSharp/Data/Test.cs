using System.Collections.Generic;
using GuruCSharp.Interfaces;

namespace GuruCSharp.Data;

public class Test : IQuestion, IOrderly
{
    public string Text { get; set; } = string.Empty;
    
    public int Order { get; set; }

    public List<TestVariant> Variants { get; set; } = new();
}