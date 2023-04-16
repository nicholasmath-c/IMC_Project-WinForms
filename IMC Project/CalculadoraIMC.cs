using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_Project
{
    public partial class CalculadoraIMC : Form
    {
        public CalculadoraIMC()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





        //FRONT-END FUNCTIONS
        private void txtAltura_Enter(object sender, EventArgs e)
        {
            if(txtAltura.Text == "Metros")
            {
                txtAltura.Text = "";
                txtAltura.ForeColor = Color.FromArgb(15,15,15);
            }
        }
        private void txtAltura_Leave(object sender, EventArgs e)
        {
            if (txtAltura.Text != "Metros")
            {
                txtAltura.Text = "Metros";
                txtAltura.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                int digitCount = txtPeso.Text.Replace(txtPeso.PromptChar.ToString(), "").Length;

                if(digitCount >= 5)
                {
                    txtPeso.Mask = "000.00";
                    txtPeso.Select(txtPeso.Text.Length, 0);
                }
            }
        }
        private void txtPeso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                string txt = txtPeso.Text.Replace(txtPeso.PromptChar.ToString(), "");

                txtPeso.Mask = "00.00";
                txtPeso.Text = txt;
            }
        }
        private void numIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //IGNORE
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void numIdade_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void lblIMC_Click(object sender, EventArgs e)
        {

        }
        private void btnCalc_Click(object sender, EventArgs e)
        {

        }
    }
}
