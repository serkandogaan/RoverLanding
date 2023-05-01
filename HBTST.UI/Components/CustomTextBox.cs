using Microsoft.VisualBasic.Compatibility.VB6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBTST.UI.Components
{
    public class CustomTextBox : TextBox
    {
        // buraya yazdığım her bir property ler textbox a artı özellik olarak ekleniyor.

        private string _placeHolder; // placeholder özelliği

        public string Placeholder { 
            get 
            {
                return _placeHolder;
            } 
            set 
            {
                ForeColor = Color.Gray;
                _placeHolder = value;
                Text = _placeHolder;
            } 
        }
        public bool OnlyNumber { get; set; } // sadece sayı girişi özelliği

        public CustomTextBox()
        {
            Enter += textBox_Enter;
            Leave += textBox_Leave;
            KeyPress += CustomTextBox_KeyPress;
        }
        private void CustomTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (OnlyNumber == true)
            {
                if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                {
                    e.Handled = true;
                }
            }          
        }
        public void textBox_Leave(object sender, EventArgs e)
        {
            CustomTextBox textBox = ((CustomTextBox)sender);        
            if (textBox.Text == "")
            {
                textBox.Text = textBox.Placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }
        public void textBox_Enter(object sender, EventArgs e)
        {
            CustomTextBox textBox = ((CustomTextBox)sender);

            textBox.ForeColor = Color.Black;
            if (textBox.Text == textBox.Placeholder)
            {
                textBox.Text = "";
            }
        }
    }
}
