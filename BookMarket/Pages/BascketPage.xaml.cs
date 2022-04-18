using BookMarket.ForDB;
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
        bool onStock = false;
        public BascketPage(MainMarket Mm, ref List<Book> b)
        {
            InitializeComponent();
            mm = Mm;
            books = b;
            ListViewBascket.ItemsSource = books.ToList();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.fr.Navigate(mm);
        }

        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            string s = "";
            foreach (Book b in books)
            {
                s += b.b.Title + b.Count + "шт.\n";
                Books B = DBCl.db.Books.FirstOrDefault(x => x.Id == b.b.Id);
                if(B.CountInMarket<b.Count)
                {
                    b.count -= B.CountInMarket;
                    B.CountInMarket = 0;
                    B.CountInStock -= b.Count;
                    onStock = true;
                }
                else
                {
                    B.CountInMarket -=b.Count;
                }
                
                DBCl.db.SaveChanges();
                
            }

            MessageBox.Show(("Ваш заказ оформлен, вы заказали: " + s + "\n" + (onStock ? "Заказ будет через 72 часа." : "Можете забрать заказ на кассе.")), "Оформлено");
            
            FrameClass.fr.Navigate(mm);
        }
    }
}
