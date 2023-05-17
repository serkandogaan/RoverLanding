using HBTST.DataAccess;
using System;
using System.Windows.Forms;

namespace HBTST.UI
{
    public delegate void RoverDeleted(int page);
    public partial class RoverDeleteWarning : Form
    {
        private string _objectID;
        private RoverDAL _roverDAL;
        private RoverDeleted _roverDeleteWarning;
        private int _currentPage;
        public RoverDeleteWarning(RoverDAL roverDAL, RoverDeleted roverDeleteWarning, string objectID , int currentPage)
        {
            InitializeComponent();
            _roverDAL = roverDAL;
            _roverDeleteWarning = roverDeleteWarning;
            _objectID = objectID;
            _currentPage = currentPage;
        }

        private void buttonDeleteNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDeleteYes_Click(object sender, EventArgs e)
        {
            _roverDAL.Delete(_objectID);
            _roverDeleteWarning(_currentPage);
            Close();
        }

        private void RoverDeleteWarning_Load(object sender, EventArgs e)
        {

        }
    }
}
