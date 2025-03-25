namespace FormOvoSimpleApplication
{
    partial class buy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxBuy = new System.Windows.Forms.GroupBox();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.comboBoxAcc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxBuy.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBuy
            // 
            this.groupBoxBuy.Controls.Add(this.comboBoxItems);
            this.groupBoxBuy.Controls.Add(this.label6);
            this.groupBoxBuy.Controls.Add(this.buttonBuy);
            this.groupBoxBuy.Controls.Add(this.textBoxPrice);
            this.groupBoxBuy.Controls.Add(this.label5);
            this.groupBoxBuy.Location = new System.Drawing.Point(23, 56);
            this.groupBoxBuy.Name = "groupBoxBuy";
            this.groupBoxBuy.Size = new System.Drawing.Size(406, 140);
            this.groupBoxBuy.TabIndex = 24;
            this.groupBoxBuy.TabStop = false;
            this.groupBoxBuy.Text = "Buy";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Items.AddRange(new object[] {
            "Electricity Voucher",
            "Internet Voucher"});
            this.comboBoxItems.Location = new System.Drawing.Point(129, 28);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(166, 21);
            this.comboBoxItems.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Items to Buy :";
            // 
            // buttonBuy
            // 
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.Location = new System.Drawing.Point(129, 96);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(90, 28);
            this.buttonBuy.TabIndex = 8;
            this.buttonBuy.Text = "BUY";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(129, 63);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(104, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price :";
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(463, 12);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(378, 173);
            this.listBoxData.TabIndex = 25;
            // 
            // comboBoxAcc
            // 
            this.comboBoxAcc.FormattingEnabled = true;
            this.comboBoxAcc.Location = new System.Drawing.Point(152, 29);
            this.comboBoxAcc.Name = "comboBoxAcc";
            this.comboBoxAcc.Size = new System.Drawing.Size(161, 21);
            this.comboBoxAcc.TabIndex = 28;
            this.comboBoxAcc.SelectedIndexChanged += new System.EventHandler(this.comboBoxAcc_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Choose Account";
            // 
            // buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 193);
            this.Controls.Add(this.comboBoxAcc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.groupBoxBuy);
            this.Name = "buy";
            this.Text = "buy";
            this.Load += new System.EventHandler(this.buy_Load);
            this.groupBoxBuy.ResumeLayout(false);
            this.groupBoxBuy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBuy;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.ComboBox comboBoxAcc;
        private System.Windows.Forms.Label label8;
    }
}