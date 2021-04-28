namespace homework9
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.webLabel = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.WebFiliterCheck = new System.Windows.Forms.CheckBox();
            this.WebText = new System.Windows.Forms.TextBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.InfoText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.webLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.StartBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.WebFiliterCheck, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.WebText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.urlText, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1122, 147);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "网址";
            // 
            // webLabel
            // 
            this.webLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.webLabel.AutoSize = true;
            this.webLabel.Enabled = false;
            this.webLabel.Location = new System.Drawing.Point(3, 101);
            this.webLabel.Name = "webLabel";
            this.webLabel.Size = new System.Drawing.Size(368, 18);
            this.webLabel.TabIndex = 2;
            this.webLabel.Text = "特定网站";
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartBtn.Location = new System.Drawing.Point(886, 14);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(98, 44);
            this.StartBtn.TabIndex = 5;
            this.StartBtn.Text = "开始";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // WebFiliterCheck
            // 
            this.WebFiliterCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WebFiliterCheck.AutoSize = true;
            this.WebFiliterCheck.Location = new System.Drawing.Point(864, 99);
            this.WebFiliterCheck.Name = "WebFiliterCheck";
            this.WebFiliterCheck.Size = new System.Drawing.Size(142, 22);
            this.WebFiliterCheck.TabIndex = 4;
            this.WebFiliterCheck.Text = "爬取特定网站";
            this.WebFiliterCheck.UseVisualStyleBackColor = true;
            this.WebFiliterCheck.CheckedChanged += new System.EventHandler(this.WebFiliterCheck_CheckedChanged);
            // 
            // WebText
            // 
            this.WebText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WebText.Enabled = false;
            this.WebText.Location = new System.Drawing.Point(377, 96);
            this.WebText.Name = "WebText";
            this.WebText.Size = new System.Drawing.Size(368, 28);
            this.WebText.TabIndex = 3;
            // 
            // urlText
            // 
            this.urlText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.urlText.Location = new System.Drawing.Point(377, 22);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(368, 28);
            this.urlText.TabIndex = 0;
            this.urlText.Text = "http://";
            // 
            // InfoText
            // 
            this.InfoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoText.Location = new System.Drawing.Point(1, 158);
            this.InfoText.Multiline = true;
            this.InfoText.Name = "InfoText";
            this.InfoText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfoText.Size = new System.Drawing.Size(1122, 457);
            this.InfoText.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 625);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox InfoText;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label webLabel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.CheckBox WebFiliterCheck;
        private System.Windows.Forms.TextBox WebText;
    }
}

