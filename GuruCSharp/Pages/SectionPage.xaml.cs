using System.Windows.Controls;
using GuruCSharp.Sections;

namespace GuruCSharp.Pages;

public partial class SectionPage : Page
{
    private readonly Section section;
    public SectionPage(Section section)
    {
        this.section = section;
        
        InitializeComponent();
    }
}