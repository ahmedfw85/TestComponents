using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestComponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedValue = (int)numericUpDown1.Value;
            if (radioButton1.Checked == true)
            {
                label1.Text = "Green is slected " + selectedValue + " times";
            }
            if (radioButton2.Checked == true)
            {
                label1.Text = "Red is slected " + selectedValue + " times"; 
            }
            if (radioButton3.Checked == true)
            {
                label1.Text = "Blue is slected " + selectedValue + " times"; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 10);
            pictureBox1.Location = new Point(pictureBox1.Location.X + number, pictureBox1.Location.Y);
            number = rnd.Next(1, 15);
            pictureBox2.Location = new Point(pictureBox2.Location.X + number, pictureBox2.Location.Y);
            if (pictureBox1.Left > 600 || pictureBox2.Left > 600)
                timer1.Enabled = false;

            if (pictureBox1.Left > 600)
                MessageBox.Show("The first Rabbit has won");
            if (pictureBox2.Left > 600)
                MessageBox.Show("The second Rabbit has won");

        }

    }
}
