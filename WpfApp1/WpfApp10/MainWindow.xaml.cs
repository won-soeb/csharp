﻿using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApp10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InputMethod.SetIsInputMethodEnabled(this.txt1, false);
        }
            
        private void txt1_KeyDown(object sender, KeyEventArgs e)
        {
            Key inputKey = e.Key.Equals(Key.ImeProcessed) ? e.ImeProcessedKey : e.Key;
            if (inputKey == Key.Escape) Close();
        }

        private void txt2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1)) e.Handled = true;
        }

        private void txt2_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.Equals(Key.ImeProcessed))
            {
                e.Handled = true;
            }
            if (e.Key.Equals(Key.Escape)) Close();
        }
    }
}
