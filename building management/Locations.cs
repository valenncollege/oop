using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tugas_W9A_Jevon_Valentino_160424066
{
    [Serializable]
    public class Locations
    {
        private string id;
        private string name;
        private string address;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }

        #region constructor
        public Locations (string pId, string pName, string pAddress)
        {
            this.Id = pId;
            this.Name = pName;
            this.Address = pAddress;
        }
        #endregion

        public string Display()
        {
            string result = "ID : " + this.Id + "\n" +
                "Name : " + this.Name + "\n" +
                "Address : " + this.Address + "\n";
            return result;
        }
    }
}