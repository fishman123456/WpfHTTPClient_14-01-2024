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

namespace WpfHTTPClient_14_01_2024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            //HtttpClint.messageAPI.ToString();
            textBoxData.Text = string.Empty;
        }

        private void ButtUpdate_Click(object sender, RoutedEventArgs e)
        {
            HtttpClint Clint = new HtttpClint();
            Clint.httpClient();
            textBoxData.Text = Clint.messageAPI.ToString();
        }
    }
}