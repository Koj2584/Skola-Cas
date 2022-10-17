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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DateTime d1 = new DateTime();
        DateTime d2 = new DateTime();

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            d1 = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            d2 = DateTime.Now;
            TimeSpan t = d2 - d1;
            label1.Text = "Uplynulo: "+t.Minutes+" minut a " + t.Seconds%60 + " sekund";
        }
    }
}
