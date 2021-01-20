using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karty_Zakharov_Denis_
{
    public partial class Settings : Form
    { Pole myForm = new Pole();
        public Settings()
        {
            InitializeComponent();
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            
                  myForm.Show();
            this.Visible = false;
            
        }

        private void btnCar1_Click(object sender, EventArgs e)
        {
            foreach (PictureBox ee in myForm.groupBox1.Controls)
            {               
                    ee.Image=Properties.Resources.card1;
                }
            foreach (PictureBox ee in myForm.groupBox2.Controls)
            {
                ee.Image = Properties.Resources.card1;
            }
               
            }
        

        private void btnCar2_Click(object sender, EventArgs e)
        {
            foreach (PictureBox ee in myForm.groupBox1.Controls)
            {
                ee.Image = Properties.Resources.card2;
            }
            foreach (PictureBox ee in myForm.groupBox2.Controls)
            {
                ee.Image = Properties.Resources.card2;
            }
        }

        private void btnCar3_Click(object sender, EventArgs e)
        {
            foreach (PictureBox ee in myForm.groupBox1.Controls)
            {
                ee.Image = Properties.Resources.card3;
            } foreach (PictureBox ee in myForm.groupBox2.Controls)
            {
                ee.Image = Properties.Resources.card3;
            }
        }

        private void btnCar4_Click(object sender, EventArgs e)
        {
            foreach (PictureBox ee in myForm.groupBox1.Controls)
            {
                ee.Image = Properties.Resources.card4;
            }
            foreach (PictureBox ee in myForm.groupBox2.Controls)
            {
                ee.Image = Properties.Resources.card4;
            }
        }

        private void btnCar5_Click(object sender, EventArgs e)
        {
            foreach (PictureBox ee in myForm.groupBox1.Controls)
            {
                ee.Image = Properties.Resources.card5;
            }
            foreach (PictureBox ee in myForm.groupBox2.Controls)
            {
                ee.Image = Properties.Resources.card5;
            }
        }

        private void btnCar6_Click(object sender, EventArgs e)
        {
            foreach (PictureBox ee in myForm.groupBox1.Controls)
            {
                ee.Image = Properties.Resources.card6;
            }
            foreach (PictureBox ee in myForm.groupBox2.Controls)
            {
                ee.Image = Properties.Resources.card6;
            }
        }

        private void btnCar7_Click(object sender, EventArgs e)
        {
            foreach (PictureBox ee in myForm.groupBox1.Controls)
            {
                ee.Image = Properties.Resources.card7;
            }
            foreach (PictureBox ee in myForm.groupBox2.Controls)
            {
                ee.Image = Properties.Resources.card7;
            }
        }
 private void btnCar8_Click(object sender, EventArgs e)
        {
            foreach (PictureBox ee in myForm.groupBox1.Controls)
            {
                ee.Image = Properties.Resources.card8;
            }
            foreach (PictureBox ee in myForm.groupBox2.Controls)
            {
                ee.Image = Properties.Resources.card8;
            }
        }
        private void btnCar9_Click(object sender, EventArgs e)
        {
            foreach (PictureBox ee in myForm.groupBox1.Controls)
            {
                ee.Image = Properties.Resources.card9;
            }
            foreach (PictureBox ee in myForm.groupBox2.Controls)
            {
                ee.Image = Properties.Resources.card9;
            }
        }
    }
}
