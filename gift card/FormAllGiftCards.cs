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
    public partial class FormAllGiftCards : Form
    {
        public FormAllGiftCards()
        {
            InitializeComponent();
        }
        FormMain formUtama;
        private void FormAllGiftCards_Load(object sender, EventArgs e)
        {
            formUtama = (FormMain)this.Owner;
        }
        private void comboBoxMerchant_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            if (comboBoxMerchant.Text == "All")
            {
                foreach (JevonGiftCard theGiftCard in formUtama.ListGiftCard)
                {
                    listBoxData.Items.AddRange(theGiftCard.FormatDisplay().Split('\n'));
                }
            }
            else
            {
                foreach (JevonGiftCard giftCard in formUtama.ListGiftCard)
                {
                    if (comboBoxMerchant.Text == giftCard.MerchantName)
                    {
                        listBoxData.Items.AddRange(giftCard.FormatDisplay().Split('\n'));
                    }
                }
            }

        }
    }
}
