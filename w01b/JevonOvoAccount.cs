using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormOvoSimpleApplication
{
    public class JevonOvoAccount
    {
        private string name;
        private int phoneNumber;
        private int ovoID;
        private int pin;
        private int ovoCash;
        private int ovoPoints;

        public string Name { get => name; set => name = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int OvoID { get => ovoID; set => ovoID = value; }
        public int Pin {set => pin = value; }
        public int OvoCash { get => ovoCash;}
        public int OvoPoints { get => ovoPoints;}

        public void Buy(string jenisVoucher, int harga)
        {
            ovoCash = OvoCash - harga;
            if (jenisVoucher == "Internet Voucher")
            {
                ovoPoints = OvoPoints + (int)(0.1 * harga);
            }
        }

        public void TopUp(int nominalTopUp)
        {
            ovoCash = OvoCash + nominalTopUp;
        }
    }
}