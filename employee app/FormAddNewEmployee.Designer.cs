namespace EllysaEmployeeApplication
{
    partial class FormAddNewEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePickerStartWork = new System.Windows.Forms.DateTimePicker();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownBasicSalary = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumOfChild = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBasicSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfChild)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Number of Child";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(190, 168);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(65, 17);
            this.radioButtonFemale.TabIndex = 4;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(123, 168);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(52, 17);
            this.radioButtonMale.TabIndex = 3;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(210, 263);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(78, 31);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(123, 263);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(81, 31);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dateTimePickerStartWork
            // 
            this.dateTimePickerStartWork.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartWork.Location = new System.Drawing.Point(123, 198);
            this.dateTimePickerStartWork.Name = "dateTimePickerStartWork";
            this.dateTimePickerStartWork.Size = new System.Drawing.Size(142, 20);
            this.dateTimePickerStartWork.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(123, 105);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(142, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Location = new System.Drawing.Point(123, 72);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(90, 20);
            this.textBoxEmployeeID.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Starting Work";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Basic Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Employee ID";
            // 
            // numericUpDownBasicSalary
            // 
            this.numericUpDownBasicSalary.Location = new System.Drawing.Point(123, 137);
            this.numericUpDownBasicSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownBasicSalary.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownBasicSalary.Name = "numericUpDownBasicSalary";
            this.numericUpDownBasicSalary.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownBasicSalary.TabIndex = 2;
            // 
            // numericUpDownNumOfChild
            // 
            this.numericUpDownNumOfChild.Location = new System.Drawing.Point(125, 229);
            this.numericUpDownNumOfChild.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownNumOfChild.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownNumOfChild.Name = "numericUpDownNumOfChild";
            this.numericUpDownNumOfChild.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownNumOfChild.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 31);
            this.label7.TabIndex = 45;
            this.label7.Text = "Add Employee";
            // 
            // FormAddNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(309, 306);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownNumOfChild);
            this.Controls.Add(this.numericUpDownBasicSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimePickerStartWork);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxEmployeeID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAddNewEmployee";
            this.Text = "Add New Employee";
            this.Load += new System.EventHandler(this.FormAddNewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBasicSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfChild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartWork;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownBasicSalary;
        private System.Windows.Forms.NumericUpDown numericUpDownNumOfChild;
        private System.Windows.Forms.Label label7;
    }
}