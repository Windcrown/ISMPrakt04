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
    public partial class FormFor5 : Form
    {
        public FormFor5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
                double res = MyMath.for5(n);
                textBoxRes.Text = Math.Round(res, 2).ToString();
            }
        }
    }
}
