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
        Tellen t;

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
    }
}
