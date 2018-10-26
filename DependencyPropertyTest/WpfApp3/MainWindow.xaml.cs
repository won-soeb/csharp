﻿using System.Windows;
using System.Windows.Input;
using System.Text;
namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        StringBuilder s;

        public MainWindow()
        {
            InitializeComponent();

            Title = "사용자 입력을 Window의 Content속성에 매핑하기";
            s = new StringBuilder("");
            Content = s;
        }
        protected override void OnTextInput(TextCompositionEventArgs args)
        {
            string str = Content.ToString();

            if (args.Text == "\b")
            {
                if (str.Length > 0)
                    s.Remove(s.Length - 1, 1);
            }
            else
            {
                s.Append(args.Text);
            }
            Content = null;
            Content = s;
        }
    }
}
