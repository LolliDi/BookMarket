using BookMarket.ForDB;
using BookMarket.Scripts;
using BookMarket.Windows;
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
    /// Логика взаимодействия для MainMarket.xaml
    /// </summary>
    public partial class MainMarket : Page
    {
        public MainMarket()
        {
            InitializeComponent();
            ListViewMarket.ItemsSource = DBCl.db.Books.ToList();
        }

        List<Book> books = new List<Book>();

        private void Buy_Click(object sender, RoutedEventArgs e) //открываем окно с выбором колличества книг
        {
            Button btn = sender as Button;
            CountBuy cb = new CountBuy(Convert.ToInt32(btn.Uid),ref books);
            cb.ShowDialog();
        }

        private void GoBascket_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
