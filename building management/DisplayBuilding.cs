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
    public partial class DisplayBuilding : Form
    {
        public DisplayBuilding()
        {
            InitializeComponent();
        }
        FormMain formUtama;
        private void DisplayBuilding_Load(object sender, EventArgs e)
        {
            formUtama = (FormMain)this.Owner;
            foreach (Building i in formUtama.listBuilding)
            {
                listBox1.Items.AddRange(i.DisplayBuilding().Split('\n'));
                listBox1.Items.Add("List of Room : ");
                listBox1.Items.AddRange(i.DisplayRooms().Split('\n'));

            }
        }
    }
}
