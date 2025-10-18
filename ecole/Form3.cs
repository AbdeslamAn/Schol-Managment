using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ecole
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void etudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void etudiantToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.MdiParent = this;
            f.Show();
            
        }

        private void matierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            matier m = new matier();
            m.MdiParent = this;
            m.Show();
        }

        private void evaluerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            evaluer v = new evaluer();
            v.MdiParent = this;
            v.Show();
        }

        private void fermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
