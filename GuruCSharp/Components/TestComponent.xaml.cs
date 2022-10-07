using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using GuruCSharp.Data;
using GuruCSharp.Exceptions;
using GuruCSharp.Interfaces;

namespace GuruCSharp.Components;

public partial class TestComponent : UserControl, IVerifiable
{
    private readonly Test test;
    private List<RadioButton> RadioButtons { get; } = new();

    public TestComponent(Test test)
    {
        this.test = test;

        InitializeComponent();
        InitializeData();
    }

    private void InitializeData()
    {
        TextBlock.Text = test.Text;

        foreach (var variant in test.Variants)
        {
            var radioButton = new RadioButton
            {
                Content = variant.Text,
                Tag = variant.IsAnswer,
                Margin = new Thickness(0, 0, 0, 10),
                FontSize = 20,
                VerticalContentAlignment = VerticalAlignment.Center
            };

            Wrapper.Children.Add(radioButton);
            RadioButtons.Add(radioButton);
        }
    }

    public bool IsRightAnswer()
    {
        foreach (var radioButton in RadioButtons)
        {
            if (radioButton.IsChecked != true) continue;

            return (bool)radioButton.Tag;
        }

        throw new UncheckedRadioButton();
    }
}