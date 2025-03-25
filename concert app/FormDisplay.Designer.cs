namespace ConcertApp
{
    partial class frmDisplay
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonDisplayAll = new System.Windows.Forms.Button();
            this.buttonMonth = new System.Windows.Forms.Button();
            this.buttonThis = new System.Windows.Forms.Button();
            this.comboBoxConcert = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(574, 276);
            this.listBox1.TabIndex = 0;
            // 
            // buttonDisplayAll
            // 
            this.buttonDisplayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayAll.Location = new System.Drawing.Point(9, 335);
            this.buttonDisplayAll.Name = "buttonDisplayAll";
            this.buttonDisplayAll.Size = new System.Drawing.Size(75, 23);
            this.buttonDisplayAll.TabIndex = 1;
            this.buttonDisplayAll.Text = "Display All";
            this.buttonDisplayAll.UseVisualStyleBackColor = true;
            this.buttonDisplayAll.Click += new System.EventHandler(this.buttonDisplayAll_Click);
            // 
            // buttonMonth
            // 
            this.buttonMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMonth.Location = new System.Drawing.Point(102, 335);
            this.buttonMonth.Name = "buttonMonth";
            this.buttonMonth.Size = new System.Drawing.Size(148, 23);
            this.buttonMonth.TabIndex = 2;
            this.buttonMonth.Text = "Concert This Month";
            this.buttonMonth.UseVisualStyleBackColor = true;
            this.buttonMonth.Click += new System.EventHandler(this.buttonMonth_Click);
            // 
            // buttonThis
            // 
            this.buttonThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThis.Location = new System.Drawing.Point(461, 335);
            this.buttonThis.Name = "buttonThis";
            this.buttonThis.Size = new System.Drawing.Size(125, 23);
            this.buttonThis.TabIndex = 3;
            this.buttonThis.Text = "Show This Concert";
            this.buttonThis.UseVisualStyleBackColor = true;
            this.buttonThis.Click += new System.EventHandler(this.buttonThis_Click);
            // 
            // comboBoxConcert
            // 
            this.comboBoxConcert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxConcert.FormattingEnabled = true;
            this.comboBoxConcert.Location = new System.Drawing.Point(268, 335);
            this.comboBoxConcert.Name = "comboBoxConcert";
            this.comboBoxConcert.Size = new System.Drawing.Size(177, 24);
            this.comboBoxConcert.TabIndex = 4;
            this.comboBoxConcert.SelectedIndexChanged += new System.EventHandler(this.comboBoxConcert_SelectedIndexChanged);
            // 
            // frmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 384);
            this.Controls.Add(this.comboBoxConcert);
            this.Controls.Add(this.buttonThis);
            this.Controls.Add(this.buttonMonth);
            this.Controls.Add(this.buttonDisplayAll);
            this.Controls.Add(this.listBox1);
            this.Name = "frmDisplay";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.frmDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonDisplayAll;
        private System.Windows.Forms.Button buttonMonth;
        private System.Windows.Forms.Button buttonThis;
        private System.Windows.Forms.ComboBox comboBoxConcert;
    }
}