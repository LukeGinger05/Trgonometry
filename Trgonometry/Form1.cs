using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trgonometry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //input values for Force and Angle from textboxes
            double Force = double.Parse(textBox1.Text);
            double Angle = double.Parse(textBox2.Text);
            
            //calculate values for Fx and Fy
            Double Fx = Force* cos(Angle);
            Double Fy = Force* sin(Angle);


        }
    }
}
