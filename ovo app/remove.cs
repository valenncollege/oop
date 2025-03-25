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
    public partial class remove : Form
    {
        public remove()
        {
            InitializeComponent();
        }
        menu formUtama;
        JevonOvoAccount selectedAcc;
        private void comboBoxAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAcc = (JevonOvoAccount)comboBoxAcc.SelectedValue;
        }

        private void remove_Load(object sender, EventArgs e)
        {
            formUtama = (menu)this.Owner;
            comboBoxAcc.DataSource = formUtama.listOvoAcc;
            comboBoxAcc.DisplayMember = "OvoID";
            comboBoxAcc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ButtonRemoveAcc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to remove this account ?" + selectedAcc.FormatData(), "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                formUtama.listOvoAcc.Remove(selectedAcc);
                MessageBox.Show("Account is success removed.");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
