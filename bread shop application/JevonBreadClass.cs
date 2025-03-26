using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ellysaBreadShopApplication
{
    [Serializable]
    public class JevonBreadClass
    {
        private string name;
        private int price;
        private int stock;
        #region Property
        public string Name { get => name; set => name = value; }
        public int Price
        {
            get => price;
            set
            {
                if (value % 10000 == 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new Exception("Price harus kelipatan 10.000 !");
                }
            }
        }

        public int Stock
        {
            get => stock;
            private set
            {
                if (value < 0)
                {
                    this.stock = 0;
                }
                else
                {
                    this.stock = value;
                }
            }
        }
        #endregion

        #region constructor

        public JevonBreadClass(string pNama, int pPrice)
        {
            this.Name = pNama;
            this.Stock = 0;
            this.Price = pPrice;
        }
        #endregion
        #region method
        public string BuatRoti(int pJumlah)
        {
            string display;
            if (pJumlah < 10)
            {
                throw new Exception("Quantity below the minimum quantity (10).");
            }
            else
            {
                if (Stock + pJumlah > 50)
                {
                    throw new Exception("Quantity over the maximum quantity (50)");
                }
                else
                {
                    this.Stock = Stock + pJumlah;
                }
            }
            display = "Quantity to Made : " + pJumlah;
            return display;
        }

        public string Format()
        {
            string display = "Nama Roti = " + this.Name +
                "\n" + "Harga = " + this.Price +
                "\n" + "Stok = " + this.Stock + "\n";
            return display;
        }

        public void Sell(int quantity, string paymentMethod, out int total, out int diskonPromo, out int diskonCC, out int grandTotal)
        {
            //cek stock roti (mencukupi atau tidak)
            if (this.Stock >= quantity) //jika stock mencukupi
            {
                //mengurangi stock
                this.Stock -= quantity;

                //hitung total 
                total = quantity * this.Price;

                //hitung diskon promo (pembelian > 5 dpt 10% disc)
                diskonPromo = 0;
                if (quantity > 5)
                {
                    diskonPromo = (int)(0.1 * total);
                }

                //hitung diskon tambahan (credit card)
                diskonCC = 0;
                if (paymentMethod == "Credit Card")
                {
                    diskonCC = (int)(0.2 * (total - diskonPromo));
                }

                //hitung grand total
                grandTotal = total - diskonPromo - diskonCC;
            }
            else //jika stock tdk mencukupi
            {
                throw new Exception("Stock not available. Current stock = " + this.Stock);
            }
        } 
        #endregion
    }
}