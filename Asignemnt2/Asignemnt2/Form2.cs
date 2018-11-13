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
    public partial class Form2 : Form
    {
        public Form2(string fromvalue, string tovalue , string rydeoption) 
        {
            InitializeComponent();
            label4.Text = fromvalue;    
            label5.Text = tovalue;
            double cal;
            double baseFare=2.50;
            double ServiceFee = 1.75;
            double distanceCharge;
            double dis=0.81;
            DateTime time = DateTime.Now;  // current time store 
            if (fromvalue == "275 yorkland blvd" && tovalue == "cn tower")  // validation of one location
            {
                distanceCharge = dis * 22.9; // distance charge for pool ride
                if (rydeoption == "Ryde direct")  // charges increase during ride direct
                {
                    baseFare = baseFare + (1 + 10 / 100);    // base fare increase by 10% 
                    distanceCharge = distanceCharge + (1 + 15 / 100); // distance charge increase by 15%
                }
                
            }
            // validation for second location (fairview to tim hortons)
            else
            {
                distanceCharge = dis * 1.2;    
                if (rydeoption == "Ryde direct")  // charges increase during ride direct
                {
                    baseFare = baseFare + (1 + 10 / 100);// base fare increase by 10%
                    distanceCharge = distanceCharge + (1 + 15 / 100);// distance charge increase by 15%
                }
            }
            string timeLap = DateTime.Now.ToString("HH"); // only select an hour 
            int timelapint = Int32.Parse(timeLap);  // change into intege
            // validation during peak hours
            if (timelapint == 10 || timelapint == 11 || timelapint == 12 || timelapint == 16 || timelapint == 17 || timelapint == 18 || timelapint == 20 || timelapint == 21)
            {
                distanceCharge = +(1 + 20 / 100);  // diatance charge increase by 20%
            }
            cal = baseFare + distanceCharge + ServiceFee;
            // minimum fair charge 
            if (cal < 5.50)
            {
                cal = 5.50;
            }
            label9.Text = "$ " + baseFare;
            label10.Text = "$ " + Math.Round(distanceCharge,2); // upto 2 decimal points
            label11.Text = "$ " + ServiceFee;
            label13.Text = "$ " + Math.Round(cal,2);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
