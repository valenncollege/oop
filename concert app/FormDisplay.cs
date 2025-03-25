using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ConcertApp
{
    public partial class frmDisplay : Form
    {
       
        public frmDisplay()
        {
            InitializeComponent();
        }
        frmMain formUtama;
        private void buttonDisplayAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (ConcertClas allConcert in formUtama.listConcert)
            {
                listBox1.Items.AddRange(allConcert.Format().Split('\n'));
            }
        }

        private void frmDisplay_Load(object sender, EventArgs e)
        {
            formUtama = (frmMain)this.Owner;
            comboBoxConcert.DataSource = formUtama.listConcert;
            comboBoxConcert.DisplayMember = "Title";
        }

        private void buttonMonth_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (ConcertClas allConcert in formUtama.listConcert)
            {
                if (allConcert.IsThisMonth() == true && allConcert.ConcertIsOver() == 
                    false)
                {
                    listBox1.Items.AddRange(allConcert.Format().Split('\n'));
                }
            }
        }
        ConcertClas selectedConcert;
        private void comboBoxConcert_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedConcert = (ConcertClas)comboBoxConcert.SelectedValue;
        }

        private void buttonThis_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(selectedConcert.Format().Split('\n'));
        }
    }
}
