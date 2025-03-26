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
    public partial class FormSellTheBreads : Form
    {
        public FormSellTheBreads()
        {
            InitializeComponent();
        }
        FormMain frmMenu;
        JevonBreadClass selectedBread;
        private void buttonSell_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedBread == null)
                {
                    MessageBox.Show("Choose bread first");
                }
                else
                {
                    //menjual roti menggunakan method SellTheBread
                    selectedBread.Sell(int.Parse(textBoxQuantitySell.Text), comboBoxPayment.Text, out int total, out int diskonPromo, out int diskonCC, out int grandTotal);
                    frmMenu.SaveData();
                    //tampilkan data di listBox
                    listBoxData.Items.Add("=====================");
                    listBoxData.Items.Add("BREAD SELLING");
                    listBoxData.Items.Add("=====================");
                    listBoxData.Items.Add("Quantity to Sell : " + textBoxQuantitySell.Text);
                    listBoxData.Items.Add("Payment Method : " + comboBoxPayment.Text);
                    listBoxData.Items.Add("Result : ");
                    listBoxData.Items.Add("Total = " + total);
                    listBoxData.Items.Add("Promo Discount = " + diskonPromo);
                    listBoxData.Items.Add("Additional Discount = " + diskonCC);
                    listBoxData.Items.Add("Grand Total = " + grandTotal);
                    listBoxData.Items.Add("=====================");
                    listBoxData.Items.AddRange(selectedBread.Format().Split('\n'));

                    textBoxQuantitySell.Clear();
                    comboBoxVariantSell.SelectedIndex = 0;
                    comboBoxVariantSell.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormSellTheBreads_Load(object sender, EventArgs e)
        {
            //hubungkan form dgn form menu
            frmMenu = (FormMain)this.Owner;

            //menampilkan semua object roti yg ada dalam listBread ke comboBox
            //Data Binding
            comboBoxVariantSell.DataSource = frmMenu.ListRoti;
            comboBoxVariantSell.DisplayMember = "Name";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxVariantSell_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBread = (JevonBreadClass)comboBoxVariantSell.SelectedItem;
        }
    }
}
