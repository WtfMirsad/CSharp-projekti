using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        string poruka="";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            poruka = "Dear " + txtFirstName.Text + " " + txtLastName.Text + ", \nPlease check your email " + txtEmail.Text + " for confirmation";
            MessageBox.Show(poruka,"");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
