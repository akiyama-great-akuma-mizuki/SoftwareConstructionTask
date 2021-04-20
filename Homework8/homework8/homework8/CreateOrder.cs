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
namespace homework8
{
    public partial class CreateOrder : Form
    {
        public List<Product> Prods;
        public OrderService Serve;
        public int AddProd { get; set; }
        public int Id { get; set; }
        public String UserName { get; set; }
        public String Address { get; set; }
        public int Count { get; set; }
        public CreateOrder(OrderService s, List<Product> list)
        {
            InitializeComponent();
            Count = 1;
            this.Prods = list;
            this.Serve = s;
            this.ProductBox.DataSource = Prods;
            this.ProductBox.DisplayMember = "Name";
            this.ProductBox.DataBindings.Add("SelectedIndex", this, "AddProd");
            this.IdBox.DataBindings.Add("Value", this, "Id");
            this.AddressBox.DataBindings.Add("Text", this, "Address");
            this.UsernameBox.DataBindings.Add("Text", this, "UserName");
            this.CountBox.DataBindings.Add("Value", this, "Count");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            Order o = new Order(this.Id, new Client(this.UserName, this.Address));
            o.AddProducts(this.Prods[AddProd], this.Count);
            Serve.AddOrder(o);
            this.Close();
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
