namespace WindowsFormsApp1
{
    partial class CalcForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NumInput1 = new System.Windows.Forms.TextBox();
            this.OpBox = new System.Windows.Forms.DomainUpDown();
            this.NumInput2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResLabel = new System.Windows.Forms.Label();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.OpBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.NumInput2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ResLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.CalcBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.NumInput1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(912, 462);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NumInput1
            // 
            this.NumInput1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumInput1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NumInput1.Location = new System.Drawing.Point(20, 96);
            this.NumInput1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.NumInput1.Name = "NumInput1";
            this.NumInput1.Size = new System.Drawing.Size(142, 39);
            this.NumInput1.TabIndex = 0;
            this.NumInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OpBox
            // 
            this.OpBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OpBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpBox.Items.Add("+");
            this.OpBox.Items.Add("-");
            this.OpBox.Items.Add("*");
            this.OpBox.Items.Add("/");
            this.OpBox.Location = new System.Drawing.Point(185, 96);
            this.OpBox.Name = "OpBox";
            this.OpBox.ReadOnly = true;
            this.OpBox.Size = new System.Drawing.Size(176, 39);
            this.OpBox.TabIndex = 1;
            this.OpBox.Text = "+";
            this.OpBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumInput2
            // 
            this.NumInput2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumInput2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NumInput2.Location = new System.Drawing.Point(384, 96);
            this.NumInput2.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.NumInput2.Name = "NumInput2";
            this.NumInput2.Size = new System.Drawing.Size(142, 39);
            this.NumInput2.TabIndex = 2;
            this.NumInput2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(549, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ResLabel
            // 
            this.ResLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResLabel.AutoSize = true;
            this.ResLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ResLabel.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResLabel.Location = new System.Drawing.Point(731, 0);
            this.ResLabel.Name = "ResLabel";
            this.ResLabel.Size = new System.Drawing.Size(178, 231);
            this.ResLabel.TabIndex = 4;
            this.ResLabel.Text = " ";
            this.ResLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalcBtn.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CalcBtn.Location = new System.Drawing.Point(398, 320);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(114, 53);
            this.CalcBtn.TabIndex = 5;
            this.CalcBtn.Text = "计算";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "Form1";
            this.Text = "简易计算器1.0";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox NumInput1;
        private System.Windows.Forms.DomainUpDown OpBox;
        private System.Windows.Forms.TextBox NumInput2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResLabel;
        private System.Windows.Forms.Button CalcBtn;
    }
}

