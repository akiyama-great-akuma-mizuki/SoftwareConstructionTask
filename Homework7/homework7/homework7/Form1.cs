using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
            this.LSizeUpDown.DecimalPlaces = 2;
            this.LSizeUpDown.Increment = 0.01M;
            this.RSizeUpDown.DecimalPlaces = 2;
            this.RSizeUpDown.Increment = 0.01M;

        }
        public void init()
        {
            Length = Convert.ToInt32(LengthUpDown.Value);
            Deep = Convert.ToInt32(DeepUpDown.Value);
            LAngle = Convert.ToInt32(LAngleUpDown.Value) * Math.PI / 180;
            RAngle = Convert.ToInt32(RAngleUpDown.Value) * Math.PI / 180;
            LPer = Convert.ToDouble(LSizeUpDown.Value);
            RPer = Convert.ToDouble(RSizeUpDown.Value);
        }
        Color CurColor = Color.Blue;
        private Graphics graphics;
        private int Length{ get; set; }
        private int Deep { get; set; }
        private double LAngle { get; set; }
        private double RAngle { get; set; }
        private double LPer { get; set; }
        private double RPer { get; set; }
        private Pen myPen = new Pen(Color.Black, 3);
        private void drawCayleyTree(int deep,double x0,double y0,double length,double th)
        {
            if (deep == 0)
                return;
            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);
            drawLine(x0, x1, y0, y1);
            drawCayleyTree(deep - 1, x1, y1, RPer * length, th + LAngle);
            drawCayleyTree(deep - 1, x1, y1, LPer * length, th - RAngle);
        }
        private void drawLine(double x0,double x1,double y0,double y1)
        {
            graphics.DrawLine(myPen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            init();
            this.splitContainer1.Panel2.Refresh();
            graphics = this.splitContainer1.Panel2.CreateGraphics();
            drawCayleyTree(Deep, (this.splitContainer1.Panel2.Width) / 2, this.splitContainer1.Panel2.Height - 100, Length, -Math.PI/2);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color user_c = colorDialog1.Color;
            myPen.Color = user_c;
            ColorLabel.ForeColor = user_c;
        }
    }
}
