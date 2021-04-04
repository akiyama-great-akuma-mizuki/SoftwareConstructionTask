using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace HomeWork5
{
    [Serializable]
    public class Order
    {        
        private List<Orderdetails> details;
        private int id;
        public Client user;
        public Order(int id, Client user)
        {
            this.id = id;
            this.user = user;
            details = new List<Orderdetails>();
            
        }
        public Order()
        {
            this.id = -1;
            this.user = null;
            details = new List<Orderdetails>();
        }
        public int Id { get => id; }
        public double Price { get => GetPrice(); }
        public double GetPrice()
        {
            double res = 0;
            details.ForEach(m => res += m.product.Price * m.count);
            return res;
        }
        public override string ToString()
        {
            String res = "订单基本信息:\n" + "编号: " + id +
                    "\n" + "总价格: " + Price + "\n" +
                    "购买用户:" + user.ToString() + "\n";
            details.ForEach(m => res += m.ToString());
            return res;
        }
        public void AddProducts(Product p,int count)
        {
            var res = from m in details
                      where m.product.Equals(p)
                      select m;
            Orderdetails o = res.FirstOrDefault();
            if (o != null)
                o.count += count;
            else details.Add(new Orderdetails(p, count));
        }
        public void DeleteProducts(Product p,int count)
        {
            var res = from m in details
                      where m.product.Equals(p)
                      select m;
            Orderdetails d = res.FirstOrDefault();
            if(d != null)
            {
                if (d.count <= count)
                    details.Remove(d);
                else d.count -= count;
            }

        }
        public void Copy(Order target)
        {
            this.id = target.id;
            this.details = target.details;
            this.user = target.user;
        }
        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   EqualityComparer<List<Orderdetails>>.Default.Equals(details, order.details) &&
                   id == order.id &&
                   EqualityComparer<Client>.Default.Equals(user, order.user) &&
                   Id == order.Id &&
                   Price == order.Price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(details, id, user, Id, Price);
        }
        public void Export()
        {
            XmlSerializer xmlExport = new XmlSerializer(typeof(List<Orderdetails>));
            using (FileStream fos = new FileStream("orderdetails.xml", FileMode.Create, FileAccess.Write))
                xmlExport.Serialize(fos, details);

        }
        public void Import(FileStream fis)
        {
            XmlSerializer xmlImport = new XmlSerializer(typeof(List<Orderdetails>));
            List<Orderdetails> temp = (List<Orderdetails>)xmlImport.Deserialize(fis);
        }
    }
}
