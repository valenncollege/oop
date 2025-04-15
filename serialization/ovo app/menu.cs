using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace FormOvoSimpleApplication
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        public BindingList<JevonOvoAccount> listOvoAcc = new BindingList<JevonOvoAccount>();
        public string defaultFileName = "ovo.acc";

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register formRegist = new register();
            formRegist.Owner = this;
            formRegist.ShowDialog();
        }

        private void dIsplayAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display formDisplay = new display();
            formDisplay.Owner = this;
            formDisplay.ShowDialog();
        }

        private void removeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            remove formRemove = new remove();
            formRemove.Owner = this;
            formRemove.ShowDialog();
        }

        private void topUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            topUp formTopUp = new topUp();
            formTopUp.Owner = this;
            formTopUp.ShowDialog();
        }

        private void buyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buy formBuy = new buy();
            formBuy.Owner = this;
            formBuy.ShowDialog();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
        public void SaveToFile (string filename)
        {
            FileStream myfile = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myfile, listOvoAcc);
            myfile.Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                defaultFileName = dialog.FileName;
                SaveToFile(defaultFileName);
                MessageBox.Show("Your data has been saved to " + dialog.FileName);
            }

        }
        public void OpenToFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                listOvoAcc = (BindingList<JevonOvoAccount>)formatter.Deserialize(file);
                file.Close();
            }
            else
            {
                MessageBox.Show("File is not exist");
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                defaultFileName = dialog.FileName;
                OpenToFile(defaultFileName);
                MessageBox.Show("Your data has been loaded to " + dialog.FileName);
            }
        }
    }
}
