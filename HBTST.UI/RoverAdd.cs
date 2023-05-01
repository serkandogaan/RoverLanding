using HBTST.DataAccess;
using HBTST.Entity.Concrete;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HBTST.UI
{
    public partial class RoverAdd : Form
    {
        //private readonly RoverUI _roverUI;
        private readonly int _landingX;
        private readonly int _landingY;
        private readonly int _gridListCount;
        public RoverAdd(int x, int y, int gridListCount)
        {
            InitializeComponent();
            _landingX = x;
            _landingY = y;
            _gridListCount = gridListCount;
        }
        private void RoverAdd_Load(object sender, EventArgs e)
        {
            textBoxName.ForeColor = Color.Gray;
            textBoxX.ForeColor = Color.Gray;
            textBoxY.ForeColor = Color.Gray;
            comboBoxDirection.ForeColor = Color.Gray;
            ActiveControl = buttonCancel;          
        }

        //private void TextBoxEnter(object sender, EventArgs e)
        //{
        //    _roverUI.textBox_Enter(sender, e);
        //}

        //private void TextBoxLeave(object sender, EventArgs e)
        //{
        //    _roverUI.textBox_Leave(sender, e);
        //}

        private void TextBoxNumberKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void comboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDirection.ForeColor = Color.Black;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            RoverAddWarning roverAddWarning = new RoverAddWarning(this);
            if (comboBoxDirection.Text != "Direction" || textBoxName.Text != "Rover Name" || textBoxX.Text != "Rover X Position" || textBoxY.Text != "Rover Y Position")
            {

                var dialogresult = MessageBox.Show("İptal Etmek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogresult == DialogResult.Yes)
                {
                    Close();
                }
                
                //roverAddWarning.Show();
            }
            else
            {
                Close();
            }
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            try
            {
                RoverDAL roverDAL = new RoverDAL();
                Rover rover = new Rover(_gridListCount + 1, int.Parse(textBoxX.Text), int.Parse(textBoxY.Text), comboBoxDirection.Text, textBoxName.Text);

                if (!rover.LandingArea(_landingX, _landingY))
                {
                    MessageBox.Show("Rover, Dünya dışına konuşlanamaz","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (roverDAL.CheckListRover(rover.X, rover.Y) && rover.LandingArea(_landingX, _landingY))
                {
                    //_roverUI.dataGridViewRoverList.Rows.Add(Convert.ToInt32(_gridListCount) + 1, rover.X + " " + rover.Y + " " + rover.Direction, rover.Name);
                    roverDAL.Add(rover);
                }


                // roverdal listesine eklediğim rover ı grid e update / refresh edemediğim
                // için önce clear dedim sonra listeyi tekrar eşitledim.
                //_roverUI.dataGridViewRoverList.Rows.Clear();
                //_roverUI.dataGridViewRoverList = _roverUI.Gets();


                //

                //_roverUI.dataGridViewRoverList.Rows.Add(Convert.ToInt32(count) + 1, rover.X + " " + rover.Y + " " + rover.Direction, rover.Name);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Giriş Bilgileri Hatalı");
            }           

        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }

            //if (!(Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57 || Convert.ToInt32(e.KeyChar) == 8))
            //{
            //    e.Handled = true;
            //}

        }

        private void comboBoxDirection_KeyPress(object sender, KeyPressEventArgs e)
        {

            // char is letter or digit ile harf veya rakam girişi ise true dön.
            // silme kontrolü için is control ile silme tuşu ise de true dön.
            // e. handled = true ile olayı gerçekleştirme diyorum.

            if (char.IsLetterOrDigit(e.KeyChar) == true  || char.IsControl(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
    }
}

