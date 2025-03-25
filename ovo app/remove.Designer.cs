namespace FormOvoSimpleApplication
{
    partial class remove
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
            this.ButtonRemoveAcc = new System.Windows.Forms.Button();
            this.comboBoxAcc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonRemoveAcc
            // 
            this.ButtonRemoveAcc.Location = new System.Drawing.Point(406, 66);
            this.ButtonRemoveAcc.Name = "ButtonRemoveAcc";
            this.ButtonRemoveAcc.Size = new System.Drawing.Size(112, 23);
            this.ButtonRemoveAcc.TabIndex = 31;
            this.ButtonRemoveAcc.Text = "Remove Account";
            this.ButtonRemoveAcc.UseVisualStyleBackColor = true;
            this.ButtonRemoveAcc.Click += new System.EventHandler(this.ButtonRemoveAcc_Click);
            // 
            // comboBoxAcc
            // 
            this.comboBoxAcc.FormattingEnabled = true;
            this.comboBoxAcc.Location = new System.Drawing.Point(177, 59);
            this.comboBoxAcc.Name = "comboBoxAcc";
            this.comboBoxAcc.Size = new System.Drawing.Size(161, 21);
            this.comboBoxAcc.TabIndex = 30;
            this.comboBoxAcc.SelectedIndexChanged += new System.EventHandler(this.comboBoxAcc_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Choose Account";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(207, 117);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 32;
            this.buttonClose.Text = "Exit";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 149);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.ButtonRemoveAcc);
            this.Controls.Add(this.comboBoxAcc);
            this.Controls.Add(this.label8);
            this.Name = "remove";
            this.Text = "remove";
            this.Load += new System.EventHandler(this.remove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonRemoveAcc;
        private System.Windows.Forms.ComboBox comboBoxAcc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonClose;
    }
}