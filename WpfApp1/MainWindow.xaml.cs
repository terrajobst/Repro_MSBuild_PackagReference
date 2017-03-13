using System.Windows;
using ClassLibrary;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var token = Class1.Create();
            var text = token.ToString();
            MessageBox.Show(text);
        }
    }
}
