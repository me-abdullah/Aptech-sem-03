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
namespace Class_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connString = "Data Source=DESKTOP-M561BCP\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

            string fname = textBox1.Text;
            string pass = textBox2.Text;

           
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();

                   
                    string query = "INSERT INTO login_table (email, pass) VALUES (@Email, @Password)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", fname);
                        cmd.Parameters.AddWithValue("@Password", pass);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data Saved");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-M561BCP\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

            string emailToDelete = textBox3.Text; 

            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();

                    string query = "DELETE FROM login_table WHERE email = @Email";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", emailToDelete);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Deleted");
                        }
                        else
                        {
                            MessageBox.Show("No record found with that email.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
    }
}
