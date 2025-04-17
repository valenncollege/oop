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
    public partial class FormDeleteGiftCard : Form
    {
        public FormDeleteGiftCard()
        {
            InitializeComponent();
        }
        FormMain formUtama;
        private void buttonDeleteGiftCard_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to delete this card ?" +
                SelectedCard.FormatDisplay(), "Confirmation",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                formUtama.ListGiftCard.Remove(SelectedCard);
                MessageBox.Show("The card has been deleted");
            }
        }

        private void FormDeleteGiftCard_Load(object sender, EventArgs e)
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
    }
}
