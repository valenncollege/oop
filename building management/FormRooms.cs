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
    public partial class FormRooms : Form
    {
        public FormRooms()
        {
            InitializeComponent();
        }
        FormMain formUtama;
        Building selectedBuilding;
        private void FormRooms_Load(object sender, EventArgs e)
        {
            formUtama = (FormMain)this.Owner;
            comboBoxBuilding.DataSource = formUtama.listBuilding;
            comboBoxBuilding.DisplayMember = "Id";
        }

        private void comboBoxBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBuilding = (Building)comboBoxBuilding.SelectedValue;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string idRoom = textBoxID.Text;
            int capacityRoom = (int)numericUpDownCapacity.Value;
            string typeRoom = comboBoxType.Text;
            selectedBuilding.AddRoom(idRoom, typeRoom, capacityRoom);
            Rooms newRoom = new Rooms(capacityRoom, idRoom, typeRoom);
            listBox1.Items.AddRange(newRoom.Display().Split('\n'));
        }
    }
}
