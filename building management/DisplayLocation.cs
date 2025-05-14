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
    public partial class DisplayLocation : Form
    {
        public DisplayLocation()
        {
            InitializeComponent();
        }
        FormMain formUtama;

        private void DisplayLocation_Load(object sender, EventArgs e)
        {
            formUtama = (FormMain)this.Owner;
            foreach (Locations i in formUtama.listLocation)
            {
                listBoxDisplay.Items.AddRange(i.Display().Split('\n'));
            }

        }
    }
}
