using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skola___Cas_a_Datum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            date = dateTimePicker1.Value;

            label1.Text = "Pocet dní ode dne x: " + pocetDni(date, (int)numericUpDown1.Value)+"\nPočet dní do důchodu " + pocetDni(date, 65);
        }

        int pocetDni(DateTime d, int x)
        {
            d = d.AddYears(x);
            TimeSpan s = DateTime.Now - d;
            return s.Days;
        }
    }
}
