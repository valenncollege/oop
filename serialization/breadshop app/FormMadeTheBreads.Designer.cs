namespace ellysaBreadShopApplication
{
    partial class FormMadeTheBreads
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
            this.comboBoxVariantMade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMade = new System.Windows.Forms.Button();
            this.textBoxQuantityMade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(21, 120);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(270, 173);
            this.listBoxData.TabIndex = 30;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(201, 309);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 28);
            this.buttonExit.TabIndex = 29;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBoxVariantMade
            // 
            this.comboBoxVariantMade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVariantMade.FormattingEnabled = true;
            this.comboBoxVariantMade.Location = new System.Drawing.Point(105, 14);
            this.comboBoxVariantMade.Name = "comboBoxVariantMade";
            this.comboBoxVariantMade.Size = new System.Drawing.Size(186, 21);
            this.comboBoxVariantMade.TabIndex = 24;
            this.comboBoxVariantMade.SelectedIndexChanged += new System.EventHandler(this.comboBoxVariantMade_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Variant Name :";
            // 
            // buttonMade
            // 
            this.buttonMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMade.Location = new System.Drawing.Point(105, 75);
            this.buttonMade.Name = "buttonMade";
            this.buttonMade.Size = new System.Drawing.Size(90, 28);
            this.buttonMade.TabIndex = 26;
            this.buttonMade.Text = "MADE";
            this.buttonMade.UseVisualStyleBackColor = true;
            this.buttonMade.Click += new System.EventHandler(this.buttonMade_Click);
            // 
            // textBoxQuantityMade
            // 
            this.textBoxQuantityMade.Location = new System.Drawing.Point(105, 45);
            this.textBoxQuantityMade.Name = "textBoxQuantityMade";
            this.textBoxQuantityMade.Size = new System.Drawing.Size(74, 20);
            this.textBoxQuantityMade.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Quantity :";
            // 
            // FormMadeTheBreads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 349);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.comboBoxVariantMade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonMade);
            this.Controls.Add(this.textBoxQuantityMade);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMadeTheBreads";
            this.Text = "Made the Breads";
            this.Load += new System.EventHandler(this.FormMadeTheBreads_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBoxVariantMade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMade;
        private System.Windows.Forms.TextBox textBoxQuantityMade;
        private System.Windows.Forms.Label label7;
    }
}