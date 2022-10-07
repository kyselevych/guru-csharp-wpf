using System.Windows;
using GuruCSharp.Pages;
using GuruCSharp.Sections;

namespace GuruCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new MainPage();
        }

        public void SetPage(object content)
        {
            Main.Content = content;
        }
    }
}