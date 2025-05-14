using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tugas_W9A_Jevon_Valentino_160424066
{
    [Serializable]
    public class Building
    {
        private string id;
        private int floors;
        private Locations locOfBuilding;
        private List<Rooms> listRoomsInBuilding;

        public string Id { get => id; set => id = value; }
        public int Floors { get => floors; set => floors = value; }
        public Locations LocOfBuilding { get => locOfBuilding; set => locOfBuilding = value; }
        public List<Rooms> ListRoomsInBuilding { get => listRoomsInBuilding; private set => listRoomsInBuilding = value; }
        #region constructor
        public Building(string pId, int pFloors, Locations pLoc)
        {
            this.Id = pId;
            this.Floors = pFloors;
            this.LocOfBuilding = pLoc;
            this.ListRoomsInBuilding = new List<Rooms>();
        }
        #endregion
        #region method
        public void AddRoom(string pInputId, string pInputType, int pInputCapacity)
        {
            Rooms newRoom = new Rooms(pInputCapacity, pInputId, pInputType);
            this.ListRoomsInBuilding.Add(newRoom);
        }
        
        public string DisplayRooms()
        {
            string output = "";
            foreach (Rooms selectedRoom in this.ListRoomsInBuilding)
            {
                output = output + selectedRoom.Display();

            }
            output = output + "\n";
            return output;
        }
        public string DisplayBuilding()
        {
            string result = "ID : " + this.Id + "\n" +
                "Floors : " + this.Floors + "\n" +
                "Location of Building : " + this.LocOfBuilding.Name + "\n";
            return result;
        }
        #endregion
    }
}