using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBTST.UI.Components
{
    public delegate void ButtonNext(int pageNumber);
    public delegate void ButtonPrev(int pageNumber);
    public partial class Pagination : UserControl
    {
        public int PageNumber { get; set; }
        private int _totalPageNumber;
        public event ButtonNext NextPage;
        public event ButtonPrev PrevPage;

      
        public Pagination()
        {
            InitializeComponent();
        }
        public void SetPageNumber(int pageNumber)
        {
            _totalPageNumber = pageNumber;
            customPaginationTotalPageNumber.Text = pageNumber.ToString();
        } 

        private void Pagination_Load(object sender, EventArgs e)
        {         
            //customPaginationTotalPageNumber.Text = TotalPageNumber.ToString();
        }

        private void buttonPrevPage_Click(object sender, EventArgs e)
        {
            PrevPage(--PageNumber);
            buttonNextPage.Enabled = true;
            SetPageNumber();

            if (PageNumber == 1)
            {
                buttonPrevPage.Enabled = false;
            }          
        }
       
        public void SetPageNumber()
        {
            customPaginationPageNumber.Text = PageNumber.ToString();
        }
        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            NextPage(++PageNumber);
            SetPageNumber();
            if (PageNumber == _totalPageNumber)
            {
                buttonNextPage.Enabled = false;
            }
            buttonPrevPage.Enabled = true;
        }

       
    }
}
