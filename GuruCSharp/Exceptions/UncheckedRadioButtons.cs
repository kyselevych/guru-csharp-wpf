using System;

namespace GuruCSharp.Exceptions;

public class UncheckedRadioButton : Exception
{
    public UncheckedRadioButton() {}
    
    public UncheckedRadioButton(string? message): base(message) {}
}