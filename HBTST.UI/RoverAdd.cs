using HBTST.DataAccess;
using HBTST.Entity.Concrete;
using Repositories.Abstract;
using Repositories.Concrete;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HBTST.UI
{

    // textler boş gelecek.

    public delegate void RoverAdded();
    public partial class RoverAdd : Form
    {
        IMongoGenericRepository<RoverArea> mongoGenericRepository = new MongoGenericRepository<RoverArea>();

        private readonly int _landingX;
        private readonly int _landingY;
        private RoverDAL _roverDal;
        private RoverAdded _roverAdded;

        public RoverAdd(int x, int y, RoverDAL roverDal, RoverAdded addedEvent)
        {
            // değerleri yukarıdaki değişkenlere eşitleyip, RoverAdd class ta her yerde erişmeni sağlıyor.

            InitializeComponent();
            _landingX = x;
            _landingY = y;
            _roverDal = roverDal;
            _roverAdded = addedEvent;

        }
        private void RoverAdd_Load(object sender, EventArgs e)
        {
            textBoxName.ForeColor = Color.Gray;
            textBoxX.ForeColor = Color.Gray;
            textBoxY.ForeColor = Color.Gray;
            comboBoxDirection.ForeColor = Color.Gray;
            ActiveControl = buttonCancel;
        }

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
            if (comboBoxDirection.Text != "Direction" || textBoxName.IsEmpty() || textBoxX.IsEmpty() || textBoxY.IsEmpty())
            {
                var dialogresult = MessageBox.Show("İptal Etmek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogresult == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.IsEmpty() || textBoxX.IsEmpty() || textBoxY.IsEmpty())
            {
                MessageBox.Show("Giriş Bilgileri Hatalı");
                return;
            }
            Entity.Concrete.Rover rover = new Entity.Concrete.Rover(int.Parse(textBoxX.Text), int.Parse(textBoxY.Text), comboBoxDirection.Text, textBoxName.Text);

            if (!rover.LandingArea(_landingX, _landingY))
            {
                MessageBox.Show("Rover, Dünya dışına konuşlanamaz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_roverDal.CheckListRover(rover.X, rover.Y) && rover.LandingArea(_landingX, _landingY))
            {
                _roverDal.Add(rover);
                _roverAdded();

            }

            Close();

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

            if (char.IsLetterOrDigit(e.KeyChar) == true || char.IsControl(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
    }
}

