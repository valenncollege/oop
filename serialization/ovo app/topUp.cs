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
    public partial class topUp : Form
    {
        public topUp()
        {
            InitializeComponent();
        }
        menu formUtama;
        JevonOvoAccount selectedAcc;
        private void topUp_Load(object sender, EventArgs e)
        {
            formUtama = (menu)this.Owner;
            comboBoxAcc.DataSource = formUtama.listOvoAcc;
            comboBoxAcc.DisplayMember = "OvoID";
            comboBoxAcc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBoxAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAcc = (JevonOvoAccount)comboBoxAcc.SelectedValue;
        }

        private void buttonTopUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedAcc != null)
                {
                    int nominal = int.Parse(textBoxNominalTopUp.Text);
                    selectedAcc.TopUp(nominal);
                    listBoxData.Items.Add(nominal + " has been added");
                    listBoxData.Items.Add("Your cash is " + selectedAcc.OvoCash);
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
