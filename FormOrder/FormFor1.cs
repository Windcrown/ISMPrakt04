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
    public partial class FormFor1 : Form
    {
        public FormFor1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSolve1_Click(object sender, EventArgs e)
        {
            int n, n2;
            bool isok = int.TryParse(textBoxN1.Text, out n);
            bool isok2 = int.TryParse(textBoxN2.Text, out n2);
            if (isok == false || isok2 == false)
            {
                MessageBox.Show("Error");
            }
            else
            {
                double res = MyMath.for1(n, n2);
                textBoxRes.Text = Math.Round(res, 2).ToString();
            }
        }
    }
}
