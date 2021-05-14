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
    public partial class Form1 : Form
    {
        public OrderService serve = new OrderService();
        public List<Order> queryFliter = new List<Order>();
        public static List<Product> productList = new List<Product>();
        //public OrderServiceDB DB;
        public Form1()
        {
            InitializeComponent();
            ProduceProducts();
            //queryFliter = new List<Order>();
            //this.OrderView.DataMember = "Detail";
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            this.OrderView.DataSource = null;
            this.OrderView.DataSource = serve.orders;

            queryFliter = serve.orders;
            if (this.IdQueryBox.Text != "")
                queryFliter = queryFliter.Where(m => m.Id == Convert.ToInt32(this.IdQueryBox.Text)).ToList();
            if (this.UserQueryBox.Text != "")
                queryFliter = queryFliter.Where(m => m.User.Name == this.UserQueryBox.Text).ToList();
            if (this.PriceQueryBox.Text != "")
                queryFliter = queryFliter.Where(m => Math.Abs(m.Price - Convert.ToDouble(this.PriceQueryBox.Text)) == 0).ToList();

            this.OrderView.DataSource = queryFliter;

            this.IdQueryBox.Text = "";
            this.UserQueryBox.Text = "";
            this.PriceQueryBox.Text = "";
            //this.OrderView.Refresh();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            CreateOrder createForm = new CreateOrder(serve, productList);
            createForm.ShowDialog();
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            ModifyOrder modiForm = new ModifyOrder(productList, serve);
            modiForm.ShowDialog();
        }


        private void ProduceProducts()
        {
            productList.Add(new Product("banana", 3));
            productList.Add(new Product("lemon", 5));
            productList.Add(new Product("guitar", 100));
            productList.Add(new Product("beth", 100));
            productList.Add(new Product("drum", 600));
            productList.Add(new Product("keyBoard", 500));
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认彻底删除所选订单项？", "删除订单", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.OrderView.DataSource = null;

                while (queryFliter.Count > 0)
                {
                    Order m = queryFliter.FirstOrDefault();
                    serve.DeleteOrder(m);
                    using(var DB = new OrderServiceDB())
                    {
                        var o = DB.MyOrders.Include("OrderDetails").FirstOrDefault(p => p.Id == m.Id);
                        if(o!=null)
                        {
                            DB.MyOrders.Remove(o);
                            DB.SaveChanges();
                        }
                    }
                    queryFliter.Remove(m);
                }

                queryFliter = serve.orders;
                this.OrderView.DataSource = queryFliter;
            }
        }

        private void ImpBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowHelp = true;
            openFile.Filter = "xml文件|*.xml|json文件|*.json|所有文件|*.*";
            openFile.FilterIndex = 1;
            openFile.InitialDirectory = "C:\\";
            if (openFile.ShowDialog() == DialogResult.OK)               
            {
                 String url = openFile.FileName;
                serve.Import(url);
            }
        }

        private void expBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.ShowHelp = true;
            saveFile.Filter = "xml文件|*.xml|json文件|*.json|所有文件|*.*";
            saveFile.FilterIndex = 1;
            saveFile.InitialDirectory = "C:\\";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                String url = saveFile.FileName;
                serve.Export(url);
            }
        }
    }
}
