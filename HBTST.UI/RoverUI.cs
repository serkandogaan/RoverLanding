using HBTST.DataAccess;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HBTST.UI
{
    public partial class RoverUI : Form
    {

        // char. is digit - is letter - digitorletter - isnumber - fonskiyonlarını ve e.handled ı araştır
        // ascii ile nasıl oluyor araştır öğren

        // dünya alanı dinamik olacak

        // custom textbox

        // custom palaceholder

        RoverDAL roverDAL = new RoverDAL();
        public RoverUI()
        {
            InitializeComponent();
           
        }

        private void buttonRoverAdd_Click(object sender, EventArgs e)
        {
            RoverAdd roverAdd = new RoverAdd(Convert.ToInt32(textBoxWorldAreaX.Text), Convert.ToInt32(textBoxWorldAreaY.Text) ,dataGridViewRoverList.RowCount);
            if (textBoxWorldAreaX.Text != "Dünya Alanı X Boyutu" && textBoxWorldAreaY.Text != "Dünya Alanı Y Boyutu")
            {
                roverAdd.ShowDialog();
            }           
        }

        public DataGridView Gets()
        {
            
            foreach (var item in roverDAL.Gets())
            {
                dataGridViewRoverList.Rows.Add(item.ID, item.X + " " + item.Y + " " + item.Direction, item.Name);
            }
            return dataGridViewRoverList;
        }

        private void RoverUI_Load(object sender, EventArgs e)
        {
            Gets();
            dataGridViewRoverList.CurrentCell.Selected = false;
            buttonRoverDelete.Enabled = false;
        }

        private void buttonRoverDelete_Click(object sender, EventArgs e)
        {
            RoverDeleteWarning roverDeleteWarning = new RoverDeleteWarning(this);
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
   
        
        //public void TextBoxAreaNumberKeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
        //    {
        //        e.Handled = true;
        //    }
        //}
        //private void textBoxWorldAreaX_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
        //    //{
        //    //    e.Handled = true; // olayın yapılıp yapılmayacağını belirliyor. true olursa yapılmaması, false ise yapılmasını belirtir
        //    //}

        //}

        //private void textBoxWorldAreaY_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    //if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
        //    //{
        //    //    e.Handled = true;
        //    //}


        //    // ascii karakterlerine göre
        //    //if (!(Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57 || Convert.ToInt32(e.KeyChar) == 8))
        //    //{
        //    //    e.Handled = true;
        //    //}
        //}
    }
}