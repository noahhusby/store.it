using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store.it.ux.cust
{
    public partial class TextBox : UserControl
    {
        public string BoxText { get; set; }
        private string autoLine;
        public TextBox()
        {
            InitializeComponent();
            input.GotFocus += enterLine;
            input.LostFocus += leaveLine;
        }

        public void setAutoLineText(String text)
        {
            this.autoLine = text;
            input.Text = autoLine;
            input.Font = new Font("Roboto Light", 8);
        }
        private void enterLine(Object sender, EventArgs e)
        {
            input.Font = new Font("Roboto", 10);
            line.BackColor = Color.FromArgb(255, 255, 255);
            if(input.Text == autoLine)
            {
                input.Text = "";
            }
            BoxText = input.Text;
        }

        private void leaveLine(Object sender, EventArgs e)
        {
            line.BackColor = Color.FromArgb(180, 180, 180);
            input.Font = new Font("Roboto", 10);
            if (input.Text == "")
            {
                input.Font = new Font("Roboto Light", 8);
                input.Text = autoLine;
            }
            BoxText = input.Text;
        }
    }
}
