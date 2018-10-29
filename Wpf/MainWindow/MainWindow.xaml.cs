﻿using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace DataBindingSortExam
{
    public partial class MainWindow : Window
    {
        public ListCollectionView MyCollectionView;
        public Emp emp;

        public MainWindow()
        {
            InitializeComponent();
        }
        public void DCChange(object sender, DependencyPropertyChangedEventArgs args)
        {
            MyCollectionView = (ListCollectionView)CollectionViewSource.GetDefaultView(rootElement.DataContext);
        }
        private void OnClick(object sender, RoutedEventArgs e)
        {
            var b = sender as Button;
            MyCollectionView.SortDescriptions.Clear();
            switch (b.Name)
            {
                case "BtnEmpno":
                    MyCollectionView.SortDescriptions.Add(new SortDescription("Empno", ListSortDirection.Ascending));
                    break;
                case "BtnEname":
                    MyCollectionView.SortDescriptions.Add(new SortDescription("BtnEname", ListSortDirection.Ascending));
                    break;
                case "BtnJob":
                    MyCollectionView.SortDescriptions.Add(new SortDescription("BtnJob", ListSortDirection.Ascending));
                    break;
            }
        }
        private void OnMove(object sender, RoutedEventArgs e)
        {
            var b = sender as Button;
            switch (b.Name)
            {
                case "Previous":
                    if (MyCollectionView.MoveCurrentToPrevious())
                        emp = MyCollectionView.CurrentAddItem as Emp;
                    else
                        MyCollectionView.MoveCurrentToFirst();
                    break;
                case "Next":
                    if (MyCollectionView.MoveCurrentToNext())
                        emp = MyCollectionView.CurrentAddItem as Emp;
                    else
                        MyCollectionView.MoveCurrentToLast();
                    break;
            }
        }
        private void OnFilter(object sender, RoutedEventArgs e)
        {
            var b = sender as Button;
            switch (MyCollectionView.Filter)
            {
                case null: MyCollectionView.Filter = Ismanager; break;
                default:MyCollectionView.Filter = null; break;
            }
        }
        private bool Ismanager(object o)
        {
            var e = o as Emp;
            return e?.Job == "Manager";
        }
    }
}
