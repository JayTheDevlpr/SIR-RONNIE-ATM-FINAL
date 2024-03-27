using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIR_RONNIE_ATM
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 2;
            }
            else
            {
                timer1.Stop();
                Form5 form5 = new Form5();
                form5.ShowDialog();
               
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
