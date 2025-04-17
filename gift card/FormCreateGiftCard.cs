using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EllysaGiftCardApplication
{
    public partial class FormCreateGiftCard : Form
    {
        public FormCreateGiftCard()
        {
            InitializeComponent();
        }
        FormMain formUtama;
        private void FormCreateGiftCard_Load(object sender, EventArgs e)
        {
            formUtama = (FormMain)this.Owner;
        }

        private void buttonCreateGiftCard_Click(object sender, EventArgs e)
        {
            try
            {
                int barcode = int.Parse(textBoxBarcode.Text);
                string merchantName = comboBoxMerchantName.Text;
                int nominal = (int)numericUpDownNominal.Value;
                DateTime validFrom = dateTimePickerValidFrom.Value;
                DateTime validUntil = dateTimePickerValidUntil.Value;

                JevonGiftCard NewGiftCard = new JevonGiftCard(barcode, merchantName, nominal, validFrom, validUntil);
                formUtama.ListGiftCard.Add(NewGiftCard);

                formUtama.SaveFile(formUtama.defaulFileName);

                MessageBox.Show("New Gift Card has been saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
