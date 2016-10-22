using System;
using System.Collections.Generic;

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
            int sum = 0;
            foreach (var item in _items)
            {
                sum = item.Quantity * item.Price;
            }
            return sum;
        }

        internal void Add(BookData bookData)
        {
            this._items.Add(bookData);
        }
    }
}