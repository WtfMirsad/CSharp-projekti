using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mirsad.Zukic_task2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblRez_Click(object sender, EventArgs e)
        {

        }
        //Metre u Kilometre
        //Metre u Centimetre
        //Metre u Milimetre
        public double koverzija(double broj) {
            if (comboBox1.Text == "Celzijus u Kelvine")
                {
                 return broj - 273.150;
                }
            else if (comboBox1.Text == "Celzijus u Fahrenhiet")
                {
                    return (broj * 1.8000)+32;
                }
           
            else { return 0; }
        
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Celzijus u Kelvine")
            {
                lblRez.Text = "Kelvini";
                if (textBox1.Text == "") { ;}
                else {
                    txtRez.Text = Convert.ToString(koverzija(Convert.ToDouble(textBox1.Text)));
                }
                
            }
            else if (comboBox1.Text == "Celzijus u Fahrenhiet")
            {
                lblRez.Text = "Fahrenhiet";
                if (textBox1.Text == "") { ;}
                else { txtRez.Text = Convert.ToString(koverzija(Convert.ToDouble(textBox1.Text))); }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { ;}
            else
            {
                txtRez.Text = Convert.ToString(koverzija(Convert.ToDouble(textBox1.Text)));
            }
        }
    }
}
