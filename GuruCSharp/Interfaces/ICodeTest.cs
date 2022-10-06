using System;

namespace GuruCSharp.Interfaces;

public interface ICodeTest
{
    public string Text { get; set; }

    public bool Check<T, TOut>(string code, Func<T, TOut> func);
}