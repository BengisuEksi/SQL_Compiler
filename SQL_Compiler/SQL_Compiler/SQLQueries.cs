using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Compiler
{
    public partial class SQLQueries : Form
    {
        public SQLQueries()
        {
            InitializeComponent();
        }
        private void back_bttn_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Close();
            fr.Show();
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void address_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.w3schools.com/sql/default.asp");
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.DarkOrange;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void back_bttn_MouseEnter(object sender, EventArgs e)
        {
            back_bttn.BackColor = Color.DarkOrange;
        }

        private void back_bttn_MouseLeave(object sender, EventArgs e)
        {
            back_bttn.BackColor = Color.Transparent;
        }
    }
}
