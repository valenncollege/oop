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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        menu formUtama;
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = textBoxName.Text;
                string telp = textBoxPhoneNumber.Text;
                string id = textBoxOvoID.Text;
                int pin = int.Parse(textBoxPIN.Text);

                //mengisi objek
                JevonOvoAccount newUser = new JevonOvoAccount(nama, telp, pin, id);

                //masukkan objek ke list

                formUtama.listOvoAcc.Add(newUser);
                //output ke listbox
                listBoxData.Items.AddRange(newUser.FormatData().Split('\n'));


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

        private void register_Load(object sender, EventArgs e)
        {
            formUtama = (menu)this.Owner;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
