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

namespace EllysaGiftCardApplication
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }
        public BindingList<JevonGiftCard> ListGiftCard = new BindingList<JevonGiftCard>();
        public string defaulFileName = "giftcards.dat";
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createGiftCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateGiftCard formCreate = new FormCreateGiftCard();
            formCreate.Owner = this;
            formCreate.ShowDialog();
        }

        private void deleteGiftCardtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeleteGiftCard formDel = new FormDeleteGiftCard();
            formDel.Owner = this;
            formDel.ShowDialog();
        }

        private void allGiftCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAllGiftCards formAll = new FormAllGiftCards();
            formAll.Owner = this;
            formAll.ShowDialog();
        }

        private void redeemGiftCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRedeemGiftCard formRedeem = new FormRedeemGiftCard();
            formRedeem.Owner = this;
            formRedeem.ShowDialog();
        }

        public void SaveFile(string fileName)
        {
            FileStream myfile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myfile, ListGiftCard);
            myfile.Close();
        }
        public void LoadFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                ListGiftCard = (BindingList<JevonGiftCard>)formatter.Deserialize(file);
                file.Close();
            }
            else
            {
                MessageBox.Show("File is not exist");
            }
        }

        private void exportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                defaulFileName = dialog.FileName;
                SaveFile(defaulFileName);
                MessageBox.Show("Your data has been saved to " + dialog.FileName);
            }
        }

        private void importDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                defaulFileName = dialog.FileName;
                LoadFile(defaulFileName);
                MessageBox.Show("Your data has been loaded to " + dialog.FileName);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadFile(defaulFileName);
        }
    }
}
