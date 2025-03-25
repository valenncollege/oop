namespace FormOvoSimpleApplication
{
    partial class mainForm
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
            this.groupBoxTopUp = new System.Windows.Forms.GroupBox();
            this.buttonTopUp = new System.Windows.Forms.Button();
            this.textBoxNominalTopUp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.groupBoxBuy = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClearData = new System.Windows.Forms.Button();
            this.buttonDisplayData = new System.Windows.Forms.Button();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxOvoID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxRegisterAccount = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDisplayData = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxAcc = new System.Windows.Forms.ComboBox();
            this.ButtonEx = new System.Windows.Forms.Button();
            this.ButtonRemoveAcc = new System.Windows.Forms.Button();
            this.groupBoxTopUp.SuspendLayout();
            this.groupBoxBuy.SuspendLayout();
            this.groupBoxRegisterAccount.SuspendLayout();
            this.groupBoxDisplayData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTopUp
            // 
            this.groupBoxTopUp.Controls.Add(this.buttonTopUp);
            this.groupBoxTopUp.Controls.Add(this.textBoxNominalTopUp);
            this.groupBoxTopUp.Controls.Add(this.label7);
            this.groupBoxTopUp.Location = new System.Drawing.Point(15, 345);
            this.groupBoxTopUp.Name = "groupBoxTopUp";
            this.groupBoxTopUp.Size = new System.Drawing.Size(326, 140);
            this.groupBoxTopUp.TabIndex = 22;
            this.groupBoxTopUp.TabStop = false;
            this.groupBoxTopUp.Text = "Top Up";
            // 
            // buttonTopUp
            // 
            this.buttonTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTopUp.Location = new System.Drawing.Point(109, 76);
            this.buttonTopUp.Name = "buttonTopUp";
            this.buttonTopUp.Size = new System.Drawing.Size(90, 28);
            this.buttonTopUp.TabIndex = 8;
            this.buttonTopUp.Text = "TOP UP";
            this.buttonTopUp.UseVisualStyleBackColor = true;
            this.buttonTopUp.Click += new System.EventHandler(this.buttonTopUp_Click);
            // 
            // textBoxNominalTopUp
            // 
            this.textBoxNominalTopUp.Location = new System.Drawing.Point(109, 42);
            this.textBoxNominalTopUp.Name = "textBoxNominalTopUp";
            this.textBoxNominalTopUp.Size = new System.Drawing.Size(178, 20);
            this.textBoxNominalTopUp.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nominal Top Up :";
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
            // groupBoxBuy
            // 
            this.groupBoxBuy.Controls.Add(this.comboBoxItems);
            this.groupBoxBuy.Controls.Add(this.label6);
            this.groupBoxBuy.Controls.Add(this.buttonBuy);
            this.groupBoxBuy.Controls.Add(this.textBoxPrice);
            this.groupBoxBuy.Controls.Add(this.label5);
            this.groupBoxBuy.Location = new System.Drawing.Point(349, 345);
            this.groupBoxBuy.Name = "groupBoxBuy";
            this.groupBoxBuy.Size = new System.Drawing.Size(406, 140);
            this.groupBoxBuy.TabIndex = 23;
            this.groupBoxBuy.TabStop = false;
            this.groupBoxBuy.Text = "Buy";
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
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(665, 397);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 28);
            this.buttonExit.TabIndex = 24;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonClearData
            // 
            this.buttonClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearData.Location = new System.Drawing.Point(143, 201);
            this.buttonClearData.Name = "buttonClearData";
            this.buttonClearData.Size = new System.Drawing.Size(117, 28);
            this.buttonClearData.TabIndex = 10;
            this.buttonClearData.Text = "CLEAR DATA";
            this.buttonClearData.UseVisualStyleBackColor = true;
            this.buttonClearData.Click += new System.EventHandler(this.buttonClearData_Click);
            // 
            // buttonDisplayData
            // 
            this.buttonDisplayData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayData.Location = new System.Drawing.Point(20, 202);
            this.buttonDisplayData.Name = "buttonDisplayData";
            this.buttonDisplayData.Size = new System.Drawing.Size(117, 28);
            this.buttonDisplayData.TabIndex = 9;
            this.buttonDisplayData.Text = "DISPLAY DATA";
            this.buttonDisplayData.UseVisualStyleBackColor = true;
            this.buttonDisplayData.Click += new System.EventHandler(this.buttonDisplayData_Click);
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(20, 22);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(378, 173);
            this.listBoxData.TabIndex = 0;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(109, 183);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(90, 28);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "REGISTER";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxOvoID
            // 
            this.textBoxOvoID.Location = new System.Drawing.Point(109, 146);
            this.textBoxOvoID.Name = "textBoxOvoID";
            this.textBoxOvoID.Size = new System.Drawing.Size(178, 20);
            this.textBoxOvoID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ovo ID :";
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.Location = new System.Drawing.Point(109, 110);
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.PasswordChar = '*';
            this.textBoxPIN.Size = new System.Drawing.Size(178, 20);
            this.textBoxPIN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PIN :";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(109, 73);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(178, 20);
            this.textBoxPhoneNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Number :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(109, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(178, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // groupBoxRegisterAccount
            // 
            this.groupBoxRegisterAccount.Controls.Add(this.buttonRegister);
            this.groupBoxRegisterAccount.Controls.Add(this.textBoxOvoID);
            this.groupBoxRegisterAccount.Controls.Add(this.label4);
            this.groupBoxRegisterAccount.Controls.Add(this.textBoxPIN);
            this.groupBoxRegisterAccount.Controls.Add(this.label3);
            this.groupBoxRegisterAccount.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxRegisterAccount.Controls.Add(this.label2);
            this.groupBoxRegisterAccount.Controls.Add(this.textBoxName);
            this.groupBoxRegisterAccount.Controls.Add(this.label1);
            this.groupBoxRegisterAccount.Location = new System.Drawing.Point(15, 9);
            this.groupBoxRegisterAccount.Name = "groupBoxRegisterAccount";
            this.groupBoxRegisterAccount.Size = new System.Drawing.Size(326, 236);
            this.groupBoxRegisterAccount.TabIndex = 20;
            this.groupBoxRegisterAccount.TabStop = false;
            this.groupBoxRegisterAccount.Text = "Register Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // groupBoxDisplayData
            // 
            this.groupBoxDisplayData.Controls.Add(this.buttonClearData);
            this.groupBoxDisplayData.Controls.Add(this.buttonDisplayData);
            this.groupBoxDisplayData.Controls.Add(this.listBoxData);
            this.groupBoxDisplayData.Location = new System.Drawing.Point(349, 9);
            this.groupBoxDisplayData.Name = "groupBoxDisplayData";
            this.groupBoxDisplayData.Size = new System.Drawing.Size(406, 236);
            this.groupBoxDisplayData.TabIndex = 21;
            this.groupBoxDisplayData.TabStop = false;
            this.groupBoxDisplayData.Text = "Display Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Choose Account";
            // 
            // comboBoxAcc
            // 
            this.comboBoxAcc.FormattingEnabled = true;
            this.comboBoxAcc.Location = new System.Drawing.Point(284, 289);
            this.comboBoxAcc.Name = "comboBoxAcc";
            this.comboBoxAcc.Size = new System.Drawing.Size(161, 21);
            this.comboBoxAcc.TabIndex = 26;
            this.comboBoxAcc.SelectedIndexChanged += new System.EventHandler(this.comboBoxAcc_SelectedIndexChanged);
            // 
            // ButtonEx
            // 
            this.ButtonEx.Location = new System.Drawing.Point(317, 507);
            this.ButtonEx.Name = "ButtonEx";
            this.ButtonEx.Size = new System.Drawing.Size(75, 23);
            this.ButtonEx.TabIndex = 27;
            this.ButtonEx.Text = "Exit";
            this.ButtonEx.UseVisualStyleBackColor = true;
            this.ButtonEx.Click += new System.EventHandler(this.ButtonEx_Click);
            // 
            // ButtonRemoveAcc
            // 
            this.ButtonRemoveAcc.Location = new System.Drawing.Point(513, 296);
            this.ButtonRemoveAcc.Name = "ButtonRemoveAcc";
            this.ButtonRemoveAcc.Size = new System.Drawing.Size(112, 23);
            this.ButtonRemoveAcc.TabIndex = 28;
            this.ButtonRemoveAcc.Text = "Remove Account";
            this.ButtonRemoveAcc.UseVisualStyleBackColor = true;
            this.ButtonRemoveAcc.Click += new System.EventHandler(this.ButtonRemoveAcc_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 690);
            this.Controls.Add(this.ButtonRemoveAcc);
            this.Controls.Add(this.ButtonEx);
            this.Controls.Add(this.comboBoxAcc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBoxTopUp);
            this.Controls.Add(this.groupBoxBuy);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxRegisterAccount);
            this.Controls.Add(this.groupBoxDisplayData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
            this.Text = "Ovo Simple Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTopUp.ResumeLayout(false);
            this.groupBoxTopUp.PerformLayout();
            this.groupBoxBuy.ResumeLayout(false);
            this.groupBoxBuy.PerformLayout();
            this.groupBoxRegisterAccount.ResumeLayout(false);
            this.groupBoxRegisterAccount.PerformLayout();
            this.groupBoxDisplayData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTopUp;
        private System.Windows.Forms.Button buttonTopUp;
        private System.Windows.Forms.TextBox textBoxNominalTopUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.GroupBox groupBoxBuy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClearData;
        private System.Windows.Forms.Button buttonDisplayData;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxOvoID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxRegisterAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDisplayData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxAcc;
        private System.Windows.Forms.Button ButtonEx;
        private System.Windows.Forms.Button ButtonRemoveAcc;
    }
}

