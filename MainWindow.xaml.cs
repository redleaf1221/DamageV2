using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DamageV2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String CurrentVersion = "1.8";
        String CurrentMode = "Average";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void About_Click(object sender, RoutedEventArgs e) {
            About.Header = "By MathTangent";
            Action<MenuItem> action = async (MenuItem about) => {
                await Task.Delay(500);
                about.Header = "About";
            };
            About.Dispatcher.BeginInvoke(action, About);
        }

        private void ChangeVersion_Click(object sender, RoutedEventArgs e) {
            if (CurrentVersion == "1.8") {
                CurrentVersion = "1.9";
                ChangeVersion.Content = "Current Version: 1.9";
            } else if (CurrentVersion == "1.9") {
                CurrentVersion = "1.8";
                ChangeVersion.Content = "Current Version: 1.8";
            } else {
                throw new Exception("How do we get there? Wrong version.");
            }
            return;
        }

        private void ChangeMode_Click(object sender, RoutedEventArgs e) {
            if(CurrentMode == "Average") {
                CurrentMode = "DPS";
                ChangeMode.Content = "Current Mode: DPS";
            } else if(CurrentMode == "DPS") {
                CurrentMode = "Max";
                ChangeMode.Content = "Current Mode: Max Damage";
            } else if(CurrentMode == "Max") {
                CurrentMode = "Average";
                ChangeMode.Content = "Current Mode: Average Damage";
            } else {
                throw new Exception("How do we get there? Wrong mode.");
            }
            return;
        }
    }
}