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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        public BindingList<JevonOvoAccount> listOvoAcc = new BindingList<JevonOvoAccount>();
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register formRegist = new register();
            formRegist.Owner = this;
            formRegist.ShowDialog();
        }

        private void dIsplayAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display formDisplay = new display();
            formDisplay.Owner = this;
            formDisplay.ShowDialog();
        }

        private void removeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            remove formRemove = new remove();
            formRemove.Owner = this;
            formRemove.ShowDialog();
        }

        private void topUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            topUp formTopUp = new topUp();
            formTopUp.Owner = this;
            formTopUp.ShowDialog();
        }

        private void buyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buy formBuy = new buy();
            formBuy.Owner = this;
            formBuy.ShowDialog();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
