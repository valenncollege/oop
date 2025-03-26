namespace EllysaBreadShopApplication
{
    partial class Form1
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
            this.groupBoxSellTheBread = new System.Windows.Forms.GroupBox();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSell = new System.Windows.Forms.Button();
            this.textBoxQuantitySell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBoxBreadVariant = new System.Windows.Forms.ComboBox();
            this.groupBoxMadeTheBread = new System.Windows.Forms.GroupBox();
            this.buttonMade = new System.Windows.Forms.Button();
            this.textBoxQuantityMade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDisplayAll = new System.Windows.Forms.Button();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.groupBoxAddNewVariant = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxSellTheBread.SuspendLayout();
            this.groupBoxMadeTheBread.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.groupBoxAddNewVariant.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSellTheBread
            // 
            this.groupBoxSellTheBread.Controls.Add(this.comboBoxPayment);
            this.groupBoxSellTheBread.Controls.Add(this.label6);
            this.groupBoxSellTheBread.Controls.Add(this.buttonSell);
            this.groupBoxSellTheBread.Controls.Add(this.textBoxQuantitySell);
            this.groupBoxSellTheBread.Controls.Add(this.label4);
            this.groupBoxSellTheBread.Controls.Add(this.button5);
            this.groupBoxSellTheBread.Location = new System.Drawing.Point(14, 428);
            this.groupBoxSellTheBread.Name = "groupBoxSellTheBread";
            this.groupBoxSellTheBread.Size = new System.Drawing.Size(469, 183);
            this.groupBoxSellTheBread.TabIndex = 41;
            this.groupBoxSellTheBread.TabStop = false;
            this.groupBoxSellTheBread.Text = "Sell the Bread";
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPayment.FormattingEnabled = true;
            this.comboBoxPayment.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.comboBoxPayment.Location = new System.Drawing.Point(164, 47);
            this.comboBoxPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(137, 28);
            this.comboBoxPayment.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Payment Method :";
            // 
            // buttonSell
            // 
            this.buttonSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSell.Location = new System.Drawing.Point(166, 139);
            this.buttonSell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(135, 43);
            this.buttonSell.TabIndex = 2;
            this.buttonSell.Text = "SELL";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // textBoxQuantitySell
            // 
            this.textBoxQuantitySell.Location = new System.Drawing.Point(164, 94);
            this.textBoxQuantitySell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxQuantitySell.Name = "textBoxQuantitySell";
            this.textBoxQuantitySell.Size = new System.Drawing.Size(109, 26);
            this.textBoxQuantitySell.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Quantity :";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(295, 540);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 43);
            this.button5.TabIndex = 32;
            this.button5.Text = "EXIT";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // comboBoxBreadVariant
            // 
            this.comboBoxBreadVariant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBreadVariant.FormattingEnabled = true;
            this.comboBoxBreadVariant.Location = new System.Drawing.Point(176, 232);
            this.comboBoxBreadVariant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxBreadVariant.Name = "comboBoxBreadVariant";
            this.comboBoxBreadVariant.Size = new System.Drawing.Size(267, 28);
            this.comboBoxBreadVariant.TabIndex = 39;
            this.comboBoxBreadVariant.SelectedIndexChanged += new System.EventHandler(this.comboBoxBreadVariant_SelectedIndexChanged);
            // 
            // groupBoxMadeTheBread
            // 
            this.groupBoxMadeTheBread.Controls.Add(this.buttonMade);
            this.groupBoxMadeTheBread.Controls.Add(this.textBoxQuantityMade);
            this.groupBoxMadeTheBread.Controls.Add(this.label5);
            this.groupBoxMadeTheBread.Controls.Add(this.button1);
            this.groupBoxMadeTheBread.Location = new System.Drawing.Point(14, 283);
            this.groupBoxMadeTheBread.Name = "groupBoxMadeTheBread";
            this.groupBoxMadeTheBread.Size = new System.Drawing.Size(469, 139);
            this.groupBoxMadeTheBread.TabIndex = 40;
            this.groupBoxMadeTheBread.TabStop = false;
            this.groupBoxMadeTheBread.Text = "Made the Bread";
            // 
            // buttonMade
            // 
            this.buttonMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMade.Location = new System.Drawing.Point(164, 89);
            this.buttonMade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMade.Name = "buttonMade";
            this.buttonMade.Size = new System.Drawing.Size(135, 43);
            this.buttonMade.TabIndex = 1;
            this.buttonMade.Text = "MADE";
            this.buttonMade.UseVisualStyleBackColor = true;
            this.buttonMade.Click += new System.EventHandler(this.buttonMade_Click);
            // 
            // textBoxQuantityMade
            // 
            this.textBoxQuantityMade.Location = new System.Drawing.Point(164, 44);
            this.textBoxQuantityMade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxQuantityMade.Name = "textBoxQuantityMade";
            this.textBoxQuantityMade.Size = new System.Drawing.Size(109, 26);
            this.textBoxQuantityMade.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Quantity :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(295, 540);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 43);
            this.button1.TabIndex = 32;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.buttonExit);
            this.groupBoxData.Controls.Add(this.buttonClear);
            this.groupBoxData.Controls.Add(this.buttonDisplayAll);
            this.groupBoxData.Controls.Add(this.listBoxData);
            this.groupBoxData.Location = new System.Drawing.Point(506, 1);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(524, 613);
            this.groupBoxData.TabIndex = 42;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Data";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(367, 552);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(135, 43);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(197, 552);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(152, 43);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDisplayAll
            // 
            this.buttonDisplayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayAll.Location = new System.Drawing.Point(24, 552);
            this.buttonDisplayAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDisplayAll.Name = "buttonDisplayAll";
            this.buttonDisplayAll.Size = new System.Drawing.Size(152, 43);
            this.buttonDisplayAll.TabIndex = 0;
            this.buttonDisplayAll.Text = "DISPLAY ALL";
            this.buttonDisplayAll.UseVisualStyleBackColor = true;
            this.buttonDisplayAll.Click += new System.EventHandler(this.buttonDisplayAll_Click);
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 20;
            this.listBoxData.Location = new System.Drawing.Point(22, 33);
            this.listBoxData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(480, 504);
            this.listBoxData.TabIndex = 31;
            // 
            // groupBoxAddNewVariant
            // 
            this.groupBoxAddNewVariant.Controls.Add(this.buttonAdd);
            this.groupBoxAddNewVariant.Controls.Add(this.textBoxPrice);
            this.groupBoxAddNewVariant.Controls.Add(this.textBoxName);
            this.groupBoxAddNewVariant.Controls.Add(this.label2);
            this.groupBoxAddNewVariant.Controls.Add(this.label1);
            this.groupBoxAddNewVariant.Location = new System.Drawing.Point(14, 15);
            this.groupBoxAddNewVariant.Name = "groupBoxAddNewVariant";
            this.groupBoxAddNewVariant.Size = new System.Drawing.Size(469, 188);
            this.groupBoxAddNewVariant.TabIndex = 38;
            this.groupBoxAddNewVariant.TabStop = false;
            this.groupBoxAddNewVariant.Text = "Add New Variant";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(166, 134);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(135, 43);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(166, 88);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(133, 26);
            this.textBoxPrice.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(166, 44);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(265, 26);
            this.textBoxName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Variant Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Select Bread Variant :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 623);
            this.Controls.Add(this.groupBoxSellTheBread);
            this.Controls.Add(this.comboBoxBreadVariant);
            this.Controls.Add(this.groupBoxMadeTheBread);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.groupBoxAddNewVariant);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Bread Shop Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSellTheBread.ResumeLayout(false);
            this.groupBoxSellTheBread.PerformLayout();
            this.groupBoxMadeTheBread.ResumeLayout(false);
            this.groupBoxMadeTheBread.PerformLayout();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxAddNewVariant.ResumeLayout(false);
            this.groupBoxAddNewVariant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSellTheBread;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.TextBox textBoxQuantitySell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBoxBreadVariant;
        private System.Windows.Forms.GroupBox groupBoxMadeTheBread;
        private System.Windows.Forms.Button buttonMade;
        private System.Windows.Forms.TextBox textBoxQuantityMade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDisplayAll;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.GroupBox groupBoxAddNewVariant;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

