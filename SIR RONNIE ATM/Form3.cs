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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2Button1.Text == "Show")
            {
                guna2Button1.Text = "Hide";
                pinbox.PasswordChar = '\0';
            }
            else
            {
                pinbox.PasswordChar = '●';
                guna2Button1.Text = "Show";
            }
        }

        private void pinbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pinbox_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void pinbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (pinbox.Text == "010101")
                {
                    Form4 form4 = new Form4();
                    form4.ShowDialog();

                }
                else
                {
                    MessageBox.Show("INVALID PIN!");
                    pinbox.Clear();
                }
            }
        }

        private void pinbox_Click(object sender, EventArgs e)
        {
            pinbox.Clear();
        }
    }
}
