﻿using System.Linq;
using System.Windows;

namespace MahjongPractice.Views
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            itemsControl.ItemsSource = Enumerable.Range(1, 13);
        }
    }
}
