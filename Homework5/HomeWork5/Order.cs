using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork5
{
    class Order
    {
        public class OrderDetails
        {
            private String info;         
            public Product product;
            public int count;
            public OrderDetails(Product prod,int cnt)
            {
                info = "下单时间:" + DateTime.Now.ToString();
                product = prod;
                count = cnt;
            }
            public override string ToString()
            {
                return product.ToString() + count +"个 "+ info +"\n";
            }

            public override bool Equals(object obj)
            {
                return obj is OrderDetails details &&
                       info == details.info &&
                       EqualityComparer<Product>.Default.Equals(product, details.product) &&
                       count == details.count;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(info, product, count);
            }
        }
        private List<OrderDetails> details;
        private int id;
        public Client user;
        public Order(int id, Client user)
        {
            this.id = id;
            this.user = user;
            details = new List<OrderDetails>();
            
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
            OrderDetails o = res.FirstOrDefault();
            if (o != null)
                o.count += count;
            else details.Add(new OrderDetails(p, count));
        }
        public void DeleteProducts(Product p,int count)
        {
            var res = from m in details
                      where m.product.Equals(p)
                      select m;
            OrderDetails d = res.FirstOrDefault();
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
                   EqualityComparer<List<OrderDetails>>.Default.Equals(details, order.details) &&
                   id == order.id &&
                   EqualityComparer<Client>.Default.Equals(user, order.user) &&
                   Id == order.Id &&
                   Price == order.Price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(details, id, user, Id, Price);
        }
    }
}
