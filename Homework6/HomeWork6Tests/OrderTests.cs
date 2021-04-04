using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork5;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5.Tests
{
    [TestClass()]
    public class OrderTests
    {
        [TestMethod()]
        public void ExportTest()
        {
            Order o1 = new Order(0, new Client("a","b"));
            o1.AddProducts(new Product("c", 1), 2);
            o1.Export();
        }
    }
}