using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EllysaGiftCardApplication
{
    [Serializable]
    public class JevonGiftCard
    {
        private int barcode;
        private string merchantName;
        private int nominal;
        private DateTime validFrom;
        private DateTime validUntil;
        private bool redeemStatus;
        #region property
        public int Barcode
        {
            get => barcode;
            set
            {
                if (value.ToString().Length != 7)
                {
                    throw new Exception("Barcode must 7 digits");
                }
                else
                {
                    this.barcode = value;
                }
            }
        }
        public string MerchantName { get => merchantName; set => merchantName = value; }
        public int Nominal
        {
            get => nominal;
            set
            {
                if (value < 10000)
                {
                    value = 10000;
                }
                else if (value > 1000000)
                {
                    value = 1000000;
                }
                nominal = value;
            }
        }
        public DateTime ValidFrom { get => validFrom; set => validFrom = value; }
        public DateTime ValidUntil
        {
            get => validUntil;
            set
            {
                if (value >= this.ValidFrom)
                {
                    this.validUntil = value;
                }
                else
                {
                    throw new Exception("Valid until not valid");
                }
            }
        }
        public bool RedeemStatus { get => redeemStatus; private set => redeemStatus = value; }
        #endregion

        #region constructor
        public JevonGiftCard (int pBarcode, string pName, int pNominal, DateTime pValidFrom, DateTime pValidUntil)
        {
            this.Barcode = pBarcode;
            this.MerchantName = pName;
            this.Nominal = pNominal;
            this.ValidFrom = pValidFrom;
            this.ValidUntil = pValidUntil;
            this.RedeemStatus = false;
        }
        #endregion

        #region method
        public string FormatDisplay()
        {
            string result = "Barcode : " + this.Barcode + "\n" +
                "Merchant Name : " + this.MerchantName + "\n" +
                "Nominal : Rp " + this.Nominal + "\n" +
                "Valid From : " + this.ValidFrom.ToShortDateString() + " until " + this.ValidUntil.ToShortDateString() + "\n" +
                "Redeem Status : " + this.RedeemStatus + "\n";
            
            return result;
        }

        public int RedeemCard(int pTransaction, DateTime pRedeemDate)
        {
            int result=0;
            if (this.RedeemStatus == true)
            {
                throw new Exception("The card cant be used, because already redeemed");
            }
            else
            {
                if (pTransaction < 10000)
                {
                    throw new Exception("The minimum transaction is 10.000");
                }
                else
                {
                    if (pRedeemDate < this.ValidFrom.Date)
                    {
                        throw new Exception("The card is valid from " + this.ValidFrom.Date);
                    }
                    else if (pRedeemDate > this.ValidUntil)
                    {
                        throw new Exception("The card is valid untill + " + this.ValidUntil.Date);
                    }
                    else
                    {
                        result = pTransaction - this.Nominal;
                        this.RedeemStatus = true;
                    }
                }
            } 
            if (result < 0)
            {
                result = 0;
            }
            return result;
        }
        #endregion
    }
}