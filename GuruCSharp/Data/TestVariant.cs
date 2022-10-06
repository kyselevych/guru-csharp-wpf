using GuruCSharp.Interfaces;

namespace GuruCSharp.Data;

public class TestVariant : ITestVariant
{
    public string Text { get; set; } = string.Empty;

    public bool IsAnswer { get; set; }
}