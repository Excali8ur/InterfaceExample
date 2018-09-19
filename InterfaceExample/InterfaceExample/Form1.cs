using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceExample
{
    public partial class Form1 : Form
    {
        private Tellen t;

        public Form1()
        {
            InitializeComponent();
            t = new Tellen();
        }

        private void btnOptellen_Click(object sender, EventArgs e)
        {            
            double a = Convert.ToDouble(tbGetal1.Text);
            lblOptellen.Text = t.Optellen(a).ToString();
        }

        private void bntAftrekken_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbGetal1.Text);
            lblAftrekken.Text = t.Aftrekken(a).ToString();
        }

        private void btnVermenigvuldigen_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbGetal1.Text);
            lblVermenigvuldigen.Text = t.Vermenigvuldigen(a).ToString();
        }

        private void bntDelen_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbGetal1.Text);
            lblDelen.Text = t.Delen(a).ToString();
        }

        private void btnLaatZien_Click(object sender, EventArgs e)
        {
            lblLaatZien1.Text = ((iTellen)t).Getal.ToString();
            lblLaatZien2.Text = ((iVermenigvuldigen)t).Getal.ToString();
        }
    }
}
