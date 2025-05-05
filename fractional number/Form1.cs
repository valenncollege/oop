using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W2B_Jevon_Valentino_160424066
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        jevonFractNumber number1;
        jevonFractNumber number2;

        #region methodPecahan
        private void Pecahan()
        {      
            try
            {
                int a = int.Parse(textBoxFract1Num.Text); //pembilangan num1
                int b = int.Parse(textBoxFract1Denom.Text); //penyebut num1
                int c = int.Parse(textBoxFract2Num.Text); //pembilang num2
                int d = int.Parse(textBoxFract2Denom.Text);//penyebut num2
                number1 = new jevonFractNumber(a, b);
                number2 = new jevonFractNumber(c, d);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                number2 = new jevonFractNumber(number1);
            }

        }
        #endregion
        private void Tampil(string op)
        {
            listBoxInfo.Items.Add(number1.Pembilang + "/" + number1.Penyebut + op + number2.Pembilang + "/" + number2.Penyebut + "=");             
        }
        #region Code Tombol
        string operate;
        jevonFractNumber Jawaban = new jevonFractNumber();
        
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operate = "*";
            Pecahan();

            if (number2.Penyebut == 1)
            {
                Jawaban = number1.Multiply(number2.Pembilang);
            }
            else
            {
                Jawaban= number1.Multiply(number2);
            }
            Jawaban = Jawaban.Simplify();
            listBoxInfo.Items.Add(Jawaban.Format(number1, number2, operate));
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            operate = "/";
            Pecahan();

            if (number2.Penyebut == 1)
            {
                Jawaban = number1.Division(number2.Pembilang);
            }
            else
            {
                Jawaban = number1.Division(number2);
            }
            Jawaban = Jawaban.Simplify();
            listBoxInfo.Items.Add(Jawaban.Format(number1, number2, operate));
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            operate = "+";
            Pecahan();

            if (number2.Penyebut == 1)
            {
                Jawaban = number1.Add(number2.Pembilang);
            }
            else
            {
                Jawaban = number1.Add(number2);
            }
            Jawaban = Jawaban.Simplify();

            listBoxInfo.Items.Add(Jawaban.Format(number1, number2, operate));
        }

        private void buttonSubstraction_Click(object sender, EventArgs e)
        {
            operate = "-";
            Pecahan();

            if (number2.Penyebut == 1)
            {
                Jawaban = number1.Subtract(number2.Pembilang);
            }
            else
            {
                Jawaban = number1.Subtract(number2);
            }
            Jawaban = Jawaban.Simplify();

            listBoxInfo.Items.Add(Jawaban.Format(number1, number2, operate));
        }
        #endregion
        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            number1 = new jevonFractNumber();
            number2 = new jevonFractNumber();

        }
    }
}
