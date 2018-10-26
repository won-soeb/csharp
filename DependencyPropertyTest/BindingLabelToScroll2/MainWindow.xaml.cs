using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Controls.Primitives;

namespace BindingLabelToScroll2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Binding bind = new Binding();
            bind.Source = scrollbar;
            bind.Path = new PropertyPath(ScrollBar.ValueProperty);
            lable.SetBinding(Label.ContentProperty, bind);
        }
    }
}
