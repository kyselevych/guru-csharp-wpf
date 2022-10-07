using System;

namespace GuruCSharp.Interfaces;

public interface ICodeTest : IQuestion, IOrderly
{
    public string Text { get; set; }

    public bool Check<T, TOut>(string code, Func<T, TOut> func);
}