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
    public partial class FormFor2 : Form
    {
        public FormFor2()
        {
            InitializeComponent();
        }

        private void textBoxN1_TextChanged(object sender, EventArgs e)
        {

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
                double res = MyMath.for2(n);
                textBoxRes.Text = Math.Round(res, 2).ToString();
            }
        }

        private void Form1num_Load(object sender, EventArgs e)
        {

        }
    }
}
