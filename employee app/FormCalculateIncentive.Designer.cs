namespace EllysaEmployeeApplication
{
    partial class FormCalculateIncentive
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
            this.comboBoxEmployeeId = new System.Windows.Forms.ComboBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxTotalSales = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(226, 138);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(89, 27);
            this.buttonClose.TabIndex = 31;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // comboBoxEmployeeId
            // 
            this.comboBoxEmployeeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployeeId.FormattingEnabled = true;
            this.comboBoxEmployeeId.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxEmployeeId.Location = new System.Drawing.Point(114, 76);
            this.comboBoxEmployeeId.Name = "comboBoxEmployeeId";
            this.comboBoxEmployeeId.Size = new System.Drawing.Size(108, 21);
            this.comboBoxEmployeeId.TabIndex = 25;
            this.comboBoxEmployeeId.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployeeId_SelectedIndexChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.White;
            this.buttonCalculate.Location = new System.Drawing.Point(114, 138);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(107, 27);
            this.buttonCalculate.TabIndex = 27;
            this.buttonCalculate.Text = "CALCULATE";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxTotalSales
            // 
            this.textBoxTotalSales.Location = new System.Drawing.Point(115, 108);
            this.textBoxTotalSales.Name = "textBoxTotalSales";
            this.textBoxTotalSales.Size = new System.Drawing.Size(107, 20);
            this.textBoxTotalSales.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Total Sales ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Employee ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 31);
            this.label7.TabIndex = 46;
            this.label7.Text = "Calculate Incentive";
            // 
            // FormCalculateIncentive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(346, 179);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.comboBoxEmployeeId);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxTotalSales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCalculateIncentive";
            this.Text = "Calculate Incentive";
            this.Load += new System.EventHandler(this.FormCalculateIncentive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ComboBox comboBoxEmployeeId;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxTotalSales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}