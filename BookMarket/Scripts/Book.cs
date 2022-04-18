using BookMarket.ForDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.Scripts
{
    public class Book
    {
        public Books b;
        public int count;
        public float percent = 1;

        public Books B
        {
            get => b;
        }

        public int Count
        {
            get => count;
        }

        public string OldPrice
        {
            get
            {
                if(count>3)
                {
                    percent = 0.95f;
                }
                else if (count > 5)
                {
                    percent = 0.9f;
                }
                else if(count > 10)
                {
                    percent = 0.85f;
                }
                else
                {
                    percent = 1;
                    return "";
                }
                return " " + (b.Cost * count);


            }
        }

        public string NewPrice
        {
            get=>""+(b.Cost*count*percent);
        }


    }
}
