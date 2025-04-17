using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EllysaEmployeeApplication
{
    public partial class FormCalculateIncentive : Form
    {
        public FormCalculateIncentive()
        {
            InitializeComponent();
        }
        FormMain formUtama;
        JevonEmployee SelectedEmp;
        private void FormCalculateIncentive_Load(object sender, EventArgs e)
        {
            formUtama = (FormMain)this.Owner;
            comboBoxEmployeeId.DataSource = formUtama.ListEmployee;
            comboBoxEmployeeId.DisplayMember = "EmployeeId";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxEmployeeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedEmp = (JevonEmployee)comboBoxEmployeeId.SelectedValue;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int totalSales = int.Parse(textBoxTotalSales.Text);
            double result = SelectedEmp.CalcIncentive(totalSales);
            MessageBox.Show("Employee Id : " + SelectedEmp.EmployeeId + "\n" +
                "Name : " + SelectedEmp.Name + "\n" +
                "Total Sales : " + totalSales + "\n" +
                "Incentive : " + result
                );
        }
    }
}
