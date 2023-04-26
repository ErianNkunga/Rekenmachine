using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine
{
    public partial class frmRekenmachine : Form
    {
        string Totaal;

        double nummer1; 
        double nummer2;

        string oper;

        double result;
        public frmRekenmachine()
        {
            InitializeComponent();
        }

       

        private void bttn3_Click(object sender, EventArgs e)
        {
            txtBxResult.Text = txtBxResult.Text + 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtBxResult.Text);
            txtBxResult.Text = Convert.ToString(-1 * a);
        }

        private void bttn1_Click(object sender, EventArgs e)
        {
            txtBxResult.Text = txtBxResult.Text + 1;
        }

        private void bttn2_Click(object sender, EventArgs e)
        {
            txtBxResult.Text = txtBxResult.Text + 2;
        }

        private void bttn4_Click(object sender, EventArgs e)
        {
            txtBxResult.Text = txtBxResult.Text + 4;
        }

        private void bttn5_Click(object sender, EventArgs e)
        {
            txtBxResult.Text = txtBxResult.Text + 5;
        }

        private void bttn6_Click(object sender, EventArgs e)
        {
            txtBxResult.Text = txtBxResult.Text + 6;
        }

        private void bttn7_Click(object sender, EventArgs e)
        {
            txtBxResult.Text = txtBxResult.Text + 7;
        }

        private void bttn8_Click(object sender, EventArgs e)
        {
            txtBxResult.Text = txtBxResult.Text + 8;
        }

        private void bttn9_Click(object sender, EventArgs e)
        {
            txtBxResult.Text = txtBxResult.Text + 9;
        }

        private void bttnPlus_Click(object sender, EventArgs e)
        {
            


            nummer1 = double.Parse(txtBxResult.Text);

            oper = "+";        
            
            txtBxResult.Text = "";




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nummer2 = double.Parse(txtBxResult.Text);

            switch(oper)
            {
                case "+":
                    txtBxResult.Text = (nummer1 + nummer2).ToString();
                    break;
                
                case "-":
                    txtBxResult.Text = (nummer1 - nummer2).ToString();
                    break;

                case "*":
                    txtBxResult.Text = (nummer1 * nummer2).ToString();
                    break;

                case "/":
                    txtBxResult.Text = (nummer1 / nummer2).ToString();
                    break;

                default:
                    break;






            }

        }

        private void bttn0_Click(object sender, EventArgs e)
        {
            txtBxResult.Text = txtBxResult.Text + 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nummer1 = double.Parse(txtBxResult.Text);

            oper = "-";

            txtBxResult.Text = "";

        }

        private void FrmRekenmachine_Load(object sender, EventArgs e)
        {

        }

        private void txtBx_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bttnKomma_Click(object sender, EventArgs e)
        {
            txtBxResult.Text = txtBxResult.Text + ",";
        }

        private void bttnX_Click(object sender, EventArgs e)
        {
            nummer1 = double.Parse(txtBxResult.Text);

            oper = "*";

            txtBxResult.Text = "";

        }

        private void bttnGedeeld_Click(object sender, EventArgs e)
        {
            nummer1 = double.Parse(txtBxResult.Text);

            oper = "/";

            txtBxResult.Text = "";

        }

        private void bttndelete_Click(object sender, EventArgs e)
        {
            txtBxResult.Text = "";
        }
    }
}
