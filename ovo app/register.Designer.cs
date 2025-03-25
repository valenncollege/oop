namespace FormOvoSimpleApplication
{
    partial class register
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
            this.groupBoxRegisterAccount = new System.Windows.Forms.GroupBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxOvoID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.groupBoxRegisterAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRegisterAccount
            // 
            this.groupBoxRegisterAccount.Controls.Add(this.buttonClose);
            this.groupBoxRegisterAccount.Controls.Add(this.buttonRegister);
            this.groupBoxRegisterAccount.Controls.Add(this.textBoxOvoID);
            this.groupBoxRegisterAccount.Controls.Add(this.label4);
            this.groupBoxRegisterAccount.Controls.Add(this.textBoxPIN);
            this.groupBoxRegisterAccount.Controls.Add(this.label3);
            this.groupBoxRegisterAccount.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxRegisterAccount.Controls.Add(this.label2);
            this.groupBoxRegisterAccount.Controls.Add(this.textBoxName);
            this.groupBoxRegisterAccount.Controls.Add(this.label1);
            this.groupBoxRegisterAccount.Location = new System.Drawing.Point(53, 33);
            this.groupBoxRegisterAccount.Name = "groupBoxRegisterAccount";
            this.groupBoxRegisterAccount.Size = new System.Drawing.Size(326, 236);
            this.groupBoxRegisterAccount.TabIndex = 21;
            this.groupBoxRegisterAccount.TabStop = false;
            this.groupBoxRegisterAccount.Text = "Register Account";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(212, 188);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 23;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(396, 33);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(378, 238);
            this.listBoxData.TabIndex = 22;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.groupBoxRegisterAccount);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.groupBoxRegisterAccount.ResumeLayout(false);
            this.groupBoxRegisterAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRegisterAccount;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxOvoID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonClose;
    }
}