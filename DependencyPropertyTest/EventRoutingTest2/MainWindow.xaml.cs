using System.Windows;
namespace EventRoutingTest2
{
    public partial class MainWindow : Window
    {
        string mouseActivity = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            mouseActivity = "PreviewMouseDown Window \n";
            MessageBox.Show(mouseActivity);
        }

        private void StackPanel_PreviewMouseDown(object sender, RoutedEventArgs e)
        {
            mouseActivity = "PreviewMouseDown StackPanel \n";
            MessageBox.Show(mouseActivity);
        }

        private void Button_PreviewMouseDown(object sender, RoutedEventArgs e)
        {
            mouseActivity = "PreviewMouseDown Button \n";
            MessageBox.Show(mouseActivity);
        }
    }
}
