using System;
using System.Collections;
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
            int minQuantity = _items.Min(i => i.Quantity);
            total = _items.Sum(i => minQuantity * i.Price);
            var rate = getOrderDiscount(_items.Count);
            total = Convert.ToInt32(total * rate);
            foreach (var item in _items)
            {

                var elseItems = _items.Select(x =>
               {
                   x.Quantity -= minQuantity;
                   return x;
               });              
                elseItems =  elseItems.Where(x => x.Quantity > 0).ToList();      

                if (elseItems.Count() > 0)
                {
                    rate = getOrderDiscount(elseItems.Count());
                    total += Convert.ToInt32(elseItems.Sum(i => i.Price * minQuantity) * rate);
                }

            }

            return total;

        }

        private double getOrderDiscount(int booksCount)
        {
            switch (booksCount)
            {              
                //Convert.ToInt32(item.GetType().GetProperty(columValue).GetValue(item).ToString())
                case 2 : return 0.95;
                case 3 : return 0.9;
                case 4 : return 0.8;
                case 5 : return 0.75;
                default: return 1;
                   
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
