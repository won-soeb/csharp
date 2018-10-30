using System.Windows;
namespace WpfApplication9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void passwordBox1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Password changed");
        }
 private void Logon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(pwd.SecurePassword.Length.ToString());
            MessageBox.Show(pwd.Password);
        }
    }
}