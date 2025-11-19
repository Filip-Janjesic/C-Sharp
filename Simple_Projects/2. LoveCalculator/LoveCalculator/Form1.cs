using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoveCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            string boyName = txtBoyName.Text.ToUpper();
            string girlName = txtGirlName.Text.ToUpper();
            int total = Math.Abs(boyName.GetHashCode() + girlName.GetHashCode());
            int percentage = total % 100;
            /*if(total < 0)
            {
                total *= -1;
            }*/


            string message = $"You have {percentage}% love";
            MessageBox.Show(this, message, "Love Calculator",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
