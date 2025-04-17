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
    public partial class FormRedeemGiftCard : Form
    {
        public FormRedeemGiftCard()
        {
            InitializeComponent();
        }
        FormMain formUtama;
        private void FormRedeemGiftCard_Load(object sender, EventArgs e)
        {
            formUtama = (FormMain)this.Owner;
            comboBoxGiftCard.DataSource = formUtama.ListGiftCard;
            comboBoxGiftCard.DisplayMember = "Barcode";
        }
        JevonGiftCard SelectedCard;
        private void comboBoxGiftCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCard = (JevonGiftCard)comboBoxGiftCard.SelectedValue;
        }

        private void buttonRedeemGiftCard_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime redeemDate = dateTimePickerRedeemDate.Value;
                int total = (int)numericUpDownTotal.Value;

                DialogResult result = MessageBox.Show(SelectedCard.FormatDisplay() + "Are you sure to redeem this card?"
                    , "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int totalTransaction = SelectedCard.RedeemCard(total, redeemDate);
                    MessageBox.Show("Transaction succes " + '\n' + 
                        "Total transaction : Rp " + total + '\n' +
                        "Nominal gift card : Rp " + SelectedCard.Nominal + '\n' +
                        "Total payment : Rp " + totalTransaction);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
