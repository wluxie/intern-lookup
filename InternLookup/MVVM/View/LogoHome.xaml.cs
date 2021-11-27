using System.Diagnostics;
using System.Windows.Controls;

namespace InternLookup.MVVM.View
{
    /// <summary>
    /// Interaction logic for LogoHome.xaml
    /// </summary>
    public partial class LogoHome : UserControl
    {
        public LogoHome()
        {
            InitializeComponent();
        }

        private void Git_Button(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenLink("https://github.com/wluxie/InternLookup");
        }

        private void Linkedin_Button(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenLink("https://www.linkedin.com/in/jasperdoan");
        }

        private void Contact_Button(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenLink("mailto:wluxdoan@gmail.com");
        }

        private void OpenLink(string fileName) 
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = fileName,
                UseShellExecute = true
            });
        }
    }
}
