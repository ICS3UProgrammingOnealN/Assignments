using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCostOneal
{
    public partial class PizzaCostForm : Form
    {
        public PizzaCostForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variable
            double subtotal, total, tax, drinks, topping, size,number;

            // calculate the cost of every product
            const double SMALL = 5.99;
            const double MEDIUM = 7.99;
            const double LARGE = 9.99;
            const double EXTRALARGE = 12.99;
            const double PEPSI = 3.99;
            const double COKE = 3.99;
            const double SPRITE = 3.99;
            const double FIRSTTOPPING = 0.75;
            const double SECONDTOPPING = 1.75;
            const double THIRDTOPPING = 2.15;
            const double FOURTHTOPPING = 2.75;
            double SelectSize;

            //  determine the size price based on user selection
            if (radSmall.Checked == true)
            {
                subtotal = SMALL;
                
            }
            else if (radMedium.Checked ==true)
            
            {
                subtotal = MEDIUM;
            }
            else if (radLarge.Checked==true)
            {
                subtotal = LARGE;
            }
            else if (radExtraLarge .Checked == true)
            {
                subtotal = EXTRALARGE;
            }
            else if(radCoke.Checked ==true)
            {
                subtotal = COKE;
            }
            else if (radSprite.Checked ==true)
            {
                subtotal = SPRITE; 
            }
            else if (radPepsi.Checked == true)
            {
                subtotal = PEPSI;
            }
            else if ()
            subtotal = SelectSize = topping;
            tax = subtotal * 0.13;
            total = subtotal = tax;

        }   
    }
}
