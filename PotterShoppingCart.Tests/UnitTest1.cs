using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class bookShoppintCartTest
    {
        [TestMethod]
        public void checkOut_EP1_was_100()
        {
            var bookData = new BookData() {
                EP =1, Price=100, Quantity = 1
            };
            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(bookData);
            var expected = 100;
            var actual = shoppingCart.orderFee();

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void checkOut_twoBook_was_95_discounted()
        {
            var booksData = new List<BookData>{
                new BookData { EP =1, Price =100, Quantity = 1},
                new BookData { EP =2, Price =100, Quantity = 1}
            };
            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(booksData);
            var expected = 190;
            var actual = shoppingCart.orderFee();

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void checkOut_threeBook_was_90_discounted()
        {
            var booksData = new List<BookData>{
                new BookData { EP =1, Price =100, Quantity = 1},
                new BookData { EP =2, Price =100, Quantity = 1},
                new BookData { EP =3, Price =100, Quantity = 1}
            };
            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(booksData);
            var expected = 270;
            var actual = shoppingCart.orderFee();

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void checkOut_fourBook_was_80_discounted()
        {
            var booksData = new List<BookData>{
                new BookData { EP =1, Price =100, Quantity = 1},
                new BookData { EP =2, Price =100, Quantity = 1},
                new BookData { EP =3, Price =100, Quantity = 1},
                new BookData { EP =4, Price =100, Quantity = 1},
            };
            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(booksData);
            var expected = 320;
            var actual = shoppingCart.orderFee();

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void checkOut_fiveBook_was_75_discounted()
        {
            var booksData = new List<BookData>{
                new BookData { EP =1, Price =100, Quantity = 1},
                new BookData { EP =2, Price =100, Quantity = 1},
                new BookData { EP =3, Price =100, Quantity = 1},
                new BookData { EP =4, Price =100, Quantity = 1},
                new BookData { EP =5, Price =100, Quantity = 1}
            };
            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(booksData);
            var expected = 375;
            var actual = shoppingCart.orderFee();

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void checkOut_twoBooksDiscounted_oneBookOrigin()
        {
            var booksData = new List<BookData>{
                new BookData { EP =1, Price =100, Quantity = 1},
                new BookData { EP =2, Price =100, Quantity = 1},
                new BookData { EP =3, Price =100, Quantity = 2}
               
            };
            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(booksData);
            var expected = 370;
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