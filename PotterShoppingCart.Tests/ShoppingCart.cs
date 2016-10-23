﻿using System;
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
            total = _items.Sum(i => i.Quantity * i.Price);
            var rate = getOrderDiscount();
            return Convert.ToInt32( total * rate);

        }

        private double getOrderDiscount()
        {
            if (this._items.Count == 2)
            {
                return 0.95;
            }
            else
            {
                return 1;
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
