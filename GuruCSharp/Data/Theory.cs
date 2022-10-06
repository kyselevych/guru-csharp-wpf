using GuruCSharp.Interfaces;

namespace GuruCSharp.Data;

public class Theory : IOrderly
{
    public string Text { get; set; } = string.Empty;
    
    public int Order { get; set; }
}