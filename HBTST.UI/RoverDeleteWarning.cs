using System;
using System.Windows.Forms;

namespace HBTST.UI
{
    public partial class RoverDeleteWarning : Form
    {
        private RoverUI _roverUI;
        public RoverDeleteWarning(RoverUI roverUI)
        {
            InitializeComponent();
            _roverUI = roverUI;
        }

        private void buttonDeleteNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDeleteYes_Click(object sender, EventArgs e)
        {
            if (_roverUI.dataGridViewRoverList.CurrentCell.Value != null)
            {
                int index = _roverUI.dataGridViewRoverList.CurrentCell.RowIndex;
                _roverUI.dataGridViewRoverList.Rows.RemoveAt(index);
            }
            
            Close();
        }

        private void RoverDeleteWarning_Load(object sender, EventArgs e)
        {

        }
    }
}
