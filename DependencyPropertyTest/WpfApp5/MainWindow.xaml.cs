using System.Windows;
namespace WpfApplication9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OnClicked(object sender, RoutedEventArgs args)
        {            
        Emp e = Grid1.DataContext as Emp;
            System.Console.WriteLine(e.Ename);
            System.Console.WriteLine(e.City);
        }
    }
}