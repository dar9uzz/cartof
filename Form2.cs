using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cartof
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            CheckWin();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            CheckWin();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            CheckWin();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            CheckWin();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            CheckWin();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            CheckWin();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            CheckWin();
        }

        private void CheckWin()
        {
            if (!pictureBox1.Visible &&
                !pictureBox2.Visible &&
                !pictureBox3.Visible &&
                !pictureBox4.Visible &&
                !pictureBox5.Visible &&
                !pictureBox6.Visible &&
                !pictureBox7.Visible)

            {
                Form3 bravo = new Form3();
                bravo.Show();
                this.Hide(); // optional
            }
        }


    }
}

