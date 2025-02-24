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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        //buat objek
        JevonOvoAccount ovoJevon = new JevonOvoAccount();

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            //input
            string nama = textBoxName.Text;
            int telp = int.Parse(textBoxPhoneNumber.Text);
            int id = int.Parse(textBoxOvoID.Text);
            int pin = int.Parse(textBoxPIN.Text);

            //mengisi objek
            ovoJevon.Name = nama;
            ovoJevon.PhoneNumber = telp;
            ovoJevon.Pin = pin;
            ovoJevon.OvoID = id;

            //output ke listbox
            TampilData();

            //aktifkan grupbox
            groupBoxBuy.Enabled = true;
            groupBoxTopUp.Enabled = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBoxBuy.Enabled = false;
            groupBoxTopUp.Enabled = false;
        }

        private void buttonTopUp_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            int nominal = int.Parse(textBoxNominalTopUp.Text);
            ovoJevon.TopUp(nominal);

            listBoxData.Items.Add(nominal + " has been added");
            listBoxData.Items.Add("Your cash is " + ovoJevon.OvoCash);

            TampilData();
        }

        private void TampilData()
        {
            listBoxData.Items.Add("Name = " + ovoJevon.Name);
            listBoxData.Items.Add("Phone number = " + ovoJevon.PhoneNumber);
            listBoxData.Items.Add("OVO ID = " + ovoJevon.OvoID);
            listBoxData.Items.Add("OVO Cash = " + ovoJevon.OvoCash);
            listBoxData.Items.Add("OVO Points = " + ovoJevon.OvoPoints);
        }

        private void buttonClearData_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
        }

        private void buttonDisplayData_Click(object sender, EventArgs e)
        {
            TampilData();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            string jenis = comboBoxItems.SelectedItem.ToString();
            int harga = int.Parse(textBoxPrice.Text);
            ovoJevon.Buy(jenis, harga);
            listBoxData.Items.Add("You have been buy " + jenis + " with price " + harga);
        }
    }
}
