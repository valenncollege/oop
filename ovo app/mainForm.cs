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
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
        }
        //buat objek
        JevonOvoAccount ovoJevon;
        BindingList<JevonOvoAccount> ListObjek = new BindingList<JevonOvoAccount>();
        JevonOvoAccount userAcc;

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();

            string ovoid = textBoxOvoID.Text;
            bool ketemu = false;
            foreach (JevonOvoAccount userAccount in ListObjek)
            {
                if (ovoid == userAccount.OvoID)
                {
                    ketemu = true;
                    break;
                }
            }
            if (ketemu)
            {
                MessageBox.Show("Ovo ID has been used by other user. Choose Another");
            }
            else
            {
                //input
                try
                {
                    string nama = textBoxName.Text;
                    string telp = textBoxPhoneNumber.Text;
                    string id = textBoxOvoID.Text;
                    int pin = int.Parse(textBoxPIN.Text);

                    //mengisi objek
                    ovoJevon = new JevonOvoAccount(nama, telp, pin, id);

                    //masukkan objek ke list
                    ListObjek.Add(ovoJevon);

                    //output ke listbox
                    listBoxData.Items.AddRange(ovoJevon.FormatData().Split('\n'));

                    //aktifkan grupbox
                    groupBoxBuy.Enabled = true;
                    groupBoxTopUp.Enabled = true;

                    //bersihkan data textbox
                    textBoxName.Clear();
                    textBoxPhoneNumber.Clear();
                    textBoxPIN.Clear();
                    textBoxOvoID.Clear();
                    textBoxName.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            groupBoxBuy.Enabled = false;
            groupBoxTopUp.Enabled = false;
            //menambahkan list ke combobox
            comboBoxAcc.DataSource = ListObjek;
            comboBoxAcc.DisplayMember = "OvoID";
        }

        private void buttonTopUp_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            try
            {
                if (userAcc != null)
                {
                    int nominal = int.Parse(textBoxNominalTopUp.Text);
                    userAcc.TopUp(nominal);
                    listBoxData.Items.Add(nominal + " has been added");
                    listBoxData.Items.Add("Your cash is " + userAcc.OvoCash);
                    listBoxData.Items.AddRange(userAcc.FormatData().Split('\n'));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*
        private void TampilData()
        {
            listBoxData.Items.Add("Name = " + ovoJevon.Name);
            listBoxData.Items.Add("Phone number = " + ovoJevon.PhoneNumber);
            listBoxData.Items.Add("OVO ID = " + ovoJevon.OvoID);
            listBoxData.Items.Add("OVO Cash = " + ovoJevon.OvoCash);
            listBoxData.Items.Add("OVO Points = " + ovoJevon.OvoPoints);
        }
        */
        private void buttonClearData_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
        }

        private void buttonDisplayData_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();

            foreach (JevonOvoAccount userAcc in ListObjek)
            {
                listBoxData.Items.AddRange(userAcc.FormatData().Split('\n'));

            }
            //TampilData();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            try
            {
                if (userAcc != null)
                {
                    string jenis = comboBoxItems.SelectedItem.ToString();
                    int harga = int.Parse(textBoxPrice.Text);
                    userAcc.Buy(jenis, harga);
                    listBoxData.Items.Add("You have been buy " + jenis + " with price " + harga);
                    listBoxData.Items.AddRange(userAcc.FormatData().Split('\n'));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            userAcc = (JevonOvoAccount)comboBoxAcc.SelectedValue;
        }

        private void ButtonRemoveAcc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to remove this account ?" + userAcc.FormatData(), "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ListObjek.Remove(userAcc);
                MessageBox.Show("Account is success removed.");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
