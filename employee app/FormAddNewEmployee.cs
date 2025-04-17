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
    public partial class FormAddNewEmployee : Form
    {
        public FormAddNewEmployee()
        {
            InitializeComponent();
        }
        FormMain formUtama;
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        JevonEmployee newEmployee;
        int counterId;
        private void buttonAdd_Click(object sender, EventArgs e)
        {           
            try
            {
                           
                #region input data
                int id = int.Parse(textBoxEmployeeID.Text);
                string name = textBoxName.Text;
                int salary = (int)numericUpDownBasicSalary.Value;
                string gender;
                if (radioButtonMale.Checked == true)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                DateTime startWork = dateTimePickerStartWork.Value;
                int child = (int)numericUpDownNumOfChild.Value;
                #endregion
                newEmployee = new JevonEmployee(id, name, salary, gender, startWork, child);

                formUtama.ListEmployee.Add(newEmployee);

                counterId = formUtama.ListEmployee.Count + 1;
                textBoxEmployeeID.Text = (counterId).ToString();

                formUtama.SaveFile(formUtama.defaultFileName);
                MessageBox.Show("Data has been saved !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormAddNewEmployee_Load(object sender, EventArgs e)
        {
            formUtama = (FormMain)this.Owner;
            textBoxEmployeeID.ReadOnly = true;
            counterId = formUtama.ListEmployee.Count + 1;
            textBoxEmployeeID.Text = counterId.ToString();
            
        }
    }
}
