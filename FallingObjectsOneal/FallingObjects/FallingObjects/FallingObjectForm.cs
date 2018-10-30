/*
 * Created by: Oneal Nnah
 * Created on: 2 january 2002
 * Created for: ICS3U Programming
 * Assignment #2 - FALLING OBJECTS
 * This program...
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingObjects
{
    public partial class FallingObjectForm : Form
    {
        public FallingObjectForm()
        {
            InitializeComponent();
        }

        private void lblHeigth_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double heigth;
            heigth = double.Parse(txtHeigth.Text);

            //this is to calculate the height
            heigth = 100 - (0.5 * 9.81) * Math.Pow(heigth, 2);

            //this is to convert the text to string
            lblAnswer.Text = Convert.ToString(heigth);

           heigth = double.Parse(txtHeigth.Text);
             
            
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FallingObjectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
