using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOvoSimpleApplication
{
    public partial class buy : Form
    {
        menu formUtama;
        JevonOvoAccount selectedAcc;
        public buy()
        {
            InitializeComponent();
        }

        private void comboBoxAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAcc = (JevonOvoAccount)comboBoxAcc.SelectedValue;

        }

        private void buy_Load(object sender, EventArgs e)
        {
            formUtama = (menu)this.Owner;
            comboBoxAcc.DataSource = formUtama.listOvoAcc;
            comboBoxAcc.DisplayMember = "OvoID";
            comboBoxAcc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            try
            {
                if (selectedAcc != null)
                {
                    string jenis = comboBoxItems.SelectedItem.ToString();
                    int harga = int.Parse(textBoxPrice.Text);
                    selectedAcc.Buy(jenis, harga);
                    listBoxData.Items.Add("You have been buy " + jenis + " with price " + harga);
                    listBoxData.Items.AddRange(selectedAcc.FormatData().Split('\n'));
                    //save data
                    formUtama.SaveToFile(formUtama.defaultFileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
