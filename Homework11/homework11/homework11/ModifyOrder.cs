using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSystem;

namespace homework11
{
    public partial class ModifyOrder : Form
    {
        public List<Product> Prods;
        public OrderService Serve;
        public int AddProd { get; set; }
        public int Id { get; set; }
        public int QueryId { get; set; }
        public String UserName { get; set; }
        public String Address { get; set; }
        public int Count { get; set; }
        public ModifyOrder(List<Product> Prods, OrderService Serve)
        {
            InitializeComponent();
            this.Prods = Prods;
            this.Serve = Serve;
            Count = 1;

            this.ProductBox.DataSource = Prods;
            this.ProductBox.DisplayMember = "Name";
            this.ProductBox.DataBindings.Add("SelectedIndex", this, "AddProd");
            this.QueryBox.DataBindings.Add("Value", this, "QueryId");
            this.IdBox.DataBindings.Add("Value", this, "Id");
            this.AddressBox.DataBindings.Add("Text", this, "Address");
            this.UsernameBox.DataBindings.Add("Text", this, "UserName");
            this.CountBox.DataBindings.Add("Value", this, "Count");
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            Order newOne = new Order(this.Id, new Client(this.Name, this.Address));
            newOne.AddProducts(this.AddProd, this.Count);

            Serve.ModifyOrder(this.QueryId, newOne);
            using (var DB = new OrderServiceDB())
            {
                var o = DB.MyOrders.Include("OrderDetails").FirstOrDefault(p => p.Id == QueryId);
                if (o != null)
                {
                    o.OrderDetails = newOne.OrderDetails;
                    o.User = newOne.User;
                    DB.SaveChanges();
                }
            }
            this.Close();
        }

        private void QueryBtn_Click(object sender, EventArgs e)
        {
            Order res = Serve.QueryOrder(QueryId);
            if (res == null)
            {
                MessageBox.Show("不存在订单", "提示", MessageBoxButtons.OK);
                return;
            }
            QueryId = res.Id;
            
            this.ModifyBtn.Enabled = true;
            this.tableLayout.Enabled = true;

            
        }
    }
}
