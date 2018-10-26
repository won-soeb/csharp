using System.Windows;
using System.Diagnostics;

namespace Wpfapp1
{
    public partial class DPTest : DependencyObject
    {
        public static readonly DependencyProperty TestProperty = DependencyProperty.Register(
            "Test",
            typeof(string),
            typeof(DPTest),
            new PropertyMetadata("안녕 홍길동", OnTestPropertyChanged));

        public string Test
        {
            get
            {
                Debug.WriteLine("Test GetValue");
                return (string)GetValue(TestProperty);
            }
            set
            {
                Debug.WriteLine("Test SetValue");
                SetValue(TestProperty, value);
            }
        }
        private static void OnTestPropertyChanged(DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("Property Changed : {0}", e.NewValue);
        }        
    }
}
