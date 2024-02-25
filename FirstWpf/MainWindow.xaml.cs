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

namespace FirstWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // custom properties, events, fields...
        public MainWindow()
        {
            InitializeComponent();

            var btn = new Button()
            {
                Width = 200,
                Foreground = Brushes.Beige
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello WPF!", "Hi", MessageBoxButton.OKCancel, MessageBoxImage.Information, MessageBoxResult.OK);
        }

        // custom methods, event handlers...
    }
}