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
    public partial class Formorder : Form
    {
        public Formorder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonfor1_Click(object sender, EventArgs e)
        {
            FormFor1 form = new FormFor1();
            form.ShowDialog();
        }

        private void buttonfor2_Click(object sender, EventArgs e)
        {
            FormFor2 form = new FormFor2();
            form.ShowDialog();
        }

        private void buttonfor3_Click(object sender, EventArgs e)
        {
            FormFor3 form = new FormFor3();
            form.ShowDialog();
        }

        private void buttonfor4_Click(object sender, EventArgs e)
        {
            FormFor4 form = new FormFor4();
            form.ShowDialog();
        }

        private void buttonwhile1_Click(object sender, EventArgs e)
        {
            FormWhile1 form = new FormWhile1();
            form.ShowDialog();
        }

        private void buttonwhile2_Click(object sender, EventArgs e)
        {
            FormWhile2 form = new FormWhile2();
            form.ShowDialog();
        }

        private void buttonwhile3_Click(object sender, EventArgs e)
        {
            FormWhile3 form = new FormWhile3();
            form.ShowDialog();
        }

        private void for5_Click(object sender, EventArgs e)
        {
            FormFor5 form = new FormFor5();
            form.ShowDialog();
        }
    }
}
