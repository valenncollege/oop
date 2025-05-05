using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tugas_W2B_Jevon_Valentino_160424066
{
    public class jevonFractNumber
    {
        #region Data Member
        private int pembilang;
        private int penyebut;
        #endregion
        #region Constructor
        public jevonFractNumber()//default constructor
        {
            this.Pembilang = 1;
            this.Penyebut = 1;
        }

        public jevonFractNumber(int pPembilang, int pPenyebut)//multi constructor
        {
            this.Pembilang = pPembilang;
            this.Penyebut = pPenyebut;
        }

        public jevonFractNumber (jevonFractNumber fractToCopy) //copy constructor
        {
            this.Pembilang = fractToCopy.Pembilang;
            this.Penyebut = fractToCopy.Penyebut;
        }
        #endregion

        #region Property
        public int Pembilang { get => pembilang; set => pembilang = value; }
        public int Penyebut
        {
            get => penyebut;
            set
            {
                if (value == 0)
                {
                    throw new Exception("Not defined number");
                }
                else
                {
                    this.penyebut = value;
                }
            }
        }
        #endregion
        #region method
        public jevonFractNumber Multiply(int pBil)
        {
            jevonFractNumber result = new jevonFractNumber(this);
            result.Pembilang = this.Pembilang * pBil;
            return result;
        }
        public jevonFractNumber Multiply(jevonFractNumber pPecahan)
        {
            jevonFractNumber result = new jevonFractNumber();
            result.Pembilang = this.Pembilang * pPecahan.Pembilang;
            result.Penyebut = this.Penyebut * pPecahan.Penyebut;
            return result;
        }
        public jevonFractNumber Add(int pBil)
        {
            jevonFractNumber result = new jevonFractNumber();
            result.Pembilang = this.Pembilang + (this.Penyebut * pBil);
            result.Penyebut = this.Penyebut;
            return result;
        }
        public jevonFractNumber Add(jevonFractNumber pPecahan)
        {
            jevonFractNumber result = new jevonFractNumber();
            result.Pembilang = (this.Pembilang * pPecahan.Penyebut) + (this.Penyebut * pPecahan.Pembilang);
            result.Penyebut = this.Penyebut * pPecahan.Penyebut;
            return result;
        }
        public jevonFractNumber Subtract(jevonFractNumber pPecahan)
        {
            jevonFractNumber result = new jevonFractNumber();
            result.Pembilang = (this.Pembilang * pPecahan.Penyebut) - (this.Penyebut * pPecahan.Pembilang);
            result.Penyebut = this.Penyebut * pPecahan.Penyebut;
            return result;
        }
        public jevonFractNumber Subtract(int pBil)
        {
            jevonFractNumber result = new jevonFractNumber();
            result.Pembilang = this.Pembilang - (this.Penyebut * pBil);
            result.Penyebut = this.Penyebut;
            return result;
        }
        public jevonFractNumber Division(int pBil)
        {
            jevonFractNumber result = new jevonFractNumber();
            result.Pembilang = 1;
            result.Penyebut = pBil;
            result= this.Multiply(result);
            return result;
        }
        public jevonFractNumber Division(jevonFractNumber pPecahan)
        {
            jevonFractNumber result = new jevonFractNumber();
            result.Pembilang = pPecahan.Penyebut;
            result.Penyebut = pPecahan.Pembilang;
            result = this.Multiply(result);
            return result;
        }
        public string Format(jevonFractNumber pNum1, jevonFractNumber pNum2, string pOperator)
        {
            string result;
            if (this.Pembilang == 0)
            {
                result = "0";
            }
            else
            {
                result = pNum1.Pembilang + "/" + pNum1.Penyebut +
                                " " + pOperator + " " +
                                pNum2.Pembilang + "/" + pNum2.Penyebut +
                                " = " +
                                this.Pembilang + "/" + this.Penyebut;
            }
            return result;
         }
        
        public jevonFractNumber Simplify()
        {
            jevonFractNumber result = new jevonFractNumber();
            int min, max;
            int fpb=1;
            if(Math.Abs( this.Pembilang) < Math.Abs( this.Penyebut))
            {
                min =Math.Abs( this.Pembilang);
                max =Math.Abs( this.Penyebut);
            }
            else
            {
                min =Math.Abs( this.Penyebut);
                max =Math.Abs( this.Pembilang);
            }
            bool cari = false;
            for (int i = min; i >=1 && cari==false; i--)
            {
                if(min % i == 0 && max % i == 0)
                {
                    fpb = i;
                    cari = true;
                }
            }
            result.Pembilang = this.Pembilang / fpb;
            result.Penyebut = this.Penyebut / fpb;
            return result;
        }
        #endregion
    }
}