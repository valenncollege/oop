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
    public partial class FormAddNewVariant : Form
    {
        public FormAddNewVariant()
        {
            InitializeComponent();
        }
        FormMain formUtama;
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddNewVariant_Load(object sender, EventArgs e)
        {
            formUtama = (FormMain)this.Owner;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek baru
                string name = textBoxName.Text;
                int price = int.Parse(textBoxPrice.Text);
                JevonBreadClass RotiBaru = new JevonBreadClass(name, price);

                //masukkan ke list
                formUtama.ListRoti.Add(RotiBaru);

                //simpan ke file
                formUtama.SaveData(formUtama.defaultNamaFile);

                //tampil ke listbox
                listBoxData.Items.AddRange(RotiBaru.Format().Split('\n'));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
