namespace ellysaBreadShopApplication
{
    partial class FormSellTheBreads
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
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxVariantSell = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSell = new System.Windows.Forms.Button();
            this.textBoxQuantitySell = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(22, 156);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(282, 160);
            this.listBoxData.TabIndex = 33;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(214, 322);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 28);
            this.buttonExit.TabIndex = 32;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBoxVariantSell
            // 
            this.comboBoxVariantSell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVariantSell.FormattingEnabled = true;
            this.comboBoxVariantSell.Location = new System.Drawing.Point(118, 17);
            this.comboBoxVariantSell.Name = "comboBoxVariantSell";
            this.comboBoxVariantSell.Size = new System.Drawing.Size(186, 21);
            this.comboBoxVariantSell.TabIndex = 25;
            this.comboBoxVariantSell.SelectedIndexChanged += new System.EventHandler(this.comboBoxVariantSell_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Variant Name :";
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPayment.FormattingEnabled = true;
            this.comboBoxPayment.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.comboBoxPayment.Location = new System.Drawing.Point(118, 48);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(186, 21);
            this.comboBoxPayment.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Payment Method :";
            // 
            // buttonSell
            // 
            this.buttonSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSell.Location = new System.Drawing.Point(118, 116);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(90, 28);
            this.buttonSell.TabIndex = 29;
            this.buttonSell.Text = "SELL";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // textBoxQuantitySell
            // 
            this.textBoxQuantitySell.Location = new System.Drawing.Point(118, 79);
            this.textBoxQuantitySell.Name = "textBoxQuantitySell";
            this.textBoxQuantitySell.Size = new System.Drawing.Size(74, 20);
            this.textBoxQuantitySell.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Quantity :";
            // 
            // FormSellTheBreads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 366);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.comboBoxVariantSell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.textBoxQuantitySell);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSellTheBreads";
            this.Text = "Sell the Breads";
            this.Load += new System.EventHandler(this.FormSellTheBreads_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBoxVariantSell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.TextBox textBoxQuantitySell;
        private System.Windows.Forms.Label label5;
    }
}