using System.Windows;

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
            var s = new LoopSection();
        }
    }
}