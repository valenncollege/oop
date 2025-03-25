namespace FormOvoSimpleApplication
{
    partial class display
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
            this.groupBoxDisplayData = new System.Windows.Forms.GroupBox();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxDisplayData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDisplayData
            // 
            this.groupBoxDisplayData.Controls.Add(this.listBoxData);
            this.groupBoxDisplayData.Location = new System.Drawing.Point(38, 23);
            this.groupBoxDisplayData.Name = "groupBoxDisplayData";
            this.groupBoxDisplayData.Size = new System.Drawing.Size(406, 236);
            this.groupBoxDisplayData.TabIndex = 22;
            this.groupBoxDisplayData.TabStop = false;
            this.groupBoxDisplayData.Text = "Display Data";
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(20, 22);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(378, 173);
            this.listBoxData.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(450, 137);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 23;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 291);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxDisplayData);
            this.Name = "display";
            this.Text = "display";
            this.Load += new System.EventHandler(this.display_Load);
            this.groupBoxDisplayData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDisplayData;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonClose;
    }
}