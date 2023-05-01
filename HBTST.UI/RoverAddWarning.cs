using System;
using System.Windows.Forms;

namespace HBTST.UI
{
    public partial class RoverAddWarning : Form
    {
        private RoverAdd _roverAdd;
        public RoverAddWarning(RoverAdd roverAdd)
        {
            InitializeComponent();
            _roverAdd = roverAdd;   
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            _roverAdd.Close();
            this.Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoverAddWarning_Load(object sender, EventArgs e)
        {

        }
    }
}
