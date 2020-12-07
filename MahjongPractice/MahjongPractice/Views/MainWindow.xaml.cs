using MahjongPractice.Models;
using MahjongPractice.ViewModels;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MahjongPractice.Views
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel mainWindowViewModel;
        int lastSelectedIndex = -1;
        
        public MainWindow()
        {
            InitializeComponent();
            mainWindowViewModel = (MainWindowViewModel)DataContext;
        }

        void OnMouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (mainWindowViewModel.Finished)
                return;
            if (listBox.SelectedIndex == -1)
                return;
            if (lastSelectedIndex == listBox.SelectedIndex)
                Put(listBox.SelectedIndex);
            lastSelectedIndex = listBox.SelectedIndex;     
        }

        void Put(int index)
        {
            mainWindowViewModel.Put(index);
            if (mainWindowViewModel.Finished)
                nextGameButtonClicked.Visibility = Visibility.Visible;
        }

        void OnNextGameButtonClicked(object sender, RoutedEventArgs e)
        {
            mainWindowViewModel = new MainWindowViewModel();
            DataContext = mainWindowViewModel;
            nextGameButtonClicked.Visibility = Visibility.Hidden;
        }
    }
}
