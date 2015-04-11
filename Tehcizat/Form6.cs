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

namespace Tehcizat
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Məlumatların düzgünlüyündən əminsinizmi?",
        "Important Question",
        MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes) {
                var connection = System.Configuration.ConfigurationManager.ConnectionStrings["Tehcizat"].ConnectionString;
                SqlConnection sc = new SqlConnection(connection);
                sc.Open();
                SqlCommand cmd = new SqlCommand("Insert into [tehcizat].[dbo].[company] (name,address) VALUES ( N'" + textBox1.Text + "',N'" + textBox2.Text + "')",sc);
                cmd.ExecuteNonQuery();
                sc.Close();
                textBox1.Text = "";
                textBox2.Text = "";
              
                this.Close();
               
            }
            
        }
    }
}
