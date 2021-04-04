using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace HomeWork5
{
    [Serializable]
    public class OrderService
    {
        public int IdCount = 0;
        private List<Order> orders = new List<Order>();
        public OrderService() { }
        public void AddOrder(Order p)
        {
            foreach(Order o in orders)
            {
                if(o.Id == p.Id)
                {
                    Console.WriteLine("已存在编号，添加失败");
                    return;
                }                   
            }
            orders.Add(p);
            Console.WriteLine("添加成功");
            IdCount = IdCount > p.Id ? IdCount : p.Id + 1; 
        }
        public Order QueryOrder(int id)//重载3个
        {
            var p = from o in orders
                    where o.Id == id
                    select o;
            return p.FirstOrDefault();

        }
        public List<Order> QueryOrder(double price)
        {
            var p = from w in orders
                    where w.Price == price
                    select w;
            List<Order> res = p.ToList();
            return res;

        }
        public List<Order> QueryOrder(Client u)
        {
            var p = from w in orders
                    where w.user.Equals(u)
                    select w;
            List<Order> res = p.ToList();
            return res;

        }
        public void DeleteOrder(Order o)
        {
            orders.Remove(o);
        }
        public void DeleteOrder(Client user)
        {
            foreach (Order r in QueryOrder(user))
                DeleteOrder(r);
        }
        public void DeleteOrder(double price)
        {
            foreach (Order r in QueryOrder(price))
                DeleteOrder(r);
        }
        public void ModifyOrder(Order source,Order target)
        {
            int idx = orders.IndexOf(source);
            if (idx == -1)
                Console.WriteLine("替换失败，无此项");
            else
            {
                orders.RemoveAt(idx);
                orders.Insert(idx, target);
            }
        }
        public void ModifyOrder(int OrderId, Order target)
        {
            orders.ForEach(m =>
            {
                if(m.Id == OrderId)
                {
                    m.Copy(target);
                    if (target.Id >= IdCount)
                        IdCount = target.Id + 1;
                }
            });
        }
        public void Export()
        {
            XmlSerializer xmlExport = new XmlSerializer(typeof(List<Order>));
            using (FileStream fos = new FileStream("orders.xml", FileMode.Create, FileAccess.Write))
                xmlExport.Serialize(fos, orders);
                
        }
        public void Import(FileStream fis)
        {
            XmlSerializer xmlImport = new XmlSerializer(typeof(List<Order>));
            List<Order> temp = (List<Order>)xmlImport.Deserialize(fis);
            temp.ForEach(AddOrder);
        }
        public override string ToString()
        {
            String res = "";
            orders.ForEach(m => res += m.ToString());
            return res;
        }
    }
}
