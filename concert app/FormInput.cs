using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcertApp
{
    public partial class frmInput : Form
    {
        public frmInput()
        {
            InitializeComponent();
        }
        frmMain formUtama;
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string artist = textBoxArtist.Text;
                string title = textBoxTitle.Text;
                string venue = comboBoxVenue.Text;
                DateTime start = dateTimePickerStart.Value;
                DateTime end = dateTimePickerEnd.Value;
                ConcertClas newConcert = new ConcertClas(artist, title, venue, start, end);
                formUtama.listConcert.Add(newConcert);
                MessageBox.Show(title + " has been saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmInput_Load(object sender, EventArgs e)
        {
            formUtama = (frmMain)this.Owner;
        }
    }
}
