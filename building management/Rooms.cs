using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tugas_W9A_Jevon_Valentino_160424066
{
    [Serializable]
    public class Rooms
    {
        private int capacity;
        private string id;
        private string type;

        public int Capacity { get => capacity; set => capacity = value; }
        public string Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }

        public Rooms(int pCapacity, string pId, string pType)
        {
            this.Capacity = pCapacity;
            this.Type = pType;
            this.Id = pId;
        }

        public string Display()
        {
            string result = "ID : " + this.Id + "\n" +
                "Capacity : " + this.Capacity + "\n" +
                "Type : " + this.Type + "\n";
            return result;
        }
    }
}