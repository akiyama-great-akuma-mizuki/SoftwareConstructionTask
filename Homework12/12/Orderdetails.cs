using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using todoapi;
namespace OrderSystem
{
    [Serializable]
    public class Orderdetails
    {
        public int OrderdetailsId { get; set; }
        private String info { get; set; }       
        public int PId { get; set; }
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
        //public virtual Product Product { get; set; }
        public int Count { get; set; }
        public Orderdetails(int pid, int cnt)
        {
            info = "下单时间:" + DateTime.Now.ToString();
            PId = pid;
            Count = cnt;
        }
        public Orderdetails()
        {
            info = "下单时间:" + DateTime.Now.ToString();
            PId = -1;
            Count = 0;
        }
        public override string ToString()
        {
            if (PId >= 0 && PId < Program.productList.Count)
                return Program.productList[PId].ToString() + Count + "个 " + info + "\n";
            else return "";
        }

        public override bool Equals(object obj)
        {
            return obj is Orderdetails orderdetails &&
                   OrderdetailsId == orderdetails.OrderdetailsId &&
                   info == orderdetails.info &&
                   PId == orderdetails.PId &&
                   Count == orderdetails.Count;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderdetailsId, info, PId, Count);
        }
    }
}
