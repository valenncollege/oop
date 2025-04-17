using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EllysaEmployeeApplication
{
    public partial class FormMain : Form
    {
        public BindingList<JevonEmployee> ListEmployee = new BindingList<JevonEmployee>();
        public string defaultFileName = "employee.dat";

        public FormMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddNewEmployee formNewEmployee = new FormAddNewEmployee();
            formNewEmployee.Owner = this;
            formNewEmployee.ShowDialog();
        }

        private void displayAllEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplayAllEmployees formDisplay = new FormDisplayAllEmployees();
            formDisplay.Owner = this;
            formDisplay.ShowDialog();
        }

        private void calculateIncentiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalculateIncentive formCalc = new FormCalculateIncentive();
            formCalc.Owner = this;
            formCalc.ShowDialog();
        }

        public void SaveFile(string fileName)
        {
            FileStream myfile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myfile, ListEmployee);
            myfile.Close();
        }
    
        public void LoadFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                ListEmployee = (BindingList<JevonEmployee>)formatter.Deserialize(file);
                file.Close();
            }
            else
            {
                MessageBox.Show("File is not exist");
            }
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                defaultFileName = dialog.FileName;
                LoadFile(defaultFileName);
                MessageBox.Show("Your data has been loaded to " + dialog.FileName);
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                defaultFileName = dialog.FileName;
                SaveFile(defaultFileName);
                MessageBox.Show("Your data has been saved to " + dialog.FileName);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadFile(defaultFileName);
        }
    }
    }

