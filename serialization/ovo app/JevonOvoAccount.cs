using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormOvoSimpleApplication
{
    [Serializable]
    public class JevonOvoAccount
    {
        private string name; 
        private string phoneNumber;
        private string ovoID;
        private int pin;
        private int ovoCash;
        private int ovoPoints;

        #region contructor
        public JevonOvoAccount()
        {
            this.Name = "-";
            this.PhoneNumber = "-";
            this.OvoID = "0";
            this.Pin = 123456;
            this.OvoCash = 0;
            this.OvoPoints = 0;
        }
        public JevonOvoAccount (string pNama, string pNomorTelp, int pPin, string pOvoID)
        {
            this.Name = pNama;
            this.PhoneNumber = pNomorTelp;
            this.OvoID = pOvoID;
            this.Pin = pPin;
            this.OvoCash = 0;
            this.OvoPoints = 0;
        }
        #endregion

        #region Property
        public string Name
        {
            get => name;
            set
            {
                if (value != "")
                {
                    this.name = value;
                }
                else
                {
                    throw new Exception("Name can not be empty");
                }
            }
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (value != "")
                {
                    this.phoneNumber = value;
                }
                else
                {
                    throw new Exception("Name can not be empty");
                }
                int number;
                bool check = int.TryParse(phoneNumber, out number);
                if (check == false)
                {
                    throw new Exception("Phone number invalid!");
                }
            }
        }
        public string OvoID
        {
            get => ovoID;
            set
            {
                if(long.TryParse(value, out long temp))
                {
                    ovoID = value;
                }
                else
                {
                    throw new Exception("Ovo ID cannot be empty");
                }
            }
        }
        public int Pin
        {
            set
            {
                if (value.ToString().Length != 6)
                {
                    throw new Exception("Pin must be 6 digit !");
                }
            }

        }
        public int OvoCash
        {
            get => ovoCash;
            private set
            {
                if (value > 0)
                {
                    this.ovoCash = value;
                }
                else
                {
                    this.ovoCash = 0;
                }
            }
        }
        public int OvoPoints
        {
            get => ovoPoints;
            private set
            {
                if (value > 0)
                {
                    this.ovoCash = value;
                }
                else
                {
                    this.ovoCash = 0;
                }
            }
        }
        #endregion
        #region Method
        public void Buy(string jenisVoucher, int harga)
        {
            if (OvoCash < harga)
            {
                throw new Exception("Your Ovo Cash is not enough !");
            }
            else
            {
                if (harga < 5000)
                {
                    throw new Exception("The minimum item price is Rp. 5000");
                }
                else
                {
                    this.ovoCash = OvoCash - harga;
                    if (jenisVoucher == "Internet Voucher")
                    {
                        this.ovoPoints = OvoPoints + (int)(0.1 * harga);
                    }
                }
            }
        }

        public void TopUp(int nominalTopUp)
        {
            if (nominalTopUp >= 10000)
            {
                this.OvoCash = OvoCash + nominalTopUp;
            }
            else
            {
                throw new Exception("Minimum top up is Rp. 10.000");
            }
        }

        public string FormatData()
        {
            string display = "Nama = " + this.Name +
                "\n" + "Phone Number = " + this.PhoneNumber +
                "\n" + "Ovo ID = " + this.OvoID +
                "\n" + "Ovo Cash = " + this.OvoCash +
                "\n" + "Ovo Point = " + this.OvoPoints + "\n";
            return display;
        }
#endregion
    }
}