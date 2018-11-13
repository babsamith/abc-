using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignemnt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from = textBox1.Text.ToLower();
            string to = textBox2.Text.ToLower();
            string radio;
            if (radioButton1.Checked)    // give a value to radio variable
            {
                radio = "Ryde pool";
            }
            else
            {
                radio = "Ryde direct";
            }
            if (from == "" && to == "")   // textbox validation
            {
                MessageBox.Show("Please enter locations");
            }
            else if (from == "")  // to check if pickup location is empty
            {
                MessageBox.Show("Please enter your pickup location");
            }
            else if (to == "") //to check if destination location is empty
            {
                MessageBox.Show("Please enter your destination location");
            } 
            // check if loction is valid or not
            else if (from != "fairview mall" && from !="275 yorkland blvd" && to != "tim hortons" && to != "cn tower" || 
                     from == "fairview mall" && to != "tim hortons" || from != "fairview mall" && to == "tim hortons" 
                     || from == "275 yorkland blvd" && to != "cn tower" || from != "275 yorkland blvd" && to == "cn tower")
            {
                MessageBox.Show("Please enter valid locations");
            }

            else if(radioButton1.Checked || radioButton2.Checked)   // if one radio button was checked then open a form to
            {                Form2 form2 = new Form2(from, to,radio);
                form2.ShowDialog();   
                
            }
            else  // show a error message 
            {
                MessageBox.Show("Please select a one ride");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
} 
