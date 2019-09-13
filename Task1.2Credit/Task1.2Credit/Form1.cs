using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1._2Credit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblDisplay.Hide();
            rdbtnGoodbye.Checked = false;
            rdbtnHello.Checked = false;
            wbBrowser.Hide();
            btnNext.Hide();
            btnPrevious.Hide();
            btnExitBrowser.Hide();
        }

        private void RadioChosen(object sender, EventArgs e)
        {
            string lName = txtName.Text;

            if (rdbtnHello.Checked)
            {
                if(txtName.TextLength >= 1)
                {
                    lblDisplay.Text = "Hello " + lName + "!!";
                }
                else
                {
                    lblDisplay.Text = "Hello!!";
                }
                rdbtnHello.Checked = false;
                
            }
            else if(rdbtnGoodbye.Checked)
            {
                if(txtName.TextLength >= 1)
                {
                    lblDisplay.Text = "Goodbye " + lName + "!!";
                }
                else
                {
                    lblDisplay.Text = "Goodbye!!";
                }
                rdbtnGoodbye.Checked = false;
            }
            txtName.ResetText();
            lblDisplay.Show();
            lblDisplay.Left = (this.ClientSize.Width - lblDisplay.Width) / 2;
        }

        private void BtnGoogle_Click(object sender, EventArgs e)
        {
            wbBrowser.Show();
            wbBrowser.Navigate("google.com");
            btnNext.Show();
            btnPrevious.Show();
            btnExitBrowser.Show();
        }

        private void BtnYoutube_Click(object sender, EventArgs e)
        {
            wbBrowser.Show();
            wbBrowser.Navigate("www.youtube.com");
            btnNext.Show();
            btnPrevious.Show();
            btnExitBrowser.Show();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            wbBrowser.GoForward();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            wbBrowser.GoBack();
        }

        private void BtnExitBrowser_Click(object sender, EventArgs e)
        {
            wbBrowser.Hide();
            btnNext.Hide();
            btnPrevious.Hide();
            btnExitBrowser.Hide();
        }
    }
}
