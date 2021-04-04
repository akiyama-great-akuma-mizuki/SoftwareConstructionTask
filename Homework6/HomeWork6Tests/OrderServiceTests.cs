using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork5;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        List<Product> products = new List<Product>();
        Client cl1 = new Client("furukawa nagisa", "mati");
        Client cl2 = new Client("misaka mikoto", "gakuenntoshi");
        Client cl3 = new Client("fuko", "wasureru");
        Order o1 = null;
        Order o2 = null;
        Order o3 = null;
        OrderService serve = new OrderService();
        public void beforetest()
        {
            for (int i = 0; i < 10; i++)
                products.Add(new Product(i + 100 + "", i * 5 + 1));
            o1 = new Order(0, cl1);
            o2 = new Order(1, cl2);
            o3 = new Order(2, cl3);
            o1.AddProducts(products[6], 3);
            o2.AddProducts(products[4], 5);
            o3.AddProducts(products[7], 1);
            o1.AddProducts(products[3], 2);
            o2.AddProducts(products[1], 4);
            o3.AddProducts(products[5], 9);
            serve.AddOrder(o1);
            serve.AddOrder(o2);
            serve.AddOrder(o3);
        }
        [TestMethod()]
        public void QueryOrderTest()
        {
            beforetest();
            Order temp = serve.QueryOrder(0);
            Assert.AreEqual(o1, temp);
        }

        [TestMethod()]
        public void QueryOrderTest1()
        {
            beforetest();
            List<Order> res = serve.QueryOrder(cl1);
            res.ForEach(m => Assert.AreEqual(m, o1));
        }

        [TestMethod()]
        public void DeleteOrderTest2()
        {
            beforetest();
            serve.DeleteOrder(125);
            Order o = serve.QueryOrder(0);
            Assert.IsNull(o);
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            beforetest();
            serve.DeleteOrder(o1);
            Order o = serve.QueryOrder(0);
            Assert.IsNull(o);
        }

        [TestMethod()]
        public void DeleteOrderTest1()
        {
            beforetest();
            serve.DeleteOrder(cl1);
            Order o = serve.QueryOrder(0);
            Assert.IsNull(o);
        }

        [TestMethod()]
        public void ModifyOrderTest()
        {
            beforetest();
            Order newOrder = new Order(100, cl2), oldOrder = serve.QueryOrder(0);
            serve.ModifyOrder(oldOrder, newOrder);
            Assert.AreNotEqual(serve.QueryOrder(0), newOrder);
        }

        [TestMethod()]
        public void ModifyOrderTest1()
        {
            beforetest();
            Order newOrder = new Order(100, cl2);
            serve.ModifyOrder(0, newOrder);
            Assert.AreNotEqual(serve.QueryOrder(0), newOrder);
            
        }
    }
}