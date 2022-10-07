using System;
using GuruCSharp.Interfaces;

namespace GuruCSharp.Data;

public class CodeTest: IQuestion, IOrderly
{
    public string Text { get; set; } = string.Empty;
    
    public int Order { get; set; }

    public bool Check<T, TOut>(string code, Func<T, TOut> func)
    {
        return true;
    }
}