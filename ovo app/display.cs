using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOvoSimpleApplication
{
    public partial class display : Form
    {
        public display()
        {
            InitializeComponent();
        }
        menu formUtama;
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void display_Load(object sender, EventArgs e)
        {
            formUtama = (menu)this.Owner;

            foreach (JevonOvoAccount userAcc in formUtama.listOvoAcc)
            {
                listBoxData.Items.AddRange(userAcc.FormatData().Split('\n'));
            }
        }
    }
}
