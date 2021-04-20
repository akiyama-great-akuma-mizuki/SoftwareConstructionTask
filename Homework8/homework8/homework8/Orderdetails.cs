using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem
{
    [Serializable]
    public class Orderdetails
    {
        private String info;
        public Product product;
        public int count;
        public Orderdetails(Product prod, int cnt)
        {
            info = "下单时间:" + DateTime.Now.ToString();
            product = prod;
            count = cnt;
        }
        public Orderdetails()
        {
            info = "下单时间:" + DateTime.Now.ToString();
            product = null;
            count = 0;
        }
        public override string ToString()
        {
            return product.ToString() + count + "个 " + info + "\n";
        }

        public override bool Equals(object obj)
        {
            return obj is Orderdetails details &&
                   info == details.info &&
                   EqualityComparer<Product>.Default.Equals(product, details.product) &&
                   count == details.count;
        }

        public override int GetHashCode()
        {
            var hashCode = 1241719765;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(info);
            hashCode = hashCode * -1521134295 + EqualityComparer<Product>.Default.GetHashCode(product);
            hashCode = hashCode * -1521134295 + count.GetHashCode();
            return hashCode;
        }
    }
}
