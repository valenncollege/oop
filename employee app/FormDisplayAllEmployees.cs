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
    public partial class FormDisplayAllEmployees : Form
    {
        public FormDisplayAllEmployees()
        {
            InitializeComponent();
        }
        FormMain formUtama;
        private void FormDisplayAllEmployees_Load(object sender, EventArgs e)
        {
            formUtama = (FormMain)this.Owner;
            foreach (JevonEmployee newEmp in formUtama.ListEmployee)
            {
                listBoxInfo.Items.Add("Employee ID : " + newEmp.EmployeeId);
                listBoxInfo.Items.Add("Name : " + newEmp.Name);
                listBoxInfo.Items.Add("Basic Salary : " + newEmp.BasicSalary);
                listBoxInfo.Items.Add("Gender : " + newEmp.Gender);
                listBoxInfo.Items.Add("Starting Work : " + newEmp.StartingWork.ToShortDateString());
                listBoxInfo.Items.Add("Number of Child : " + newEmp.NumberOfChild);
                double childAllowance = newEmp.CalcChildAllowance();    
                listBoxInfo.Items.Add("Child allowance : " + childAllowance);
                listBoxInfo.Items.Add("");

            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
