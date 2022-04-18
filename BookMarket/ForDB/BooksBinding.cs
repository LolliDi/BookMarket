using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.ForDB
{
    public partial class Books
    {
        public string GetNameAndGenre
        {
            get => "Название: " + Title + " | Жанр: " + Genre;
        }

        public string GetImage
        {
            get => Image;
        }

        public string GetCount
        {
            get
            {
                string inMarket = CountInMarket > 0 ? ("" + (CountInMarket > 5 ? "много" : ""+CountInMarket)) : "нет.";
                string inStock = CountInStock > 0 ? ("" + (CountInStock > 5 ? "много" : ""+CountInStock)) : "нет.";
                return "В магазине: " + inMarket + ". На складе: " + inStock;
            }
        }
    }
}
