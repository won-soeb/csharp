﻿using SelectColorFromGrid;//여긴 이게 있어야 한다
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace XamlCustomClass
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void ColorGridBoxOnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            ColorGridBox clrbox = args.Source as ColorGridBox;
            Background = (Brush)clrbox.SelectedValue;
        }
    }
}
