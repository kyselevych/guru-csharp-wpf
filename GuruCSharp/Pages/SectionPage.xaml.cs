using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using GuruCSharp.Components;
using GuruCSharp.Data;
using GuruCSharp.Exceptions;
using GuruCSharp.Interfaces;
using GuruCSharp.Sections;

namespace GuruCSharp.Pages;

public partial class SectionPage : Page
{
    private readonly Section section;
    private readonly IEnumerator<object> sectionEnumerator;

    public SectionPage(Section section)
    {
        this.section = section;
        sectionEnumerator = section.GetEnumerator();
        
        InitializeComponent();
        ShowNextSlideOfSection();
    }
    
    private void ButtonNext_OnClick(object sender, RoutedEventArgs e)
    {
        if (Wrapper.Content is IVerifiable verifiable)
        {
            try
            {
                HandleAnswer(verifiable);
            }
            catch (UncheckedRadioButton)
            {
                MessageBox.Show("Оберіть варіант відповіді!");
                return;
            }
        }
        
        ShowNextSlideOfSection();
    }

    private void ShowNextSlideOfSection()
    {
        if (sectionEnumerator.MoveNext())
        {
            var obj = ((KeyValuePair<int, object>) sectionEnumerator.Current).Value;
            
            if (obj is Test test)
            {
                Wrapper.Content = new TestComponent(test);
            }
            else if (obj is Theory theory)
            {
                //TextBlock.Text = theory.Text;
            }
            else if (obj is CodeTest codeTest)
            {
                //TextBlock.Text = codeTest.Text;
            }
        }
    }

    private void HandleAnswer(IVerifiable verifiable)
    {
        if (verifiable.IsRightAnswer())
            section.CurrentPoints += 1;
    }
}