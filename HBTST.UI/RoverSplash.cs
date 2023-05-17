using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBTST.UI
{
    public partial class RoverSplash : Form
    {
        public RoverSplash()
        {
            InitializeComponent();
        }

        public void OpenDelayed()
        {
            Task.Delay(2000).ContinueWith(t => CloseDelayed());      
        }

        public void CloseDelayed()
        {
            Visible = false;
            RoverUI roverUI = new RoverUI();
            roverUI.ShowDialog();
            
            

        }
        private void RoverSplash_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            OpenDelayed();         
        }

        private void RoverSplash_FormClosing(object sender, FormClosingEventArgs e)
        {
            //RoverUI roverUI = new RoverUI();
            //roverUI.ShowDialog();
        }

        private void RoverSplash_FormClosed(object sender, FormClosedEventArgs e)
        {
            //RoverUI roverUI = new RoverUI();
            //roverUI.ShowDialog();
        }
    }
}
