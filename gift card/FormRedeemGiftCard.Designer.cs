namespace EllysaGiftCardApplication
{
    partial class FormRedeemGiftCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRedeemGiftCard));
            this.buttonRedeemGiftCard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerRedeemDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownTotal = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGiftCard = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRedeemGiftCard
            // 
            this.buttonRedeemGiftCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonRedeemGiftCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedeemGiftCard.Location = new System.Drawing.Point(182, 141);
            this.buttonRedeemGiftCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRedeemGiftCard.Name = "buttonRedeemGiftCard";
            this.buttonRedeemGiftCard.Size = new System.Drawing.Size(165, 26);
            this.buttonRedeemGiftCard.TabIndex = 3;
            this.buttonRedeemGiftCard.Text = "REDEEM GIFT CARD";
            this.buttonRedeemGiftCard.UseVisualStyleBackColor = false;
            this.buttonRedeemGiftCard.Click += new System.EventHandler(this.buttonRedeemGiftCard_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.dateTimePickerRedeemDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericUpDownTotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxGiftCard);
            this.panel1.Controls.Add(this.buttonRedeemGiftCard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 190);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePickerRedeemDate
            // 
            this.dateTimePickerRedeemDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRedeemDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRedeemDate.Location = new System.Drawing.Point(182, 65);
            this.dateTimePickerRedeemDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerRedeemDate.Name = "dateTimePickerRedeemDate";
            this.dateTimePickerRedeemDate.Size = new System.Drawing.Size(103, 23);
            this.dateTimePickerRedeemDate.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(65, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 63;
            this.label5.Text = "Redeem Date :";
            // 
            // numericUpDownTotal
            // 
            this.numericUpDownTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTotal.Location = new System.Drawing.Point(183, 104);
            this.numericUpDownTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownTotal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownTotal.Name = "numericUpDownTotal";
            this.numericUpDownTotal.Size = new System.Drawing.Size(101, 23);
            this.numericUpDownTotal.TabIndex = 2;
            this.numericUpDownTotal.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Total Transaction (Rp) :";
            // 
            // comboBoxGiftCard
            // 
            this.comboBoxGiftCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGiftCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGiftCard.FormattingEnabled = true;
            this.comboBoxGiftCard.Location = new System.Drawing.Point(182, 24);
            this.comboBoxGiftCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxGiftCard.Name = "comboBoxGiftCard";
            this.comboBoxGiftCard.Size = new System.Drawing.Size(103, 24);
            this.comboBoxGiftCard.TabIndex = 0;
            this.comboBoxGiftCard.SelectedIndexChanged += new System.EventHandler(this.comboBoxGiftCard_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Select Gift Card :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 40);
            this.label4.TabIndex = 52;
            this.label4.Text = "Redeem Gift Card";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRedeemGiftCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(375, 257);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormRedeemGiftCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redeem Gift Card";
            this.Load += new System.EventHandler(this.FormRedeemGiftCard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRedeemGiftCard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxGiftCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownTotal;
        private System.Windows.Forms.DateTimePicker dateTimePickerRedeemDate;
        private System.Windows.Forms.Label label5;
    }
}