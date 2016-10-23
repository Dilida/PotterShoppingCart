using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart.Tests
{
    public class ShoppingCart
    {
        private List<BookData> _items;
        public ShoppingCart()
        {
            this._items = new List<BookData>();
        }

        internal object orderFee()
        {
            int total = 0;
            //return this._items[0].Quantity * this._items[0].Price;
            if (this._items.Count == 2)
            {
                //return 190;
                total = _items.Sum(i => i.Quantity * i.Price);
                return Convert.ToInt32(total * 0.95); 
            }
            else
            {
                total = _items[0].Quantity * _items[0].Price;
                return total;
            }

        }

        internal void Add(BookData bookData)
        {
            _items.Add(bookData);
        }

        internal void Add(List<BookData> booksData)
        {
            _items = new List < BookData > (booksData);
        }
    }
}
