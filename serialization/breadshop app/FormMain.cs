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

namespace ellysaBreadShopApplication
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public BindingList<JevonBreadClass> ListRoti = new BindingList<JevonBreadClass>();
        public string defaultNamaFile = "Bread.brd";
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewVariantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddNewVariant formInput = new FormAddNewVariant();
            formInput.Owner = this;
            formInput.ShowDialog();
        }

        private void displayAllBreadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplayAllBreads formDisplay = new FormDisplayAllBreads();
            formDisplay.Owner = this;
            formDisplay.ShowDialog();
            
        }

        private void madeTheBreadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMadeTheBreads formMade = new FormMadeTheBreads();
            formMade.Owner = this;
            formMade.ShowDialog();
        }

        private void sellTheBreadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSellTheBreads formSell = new FormSellTheBreads();
            formSell.Owner = this;
            formSell.ShowDialog();
        }

        public void SaveData(string filename)
        {
            FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, ListRoti);
            file.Close();
        }
        public void ReadData(string filename)
        {
            if (File.Exists(filename))
            {
                FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                ListRoti = (BindingList<JevonBreadClass>)formatter.Deserialize(file);
                file.Close();
                
            }
            else
            {
                MessageBox.Show("File is not exist");
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                defaultNamaFile = dialog.FileName;
                SaveData(defaultNamaFile);
                MessageBox.Show("Your data has been saved to " + dialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                defaultNamaFile = dialog.FileName;
                ReadData(defaultNamaFile);
                MessageBox.Show("Your data has been loaded to " + dialog.FileName);
            }
        }
    }
}
