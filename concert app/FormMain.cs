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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public BindingList<ConcertClas> listConcert = new BindingList<ConcertClas>();
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addConcertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInput formInput = new frmInput();
            formInput.Owner = this;
            formInput.ShowDialog();
        }

        private void displayAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisplay formDisplay = new frmDisplay();
            formDisplay.Owner = this;
            formDisplay.ShowDialog();
        }
    }
}
