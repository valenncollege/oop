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
    public partial class FormBuilding : Form
    {
        public FormBuilding()
        {
            InitializeComponent();
        }
        FormMain formUtama;
        private void FormBuilding_Load(object sender, EventArgs e)
        {
            formUtama = (FormMain)this.Owner;
            comboBoxLocation.DataSource = formUtama.listLocation;
            comboBoxLocation.DisplayMember = "Name";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string idBuilding = textBoxID.Text;
                int floorBuilding = (int)numericUpDownFloors.Value;
                Building newBuilding = new Building(idBuilding, floorBuilding, selectedLocation);
                formUtama.listBuilding.Add(newBuilding);
                formUtama.SaveBuilding(formUtama.defaultBuildingName);
                listBoxDisplay.Items.AddRange(newBuilding.DisplayBuilding().Split('\n'));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Locations selectedLocation;
        private void comboBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLocation = (Locations)comboBoxLocation.SelectedValue;
        }
    }
}
