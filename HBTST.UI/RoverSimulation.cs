using HBTST.DataAccess;
using HBTST.Entity.Concrete;
using MongoDB.Bson;
using Repositories.Abstract;
using Repositories.Concrete;
using Rover.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormAnimation;

namespace HBTST.UI
{
    public partial class RoverSimulation : Form
    {

        MongoGenericRepository<RoverArea> mongoGenericRepositoryRoverArea = new MongoGenericRepository<RoverArea>();
        IMongoGenericRepository<Entity.Concrete.Rover> mongoGenericRepositoryRover = new MongoGenericRepository<Entity.Concrete.Rover>();
        IMongoGenericRepository<RoverHistory> mongoGenericRepositoryHistory = new MongoGenericRepository<RoverHistory>();
        public string selectedRoverAreaName = "";
        public List<RoverHistory> roverHistoryList = new List<RoverHistory>();
        public RoverSimulation()
        {
            InitializeComponent();
        }

        public void ListArea()
        {
            foreach (var roverArea in mongoGenericRepositoryRoverArea.GetAll())
            {
                listBoxArea.Items.Add(roverArea.Name);
            }
        }

        public void ListRover()
        {
            listBoxRover.Items.Clear();
            foreach (var rovers in mongoGenericRepositoryRover.GetAll())
            {
                listBoxRover.Items.Add(rovers.Name);
            }
        }
        private void RoverSimulation_Load(object sender, EventArgs e)
        {
            ActiveControl = buttonRoverAdd;
            ListArea();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int areaID = mongoGenericRepositoryRoverArea.GetByName(listBoxArea.GetItemText(listBoxArea.SelectedItem)).ID;
                string roverName = listBoxRover.GetItemText(listBoxRover.SelectedItem);
                var rover = mongoGenericRepositoryRover.GetByName(roverName);
                string areaName = listBoxArea.GetItemText(listBoxArea.SelectedItem);
                rover.X = Convert.ToInt32(customTextBoxX.Text);
                rover.Y = Convert.ToInt32(customTextBoxY.Text);
                rover.Direction = comboBoxDirection.Text;
                rover.Name = roverName;
                string command = "";
                for (int i = 0; i < listBoxRoverMoveCommand.Items.Count; i++)
                {
                    if (listBoxRoverMoveCommand.Items[i].ToString().ToUpper() != "M" || listBoxRoverMoveCommand.Items[i].ToString().ToUpper() != "L" || listBoxRoverMoveCommand.Items[i].ToString().ToUpper() != "R")
                    {

                    }
                    command += listBoxRoverMoveCommand.Items[i].ToString();
                }
                RoverHistory roverHistory = new RoverHistory(rover.ID, rover.ID, areaID, DateTime.Now,
                    customTextBoxX.Text + " " + customTextBoxY.Text + " " + comboBoxDirection.Text, command);
                roverHistory.Name = roverName;
                listBoxRoverMoveCommand.Items.Clear();
                roverHistoryList.Add(roverHistory);
                dataGridView1.Rows.Add(roverHistory.Id, rover.Name, areaName, roverHistory.CreatedDate,
                    roverHistory.StartingPosition, roverHistory.EndingPosition, roverHistory.Command);
            }
            catch (Exception)
            {

                MessageBox.Show("Kutucuklar dolu olmalı");
            }



        }

        private void listBoxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListRover();
        }

        private void listBoxRover_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedRoverName = listBoxRover.GetItemText(listBoxRover.SelectedItem);
            //var rover = mongoGenericRepositoryRover.GetByName(selectedRoverName);
        }

        private void customTextBox1_TextChanged(object sender, EventArgs e)
        {

            string searchedText = customTextBox1.Text.ToUpper();

            if (searchedText.Length >= 3 && searchedText != "SEARCH AREA NAME")
            {
                for (int i = 0; i < listBoxArea.Items.Count; i++)
                {
                    if (listBoxArea.Items[i].ToString().ToUpper().Contains(searchedText) == false)
                    {
                        listBoxArea.Items.RemoveAt(i);
                    }
                }
            }
            else if (customTextBox1.Text.Length < 3)
            {
                listBoxArea.Items.Clear();
                ListArea();
            }
        }

        private void customTextBox2_TextChanged(object sender, EventArgs e)
        {
            string searchedText = customTextBox2.Text.ToUpper();

            if (searchedText.Length >= 3 && searchedText != "SEARCH ROVER NAME")
            {
                for (int i = 0; i < listBoxRover.Items.Count; i++)
                {
                    if (listBoxRover.Items[i].ToString().ToUpper().Contains(searchedText) == false)
                    {
                        listBoxRover.Items.RemoveAt(i);
                    }
                }
            }
            else if (customTextBox2.Text.Length < 3)
            {
                listBoxRover.Items.Clear();
                ListRover();
            }
        }

        public bool CheckCommandText(string commandText)
        {
            if (commandText.ToUpper() == "M" || commandText.ToUpper() == "L" || commandText.ToUpper() == "R")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Hatalı Yön Girişi : " + commandText.ToUpper());
                return false;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (customTextBoxMoveCommand.Text.Length > 1)
            {
                char[] roverCommandText = customTextBoxMoveCommand.Text.ToCharArray();
                for (int i = 0; i < roverCommandText.Length; i++)
                {
                    if (CheckCommandText(roverCommandText[i].ToString()))
                    {
                        listBoxRoverMoveCommand.Items.Add(roverCommandText[i]);
                    }
                }
            }
            else
            {
                if (CheckCommandText(customTextBoxMoveCommand.Text))
                {
                    listBoxRoverMoveCommand.Items.Add(customTextBoxMoveCommand.Text);
                }
            }
            customTextBoxMoveCommand.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            foreach (var roverHistoryItem in roverHistoryList)
            {
                var rover = mongoGenericRepositoryRover.GetByID(roverHistoryItem.ID);
                rover.X = int.Parse(customTextBoxX.Text);
                rover.Y = int.Parse(customTextBoxY.Text);
                rover.Direction = comboBoxDirection.Text;

                char[] roverCommand = roverHistoryItem.Command.ToCharArray();

                for (int i = 0; i < roverCommand.Length; i++)
                {
                    if (rover.Move(roverCommand[i].ToString().ToUpper()) == false)
                    {
                        MessageBox.Show("Rover hareketi sadece L,R,M harflerinden oluşur. Tekrar deneyin.");
                    }
                }
                roverHistoryItem.EndingPosition = rover.X + " " + rover.Y + " " + rover.Direction;
                mongoGenericRepositoryHistory.Add(roverHistoryItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoverSimulationList roverSimulationList = new RoverSimulationList();
            roverSimulationList.ShowDialog();
        }

        
    }
}