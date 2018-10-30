using System.Windows;
namespace WpfApp24
{
    public partial class DataObject
    {
        public int TheValue { get; set; }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new DataObject();
        }
    }
}
