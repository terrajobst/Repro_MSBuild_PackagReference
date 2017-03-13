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
            var text = new Class1().ToString();
            MessageBox.Show(text);
        }
    }
}
