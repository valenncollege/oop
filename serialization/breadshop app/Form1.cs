using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EllysaBreadShopApplication
{
    public partial class Form1 : Form
    {
        EllysaBreads bread;
        BindingList<EllysaBreads> listBread = new BindingList<EllysaBreads>();

        EllysaBreads selectedBread;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //ciptakan objek bread baru
                //(cukup lokal saja karena hny diakses di buttonAdd)
                bread = new EllysaBreads(textBoxName.Text,
                                         int.Parse(textBoxPrice.Text));
                //simpan ke list
                listBread.Add(bread);

                //tampilkan data objek ke listBox (gunakan method DisplayData di class)
                listBoxData.Items.AddRange(bread.DisplayData().Split('\n'));

                //clear data
                textBoxName.Clear();
                textBoxPrice.Clear();
                textBoxName.Focus();

                //spy tdk ada item yg terpilih di comboBox
                comboBoxBreadVariant.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDisplayAll_Click(object sender, EventArgs e)
        {
            //menampilkan semua isi listBread
            foreach(EllysaBreads bread in listBread)
            {
                listBoxData.Items.AddRange(bread.DisplayData().Split('\n'));
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //mengosongi listBox
            listBoxData.Items.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //data binding (utk menghubungkan comboBox dgn list)
            comboBoxBreadVariant.DataSource = listBread;
            comboBoxBreadVariant.DisplayMember = "Name";
        }

        private void buttonMade_Click(object sender, EventArgs e)
        {
            try
            {
                //cek apakah user sudah memilih roti di comboBox
                if (selectedBread == null) //jika blm memilih roti
                {
                    MessageBox.Show("Choose bread first");
                }
                else
                {
                    //gunakan method MadeTheBread yg di class
                    selectedBread.MadeTheBread(int.Parse(textBoxQuantityMade.Text));

                    //tampilkan di listBox
                    listBoxData.Items.Add("===================");
                    listBoxData.Items.Add("BREAD PRODUCTION");
                    listBoxData.Items.Add("===================");
                    listBoxData.Items.Add("Quantity to Made : " + textBoxQuantityMade.Text);
                    listBoxData.Items.Add("Result : ");
                    listBoxData.Items.AddRange(selectedBread.DisplayData().Split('\n'));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxBreadVariant_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dapatkan objek roti yg dipilih user di comboBox
            selectedBread = (EllysaBreads) comboBoxBreadVariant.SelectedItem;
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            try
            {
                //menjual roti menggunakan method SellTheBread
                selectedBread.SellTheBread(int.Parse(textBoxQuantitySell.Text), 
                                           comboBoxPayment.Text, out int total, out int diskonPromo,
                                           out int diskonCC, out int grandTotal);
                
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
                listBoxData.Items.AddRange(selectedBread.DisplayData().Split('\n'));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
