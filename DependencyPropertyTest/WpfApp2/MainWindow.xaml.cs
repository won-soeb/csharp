﻿using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        RadialGradientBrush brush;
        double angle;
        DispatcherTimer tmr;

        public MainWindow()
        {
            InitializeComponent();

            Title = "Rotate the Gradiant Origin";
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Width = 384;
            Height = 384;

            brush = new RadialGradientBrush(Colors.White, Colors.Blue);
            brush.Center = brush.GradientOrigin = new Point(0.5, 0.5);
            brush.RadiusX = brush.RadiusY = 0.10;
            brush.SpreadMethod = GradientSpreadMethod.Repeat;
            Background = brush;

            tmr = new DispatcherTimer();
            tmr.Interval = TimeSpan.FromMilliseconds(100);
            tmr.Tick += TimerOnTick;
            tmr.Start();
        }
        void TimerOnTick(object sender, EventArgs args)
        {
            Point pt = new Point(0.5 + 0.05 * Math.Cos(angle), 0.5 + 0.05 * Math.Sin(angle));
            brush.GradientOrigin = pt;
            angle += Math.PI / 6;
        }
        protected override void OnMouseDown(MouseButtonEventArgs args)
        {
            tmr.Stop();
        }
    }
}
