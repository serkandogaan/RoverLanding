using HBTST.DataAccess;
using HBTST.Entity.Concrete;
using HBTST.UI.Components;
using PagedList;
using Repositories.Abstract;
using Repositories.Concrete;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBTST.UI
{
    
    public partial class RoverUI : Form
    {

        // 2 tane delegate.

        /* SQL Terimler : database, database'in tabloları olur, her tablonun bir row'u olur. ve rowlarında columns u olur.
         * database - tables - rows(satırlar) - columns (sütunler)
         * 
         * SQL - ilişkisel database
         * 
         * NOSQL - ilişkisel değil
         * 
         * MongoDB Terimler : database, database'in collection ları olur. collection nın dökümanı olur. dökümanlarında fields ları olur.
         * database - collection - documents(bson) - fields
         * 
         * 
         */

        // mongodb, çok amaçlı - döükman tabanlı - dağıtılmış bir veritabanıdır.
        // çok amaçlı : 

        // dağıtılmış : verilerin tek bir bilgisayarda olma zorunluluğunun olmadığı 

        // char. is digit - is letter - digitorletter - isnumber - fonskiyonlarını ve e.handled ı araştır
        // ascii ile nasıl oluyor araştır öğren


        // değişken skopu nerde baişar nerde biter. skop tanımı nedir

        // mongodb ile dataaccess i bağla.
        // static nedir
        // mongo db static

        // repository pattern dataacces ile repostiroy

        RoverDAL roverDAL = new RoverDAL();

        IMongoGenericRepository<Entity.Concrete.Rover> mongoGenericRepository = new MongoGenericRepository<Entity.Concrete.Rover>();

        int pageNumber = 1;
        public RoverUI()
        {
            InitializeComponent();

        }


        private void buttonRoverAdd_Click(object sender, EventArgs e)
        {
            RoverAdd roverAdd = new RoverAdd(2, 2, roverDAL, Gets);
            roverAdd.ShowDialog();
            // listede area var mı kontrol ettir.

            //if (textBoxWorldAreaX.Text != "Dünya Alanı X Boyutu" && textBoxWorldAreaY.Text != "Dünya Alanı Y Boyutu")
            //{
            //    RoverAdd roverAdd = new RoverAdd(Convert.ToInt32(textBoxWorldAreaX.Text), Convert.ToInt32(textBoxWorldAreaY.Text), roverDAL, Gets);
            //    roverAdd.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Dünya Alanları Boş Bırakılamaz.");
            //}
        }

        public void Gets(int pageNumber)
        {
            dataGridViewRoverList.DataSource = mongoGenericRepository.GetAll().ToPagedList(pageNumber, 10).ToList();
            buttonNext.Enabled = mongoGenericRepository.GetAll().ToPagedList(pageNumber, 10).HasNextPage;
            buttonPrev.Enabled = mongoGenericRepository.GetAll().ToPagedList(pageNumber, 10).HasPreviousPage;
            //buttonNext.Enabled = roverDAL.PagedRoverList(pageNumber).HasNextPage;
            //buttonPrev.Enabled = roverDAL.PagedRoverList(pageNumber).HasPreviousPage;
        }
        public void Gets()
        {
            dataGridViewRoverList.DataSource = roverDAL.Gets();
        }
        private void RoverUI_Load(object sender, EventArgs e)
        {
            Gets(pageNumber);
            pagination1.PageNumber = 1;
            pagination1.SetPageNumber(roverDAL.PagedRoverList().PageCount);
            pagination1.NextPage += Gets;
            pagination1.PrevPage += Gets;
                     
            if (dataGridViewRoverList.Rows.Count > 0)
            {
                dataGridViewRoverList.CurrentCell.Selected = false;
            }
            buttonRoverDelete.Enabled = false;
            labelCurrentPage.Text = roverDAL.PagedRoverList().PageNumber.ToString();
            labelTotalPage.Text = roverDAL.PagedRoverList().PageCount.ToString();
            label2.Text = roverDAL.PagedRoverList().TotalItemCount.ToString();

            


        }
        private void buttonRoverDelete_Click(object sender, EventArgs e)
        {
            RoverDeleteWarning roverDeleteWarning = new RoverDeleteWarning(roverDAL, Gets, dataGridViewRoverList.CurrentRow.Cells[0].Value.ToString(), pageNumber);
            roverDeleteWarning.Show();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRoverList.CurrentCell.Value == null)
            {
                buttonRoverDelete.Enabled = false;
            }
            else
            {
                buttonRoverDelete.Enabled = true;
            }
        }
        private void baslikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Random newRandom = new Random();
            //var randomNumberX = newRandom.Next(1, 100);
            //var randomNumberY = newRandom.Next(1, 100);

            //for (int i = 0; i < 25; i++)
            //{
            //    Entity.Concrete.Rover rover = new Entity.Concrete.Rover(i, randomNumberX, randomNumberY, "S", "Rover - " + i);
            //    roverDAL.Add(rover);
            //}
        }

        private void SetCurrentPage()
        {
            labelCurrentPage.Text = pageNumber.ToString();
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            Gets(++pageNumber);
            SetCurrentPage();
        }
        private void buttonPrev_Click(object sender, EventArgs e)
        {
            
            Gets(--pageNumber);
            SetCurrentPage();

        }

        private void pagination1_Load(object sender, EventArgs e)
        {

        }

        private void buttonWorldAreaAdd_Click(object sender, EventArgs e)
        {
            WordlAreaManagment wordlAreaManagment = new WordlAreaManagment();
            wordlAreaManagment.ShowDialog();
        }

        private void buttonSimulation_Click(object sender, EventArgs e)
        {
            RoverSimulation roverSimulation = new RoverSimulation();
            roverSimulation.ShowDialog();
        }

        private void RoverUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}