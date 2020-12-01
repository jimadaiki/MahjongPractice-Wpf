using MahjongPractice.ViewModels;
using System.Linq;
using System.Windows;

namespace MahjongPractice.Views
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel mainWindowViewModel;
        public MainWindow()
        {
            InitializeComponent();
            mainWindowViewModel = (MainWindowViewModel)DataContext;
        }

        void OnShuffleButtonClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new MainWindowViewModel();
        }
    }
}
