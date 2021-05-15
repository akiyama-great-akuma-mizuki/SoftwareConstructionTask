using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using todoapi;
namespace OrderSystem
{
    [Serializable]
    public class Order
    {        
        //public List<Orderdetails> OrderDetails;
        public ICollection<Orderdetails> OrderDetails{ get ; set; }
        public int id;
        public Client Client;
        public Order(int id, Client user)
        {
            this.id = id;
            this.Client = user;
            OrderDetails = new List<Orderdetails>();
            
        }
        public Order()
        {
            this.id = -1;
            this.Client = null;
            OrderDetails = new List<Orderdetails>();
        }
        public Client User { get => Client; set => Client = value; }
        public int Id { get => id; set => id = value; }
        public double Price { get => GetPrice();}
        public double GetPrice()
        {
            double res = 0;
            foreach (Orderdetails m in OrderDetails)
            {
                res += Program.productList[m.PId].Price * m.Count;
            }
            return res;
        }
        public override string ToString()
        {
            String res = "订单基本信息:\n" + "编号: " + id +
                    "\n" + "总价格: " + Price + "\n" +
                    "购买用户:" + Client.ToString() + "\n";
            foreach (Orderdetails m in OrderDetails)
            {
                res += m.ToString();
            }
            return res;
        }
        public void AddProducts(int pid,int count)
        {
            var res = from m in OrderDetails
                      where m.PId == pid
                      select m;
            Orderdetails o = res.FirstOrDefault();
            if (o != null)
                o.Count += count;
            else OrderDetails.Add(new Orderdetails(pid, count));
        }
        public void DeleteProducts(Product p,int count)
        {
            var res = from m in OrderDetails
                      where Program.productList[m.PId].Equals(p)
                      select m;
            Orderdetails d = res.FirstOrDefault();
            if(d != null)
            {
                if (d.Count <= count)
                    OrderDetails.Remove(d);
                else d.Count -= count;
            }

        }
        public void Copy(Order target)
        {
            this.id = target.id;
            this.OrderDetails = target.OrderDetails;
            this.Client = target.Client;
        }
        


        public void Export(String url)
        {
            XmlSerializer xmlExport = new XmlSerializer(typeof(List<Orderdetails>));
            using (FileStream fos = new FileStream(url, FileMode.Create, FileAccess.Write))
                xmlExport.Serialize(fos, OrderDetails);

        }
        public void Import(String url)
        {
            XmlSerializer xmlImport = new XmlSerializer(typeof(List<Orderdetails>));
            List<Orderdetails> temp;
            using (FileStream fis = new FileStream(url, FileMode.Open, FileAccess.Read))
                 temp = (List<Orderdetails>)xmlImport.Deserialize(fis);
        }

        public override int GetHashCode()
        {
            var hashCode = -1496434976;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            return hashCode;
        }
    }
}
