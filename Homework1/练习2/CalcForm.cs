using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //”计算"按钮点击事件处理
        private void CalcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(NumInput1.Text);
                int num2 = Convert.ToInt32(NumInput2.Text);
                int res = 0;
                switch (OpBox.SelectedIndex)
                {
                    case 0:
                        res = num1 + num2;
                        break;
                    case 1:
                        res = num1 - num2;
                        break;
                    case 2:
                        res = num1 * num2;
                        break;
                    case 3:
                        res = num1 / num2;
                        break;
                    default:
                        res = num1 + num2;
                        break;
                }
                ResLabel.Text = Convert.ToString(res);
            }
            catch(FormatException E)
            {
                ResLabel.Text = "输入错误！";
            }
            catch(OverflowException E)
            {
                ResLabel.Text = "数字溢出！";
            }
        }
        
    }
}
