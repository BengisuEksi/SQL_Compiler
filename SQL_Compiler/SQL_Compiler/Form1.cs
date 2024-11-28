using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL_Compiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn_def = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=DbPersonel ;Integrated Security=True");
        
        private void sqlqueries_bttn_Click(object sender, EventArgs e)
        {
            SQLQueries fr = new SQLQueries();
            this.Hide();
            fr.ShowDialog();
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void clear()
        {
            query_txtbox.Text = "";
            dataGridView1.DataSource = null;
        }
        void list(string query)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog="+ database_comboBox.Text +";Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void execute_bttn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog="+ database_comboBox.Text +";Integrated Security=True");
            string query = query_txtbox.Text;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                list(query);
            }
            catch (Exception)
            {
                MessageBox.Show("Check your query.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void execute_bttn_MouseEnter(object sender, EventArgs e)
        {
            execute_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void execute_bttn_MouseLeave(object sender, EventArgs e)
        {
            execute_bttn.BackColor = Color.Transparent;
        }

        private void sqlqueries_bttn_MouseEnter(object sender, EventArgs e)
        {
            sqlqueries_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void sqlqueries_bttn_MouseLeave(object sender, EventArgs e)
        {
            sqlqueries_bttn.BackColor = Color.Transparent;
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void clear_bttn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear_bttn_MouseEnter(object sender, EventArgs e)
        {
            clear_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void clear_bttn_MouseLeave(object sender, EventArgs e)
        {
            clear_bttn.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn_def.Open();
            SqlCommand cmd = new SqlCommand("Select * from Sys.Databases", conn_def);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                database_comboBox.Items.Add(dr[0]);
            }
            conn_def.Close();
        }

        private void database_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=" + database_comboBox.Text + ";Integrated Security=True");
            conn.Open();
            string selected_database = database_comboBox.Text;
            string query = $"USE {selected_database}";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            cmd1.ExecuteNonQuery();

            string table_query = "SELECT name FROM Sys.Tables";
            SqlCommand cmd2 = new SqlCommand(table_query, conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            table_comboBox.Items.Clear();
            while (dr2.Read())
            {
                table_comboBox.Items.Add(dr2[0].ToString());
            }
            conn.Close();
        }
    }
}
