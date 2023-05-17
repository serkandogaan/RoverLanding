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

namespace HBTST.UI
{
    public partial class RoverSimulationList : Form
    {
        IMongoGenericRepository<RoverHistory> mongoGenericRepository = new MongoGenericRepository<RoverHistory>();
        public RoverSimulationList()
        {
            InitializeComponent();
        }

        private void RoverSimulationList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mongoGenericRepository.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dayStart = dateTimePickerStartDate.Value.Day;
            var dayEnd = dateTimePickerEndDate.Value.Day;
            dataGridView1.DataSource = mongoGenericRepository.GetbyWhere(x => x.Name.Contains(customTextBoxRoverName.Text) 
            || (x.CreatedDate.Day >= dayStart && x.CreatedDate.Day <= dayEnd)).ToList();
        }
    }
}
