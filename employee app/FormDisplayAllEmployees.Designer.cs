namespace EllysaEmployeeApplication
{
    partial class FormDisplayAllEmployees
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(267, 395);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(93, 29);
            this.buttonClose.TabIndex = 26;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Employee Data :";
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.Location = new System.Drawing.Point(17, 36);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(344, 355);
            this.listBoxInfo.TabIndex = 24;
            // 
            // FormDisplayAllEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(381, 429);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDisplayAllEmployees";
            this.Text = "Display All Employees";
            this.Load += new System.EventHandler(this.FormDisplayAllEmployees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxInfo;
    }
}