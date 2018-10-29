using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Statusbar
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
            int col = txtEditor.CaretIndex - txtEditor.GetLineIndexFromCharacterIndex(row);
            lblCursorPosition.Text = "Line " + (row + 1) + ", Char "+ (col + 1);
        }
    }
}
