using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyMathLibrary;

namespace FormOrder
{
    public partial class FormWhile3 : Form
    {
        public FormWhile3()
        {
            InitializeComponent();
        }

        private void buttonSolve1_Click(object sender, EventArgs e)
        {
            int n;
            bool isok = int.TryParse(textBoxN1.Text, out n);
            if (isok == false)
            {
                MessageBox.Show("Error");
            }
            else
            {
                double res = MyMath.while3(n);
                textBoxRes.Text = Math.Round(res, 2).ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
