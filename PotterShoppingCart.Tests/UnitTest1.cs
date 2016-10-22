using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class bookShoppintCartTest
    {
        [TestMethod]
        public void checkOut_EP1_was_100()
        {
            var bookData = new BookData() { EP=1, Price=100, Quantity = 1 };
            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(bookData);
            var expected = 100;
            var actual = shoppingCart.orderFee();

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}

namespace PotterShoppingCart.Tests
{
    public class BookData
    {
        public BookData()
        {
        }

        public int EP { get; set;}
        public int Price { get; set; }
        public int Quantity { get;  set; }
    }
}