using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W9A_Jevon_Valentino_160424066
{
    public partial class FormLocations : Form
    {
        public FormLocations()
        {
            InitializeComponent();
        }
        FormMain formUtama;
        private void FormLocations_Load(object sender, EventArgs e)
        {
            formUtama = (FormMain)this.Owner;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string idLocation = textBoxID.Text;
                string addressLocation = textBoxAddress.Text;
                string nameLocation = textBoxLocationName.Text;

                Locations newLocation = new Locations(idLocation, nameLocation, addressLocation);
                formUtama.listLocation.Add(newLocation);
                formUtama.SaveLocation(formUtama.defaultLocatianName);
                listBoxDisplay.Items.AddRange(newLocation.Display().Split('\n'));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
