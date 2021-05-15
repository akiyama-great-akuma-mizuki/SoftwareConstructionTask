using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem
{
    [Serializable]
    public class Product
    {
        public int ProductId { get; set; }
        //public int OrderId

        public String Name { get; set; }
        public double Price { get; set; }
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
