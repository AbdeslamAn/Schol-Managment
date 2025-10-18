using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ecole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = "Data Source=.;Initial Catalog=ecole;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sc;
            cmd.CommandText = string.Format("insert into etudiant values({0},'{1}','{2}')", textBox1.Text, textBox2.Text, textBox3.Text);
            sc.Open();
            cmd.ExecuteNonQuery();
            sc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             SqlConnection sc = new SqlConnection();
             sc.ConnectionString = ("Data Source=.;Initial Catalog=ecole;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sc;
            cmd.CommandText = string.Format(" update etudiant set nom='{0}',prenom='{1}' where netudiant={2}", textBox2.Text, textBox3.Text, textBox1.Text);
            sc.Open();
            cmd.ExecuteNonQuery();
            sc.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = ("Data Source=.;Initial Catalog=ecole;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sc;
            cmd.CommandText = string.Format(" delete from etudiant where netudiant={0}", textBox1.Text);
            sc.Open();
            cmd.ExecuteNonQuery();
            sc.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Text = "";
            textBox3.Clear();
            
        }
    }
}
