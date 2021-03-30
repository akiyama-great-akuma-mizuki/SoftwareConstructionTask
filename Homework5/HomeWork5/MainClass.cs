using System;
using System.Collections.Generic;
using System.Collections;
namespace HomeWork5
{
    class MainClass
    {
        List<Product> products = new List<Product>();
        Client cl1 = new Client("furukawa", "mati");
        Client cl2 = new Client("misaka", "gakuenntoshi");
        Client cl3 = new Client("tomori", "wasureru");
        OrderService Serve = new OrderService();
        public void Produce()
        {
            for (int i = 0; i < 10; i++)
            {
                products.Add(new Product(i + 100 + "", i * 5 + 1));
            }
        }
        public void Shopping()
        {
            Order o1 = new Order(0, cl1);
            Order o2 = new Order(1, cl2);
            Order o3 = new Order(2, cl3);
            o1.AddProducts(products[6], 3);
            o2.AddProducts(products[4], 5);
            o3.AddProducts(products[7], 1);
            o1.AddProducts(products[3], 2);
            Serve.AddOrder(o1);
            Serve.AddOrder(o2);
            Serve.AddOrder(o3);
        }
        public void AfertSale()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("全部交易信息:");
                    Console.WriteLine(Serve.ToString());
                    Console.WriteLine(@"欢迎来到订单服务系统，请输入:'Q'(查询),'A'(添加),'D'(删除),'M'(修改)");
                    
                    switch (Console.ReadKey().KeyChar)
                    {
                        //未完成输入逻辑,运行方法示例
                        case 'Q':
                            Console.WriteLine("\n输入订单编号或顾客姓名或总价格查询:");
                            Serve.QueryOrder(1).ToString();
                            Serve.QueryOrder(cl1).ToString();
                            break;
                        case 'A':
                            Console.WriteLine("\n输入购买产品类别、顾客信息进行添加:");
                            Order newO = new Order(Serve.IdCount, cl2);
                            newO.AddProducts(products[9], 6);
                            Serve.AddOrder(newO);
                            break;
                        case 'D':
                            Console.WriteLine("\n输入订单编号或顾客姓名或总价格删除:");
                            Serve.DeleteOrder(cl3);
                            break;
                        case 'M':
                            Console.WriteLine("\n输入订单编号修改:");
                            Order trg = new Order(Serve.IdCount, cl3);
                            trg.AddProducts(products[1], 9);
                            trg.AddProducts(products[2], 8);
                            Serve.ModifyOrder(0, trg);
                            break;
                        default: break;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            MainClass Store = new MainClass();
            Store.Produce();
            Store.Shopping();
            Store.AfertSale();            
        }
        
        
    }
}
