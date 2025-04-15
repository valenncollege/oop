namespace FormOvoSimpleApplication
{
    partial class topUp
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
            this.comboBoxAcc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.groupBoxTopUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTopUp
            // 
            this.groupBoxTopUp.Controls.Add(this.buttonTopUp);
            this.groupBoxTopUp.Controls.Add(this.textBoxNominalTopUp);
            this.groupBoxTopUp.Controls.Add(this.label7);
            this.groupBoxTopUp.Location = new System.Drawing.Point(40, 45);
            this.groupBoxTopUp.Name = "groupBoxTopUp";
            this.groupBoxTopUp.Size = new System.Drawing.Size(326, 140);
            this.groupBoxTopUp.TabIndex = 23;
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
            // comboBoxAcc
            // 
            this.comboBoxAcc.FormattingEnabled = true;
            this.comboBoxAcc.Location = new System.Drawing.Point(166, 18);
            this.comboBoxAcc.Name = "comboBoxAcc";
            this.comboBoxAcc.Size = new System.Drawing.Size(161, 21);
            this.comboBoxAcc.TabIndex = 28;
            this.comboBoxAcc.SelectedIndexChanged += new System.EventHandler(this.comboBoxAcc_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Choose Account";
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(396, 34);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(341, 173);
            this.listBoxData.TabIndex = 29;
            // 
            // topUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 268);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.comboBoxAcc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBoxTopUp);
            this.Name = "topUp";
            this.Text = "topUp";
            this.Load += new System.EventHandler(this.topUp_Load);
            this.groupBoxTopUp.ResumeLayout(false);
            this.groupBoxTopUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTopUp;
        private System.Windows.Forms.Button buttonTopUp;
        private System.Windows.Forms.TextBox textBoxNominalTopUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxAcc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxData;
    }
}