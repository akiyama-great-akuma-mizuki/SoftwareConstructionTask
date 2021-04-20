using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem
{
    [Serializable]
    public class Product
    {
        public string name;
        public String Name { get => name; }
        public double price;
        public double Price { get => price; }
        public String info;
        public Product(String Name,double Price)
        {
            info = "生产时间:" + DateTime.Today.ToString();
            this.name = Name;
            this.price = Price;
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
