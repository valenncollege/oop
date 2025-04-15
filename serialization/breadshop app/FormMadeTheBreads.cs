using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ellysaBreadShopApplication
{
    public partial class FormMadeTheBreads : Form
    {
        public FormMadeTheBreads()
        {
            InitializeComponent();
        }
        FormMain formUtama;
        JevonBreadClass SelectedBread;
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMadeTheBreads_Load(object sender, EventArgs e)
        {
            formUtama = (FormMain)this.Owner;
            comboBoxVariantMade.DataSource = formUtama.ListRoti;
            comboBoxVariantMade.DisplayMember = "Name";
        }

        private void comboBoxVariantMade_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedBread = (JevonBreadClass)comboBoxVariantMade.SelectedValue;
        }

        private void buttonMade_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            listBoxData.Items.Add("Current stock = " + SelectedBread.Stock);
            try
            {
                if (SelectedBread != null)
                {
                    int jumlah = int.Parse(textBoxQuantityMade.Text);
                    listBoxData.Items.Add(SelectedBread.BuatRoti(jumlah));
                    listBoxData.Items.Add("Result : ");
                    listBoxData.Items.AddRange(SelectedBread.Format().Split('\n'));
                    formUtama.SaveData(formUtama.defaultNamaFile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
