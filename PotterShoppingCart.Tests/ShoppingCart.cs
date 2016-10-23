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
            return this._items[0].Price * this._items[0].Quantity;
        }

        internal void Add(BookData bookData)
        {
            this._items.Add(bookData);
        }
    }
}
