using BookMarket.Pages;
using BookMarket.Scripts;
using System.Windows;

namespace BookMarket
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameClass.fr = MainFrame;
            FrameClass.fr.Navigate(new MainMarket());
        }
    }
}
