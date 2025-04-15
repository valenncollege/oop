using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ellysaBreadShopApplication
{
    public partial class FormDisplayAllBreads : Form
    {
        public FormDisplayAllBreads()
        {
            InitializeComponent();
        }
        FormMain formUtama;
        private void FormDisplayAllBreads_Load(object sender, EventArgs e)
        {
            formUtama = (FormMain)this.Owner;
            foreach (JevonBreadClass roti in formUtama.ListRoti)
            {
                listBoxData.Items.AddRange(roti.Format().Split('\n'));
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
