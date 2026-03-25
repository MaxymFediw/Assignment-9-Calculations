using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_9_Calculations
{
    public partial class Form1 : Form 
        //Maxym F.
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblAdd.Text = "8 + 2 = " + (8 + 2);
            lblAdd.Visible = true;
            
            lblSubtract.Visible = false;
            lblMultiply.Visible = false;
            lblDivide.Visible = false;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            lblSubtract.Text = "8 - 2 = " + (8 - 2);
            lblSubtract.Visible = true;
           
            lblAdd.Visible = false;
            lblMultiply.Visible = false;
            lblDivide.Visible = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblMultiply.Text = "8 x 2 = " + (8 * 2);
            lblMultiply.Visible = true;
            
            lblAdd.Visible = false;
            lblSubtract.Visible = false;
          
            lblDivide.Visible = false;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lblDivide.Text = "8 ÷ 2 = " + (8 / 2);
            lblDivide.Visible = true;

            lblAdd.Visible = false;
            lblSubtract.Visible = false;
            lblMultiply.Visible = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
            btnQuit.Visible = true;
        }
    }
}
