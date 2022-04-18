using BookMarket.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookMarket.Pages
{
    /// <summary>
    /// Логика взаимодействия для BascketPage.xaml
    /// </summary>
    public partial class BascketPage : Page
    {
        public BascketPage()
        {
            InitializeComponent();
        }
        MainMarket mm;
        List<Book> books;
        public BascketPage(MainMarket Mm, ref List<Book> b)
        {
            InitializeComponent();
            mm = Mm;
            books = b;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.fr.Navigate(mm);
        }
    }
}
