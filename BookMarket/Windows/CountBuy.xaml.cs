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
using System.Windows.Shapes;

namespace BookMarket.Windows
{
    /// <summary>
    /// Логика взаимодействия для CountBuy.xaml
    /// </summary>
    public partial class CountBuy : Window
    {
        public CountBuy()
        {
            InitializeComponent();
        }

        int id;
        List<Book> books = new List<Book>();
        public CountBuy(int Id, ref List<Book> Books)
        {
            InitializeComponent();
            id=Id;
            books = Books;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            
            Books book = DBCl.db.Books.FirstOrDefault(x => x.Id == id);
            try
            {
                if ((book.CountInMarket+ book.CountInStock) >= Convert.ToInt32(TextBoxCount.Text))
                {
                    if (books.Count > 0)
                    {
                        if (books.FirstOrDefault(x => x.b.Id == id) != null)
                        {
                            books.Remove(books.FirstOrDefault(x => x.b.Id == id));
                        }
                    }
                    books.Add(new Book() { b = book, count = Convert.ToInt32(TextBoxCount.Text) });
                    Close();
                }
                else
                {
                    throw new Exception("Нет такого количества книг");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
