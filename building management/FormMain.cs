using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W9A_Jevon_Valentino_160424066
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public BindingList<Locations> listLocation = new BindingList<Locations>();
        public BindingList<Building> listBuilding = new BindingList<Building>();
        private void displayLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayLocation formDisplayLoc = new DisplayLocation();
            formDisplayLoc.Owner = this;
            formDisplayLoc.ShowDialog();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocations formLoc = new FormLocations();
            formLoc.Owner = this;
            formLoc.ShowDialog();
        }

        private void buildingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuilding formBuild = new FormBuilding();
            formBuild.Owner = this;
            formBuild.ShowDialog();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRooms formRoom = new FormRooms();
            formRoom.Owner = this;
            formRoom.ShowDialog();
        }

        private void displayBuildingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBuilding formDisplayBuilding = new DisplayBuilding();
            formDisplayBuilding.Owner = this;
            formDisplayBuilding.ShowDialog();
        }

        public string defaultLocatianName = "Location.dat";
        public string defaultBuildingName = "Building.dat";

        public void SaveBuilding(string fileName)
        {
            FileStream myfile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myfile, listBuilding);
            myfile.Close();
        }
        public void SaveLocation(string fileName)
        {
            FileStream myfile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myfile, listLocation);
            myfile.Close();
        }
        public void OpenBuilding(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                listBuilding = (BindingList<Building>)formatter.Deserialize(file);
                file.Close();
            }
            else
            {
                MessageBox.Show("File is not exist");
            }
        }
        public void OpenLocation(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                listLocation = (BindingList<Locations>)formatter.Deserialize(file);
                file.Close();
            }
            else
            {
                MessageBox.Show("File is not exist");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                defaultBuildingName = dialog.FileName;
                SaveBuilding(defaultBuildingName);
                MessageBox.Show("Your data has been saved to " + dialog.FileName);
            }
        }

        private void saveLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                defaultLocatianName = dialog.FileName;
                SaveLocation(defaultLocatianName);
                MessageBox.Show("Your data has been saved to " + dialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                defaultBuildingName = dialog.FileName;
                OpenBuilding(defaultBuildingName);
                MessageBox.Show("Your data has been loaded to " + dialog.FileName);
            }
        }

        private void openLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                defaultLocatianName = dialog.FileName;
                OpenLocation(defaultLocatianName);
                MessageBox.Show("Your data has been loaded to " + dialog.FileName);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            OpenBuilding(defaultBuildingName);
            OpenLocation(defaultLocatianName);
        }
    }
}
