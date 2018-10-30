using System.Windows;
using System.Windows.Controls;

namespace WpfApp19
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOnClick(object sender, RoutedEventArgs e)
        {
            Button btn = e.Source as Button;
            MessageBox.Show(btn.Content + " has been clicked", Title);
        }
    }
}
