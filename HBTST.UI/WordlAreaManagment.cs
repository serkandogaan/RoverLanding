using HBTST.Entity.Concrete;
using MongoDB.Bson;
using MongoDB.Driver;
using PagedList;
using Repositories.Abstract;
using Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBTST.UI
{
    public partial class WordlAreaManagment : Form
    {

        IMongoGenericRepository<RoverArea> mongoGenericRepository = new MongoGenericRepository<RoverArea>();

        public static IMongoClient mongoClient = new MongoClient();
        public static IMongoDatabase mongoDatabase = mongoClient.GetDatabase("RoverDataBase");
        public IMongoCollection<Entity.Concrete.RoverArea> mongoCollection = mongoDatabase.GetCollection<Entity.Concrete.RoverArea>("RoverArea");
        public WordlAreaManagment()
        {
            InitializeComponent();
        }
        int pageNumber = 1;

        public IPagedList<Entity.Concrete.RoverArea> PagedRoverList(int pageNumber = 1)
        {
            IPagedList<Entity.Concrete.RoverArea> list = mongoCollection.AsQueryable().OrderBy(x => x.Name).ToPagedList(pageNumber, 10);
            return list;
        }

        public void Gets(int pageNumber)
        {
            dataGridViewWorld.DataSource = PagedRoverList(pageNumber).ToList();
        }

        private void WordlAreaManagment_Load(object sender, EventArgs e)
        {
            Gets(1);
            pagination1.SetPageNumber(PagedRoverList().PageCount);
            if (dataGridViewWorld.Rows.Count > 0)
            {
                dataGridViewWorld.CurrentCell.Selected = false;
            }
            buttonWorldDelete.Enabled = false;

        }

        private void buttonWorldDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewWorld.Rows.Count > 0)
            {
                string objectID = dataGridViewWorld.CurrentRow.Cells[0].Value.ToString();
                mongoCollection.DeleteOne(x => x.Id == ObjectId.Parse(objectID));
                
                Gets(PagedRoverList().PageNumber);
            }
           
        }

        private void dataGridViewWorld_SelectionChanged(object sender, EventArgs e)
        {

            buttonWorldDelete.Enabled = true;

        }

        private void buttonWorldAdd_Click(object sender, EventArgs e)
        {
            RoverArea roverArea = new RoverArea(int.Parse(textBoxWorldAreaX.Text),int.Parse(textBoxWorldAreaY.Text), customWorldName.Text);
            //mongoCollection.InsertOne(roverArea);
            mongoGenericRepository.Add(roverArea);
            Gets(pageNumber);
            
        }

        private void pagination1_Load(object sender, EventArgs e)
        {

        }
    }
}
