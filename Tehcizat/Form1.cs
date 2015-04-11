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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String username = usernameTextbox.Text;
            String pass = passwordTextBox.Text;
            pass = hash(pass);

            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["Tehcizat"].ConnectionString;
            int role = -1;
            int user_id = -1;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                string cmdText = "Select id, role from [tehcizat].[dbo].[user] where username = '"
                    + username + "' AND password = '" + pass + "'";
                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            user_id = reader.GetInt32(0);
                            role = reader.GetInt32(1);
                        }
                    }
                    reader.Close();
                }
                conn.Close();
            }

            User.GlobalUserId = user_id;
            User.GlobalUsername = username;

            switch (role)
            {
                case 1: //sorğuları qəbul edən şəxsin pəncərəsi açılacaq
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                    break;
                case 2: //təchizat portalının bütün tranzaksiyaları göstərən pəncərə açılacaq
                    Form8 form8 = new Form8();
                    form8.Show();
                    this.Hide();
                    break;
                case 3: //sorğulara bazarda təklif axtaran təchizat agentinin pəncərəsi açılacaq
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();
                    break;
                case 4: //audit işçisinin pəncərəsi açılacaq
                    Form5 form5 = new Form5();
                    form5.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Daxil etdiyiniz məlumatlar yalnışdır.");
                    break;
            };
        }

        String hash(String password)
        {
            StringBuilder Sb = new StringBuilder();
            using (System.Security.Cryptography.SHA256 hash = System.Security.Cryptography.SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(password));
                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }
            return Sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.Show();
        }
    }
}
