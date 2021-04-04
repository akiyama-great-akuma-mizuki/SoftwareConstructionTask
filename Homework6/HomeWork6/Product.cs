using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5
{
    [Serializable]
    public class Product
    {
        public String Name { get;}
        public double Price { get;}
        public String info;
        public Product(String Name,double Price)
        {
            info = "生产时间:" + DateTime.Today.ToString();
            this.Name = Name;
            this.Price = Price;
        }
        public Product()
        {
            info = "生产时间:" + DateTime.Today.ToString();
        }
        public override string ToString()
        {
            return "商品名称:" + Name + " " + info + " 单价：" + Price + " ";
        }
    }
}
