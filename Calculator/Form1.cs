using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        ICalculate calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int sum = calculate.Plus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("حاصل جمع : " + sum);
            }
        }

        bool ValidateInputs()
        {
            bool IsValid = true;

            if (txtNumber1.Value == 0)
            {
                IsValid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید!");
            }
            else if(txtNumber2.Value == 0)
            {
                IsValid = false;
                MessageBox.Show("لطفا عدد دوم را وارد کنید!");
            }
            return IsValid;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int min = calculate.Minus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("حاصل جمع : " + min);
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int mul = calculate.Multiple((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("حاصل جمع : " + mul);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int div = calculate.Division((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("حاصل جمع : " + div);
            }
        }
    }
}
