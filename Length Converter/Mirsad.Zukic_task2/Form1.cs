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
                if (comboBox1.Text == "Metre u Kilometre")
                {
                 return broj / 1000;
                }
                else if (comboBox1.Text == "Metre u Centimetre")
                {
                    return broj * 100;
                }
                else if (comboBox1.Text == "Metre u Milimetre")
                {
                    return broj * 1000;
                }
           
            else { return 0; }
        
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Metre u Kilometre"){
                lblRez.Text = "Kilometri";
                if (textBox1.Text == "") { ;}
                else {
                    txtRez.Text = Convert.ToString(koverzija(Convert.ToDouble(textBox1.Text)));
                }
                
            }
            else if (comboBox1.Text == "Metre u Centimetre") {
                lblRez.Text = "Centimetri";
                if (textBox1.Text == "") { ;}
                else { txtRez.Text = Convert.ToString(koverzija(Convert.ToDouble(textBox1.Text))); }
                
            }
            else if (comboBox1.Text == "Metre u Milimetre")
            {
                lblRez.Text = "Milimetri";
                if (textBox1.Text == "") { ;}
                else
                {
                    txtRez.Text = Convert.ToString(koverzija(Convert.ToDouble(textBox1.Text)));
                }
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
