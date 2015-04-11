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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tehcizatDataSet.unit' table. You can move, or remove it, as needed.
            this.unitTableAdapter.Fill(this.tehcizatDataSet.unit);
            // TODO: This line of code loads data into the 'tehcizatDataSet.company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.tehcizatDataSet.company);
            // TODO: This line of code loads data into the 'tehcizatDataSet.type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.tehcizatDataSet.type);
            // TODO: This line of code loads data into the 'tehcizatDataSet.source' table. You can move, or remove it, as needed.
            this.sourceTableAdapter.Fill(this.tehcizatDataSet.source);
           
            
        }

        private void newCompany_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Məlumatların düzgünlüyündən əminsinizmi?",
                "Important Question", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.No)
                return;
            if (textBoxEtrafli.Text.Length > 40)
                textBoxEtrafli.Text = textBoxEtrafli.Text.Substring(0, 40);
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "")
            {
                var connection = System.Configuration.ConfigurationManager.ConnectionStrings["Tehcizat"].ConnectionString;
                SqlConnection sc = new SqlConnection(connection);
                sc.Open();
                string cmdText = "Select id from [tehcizat].[dbo].[product] where name = N'" + textBox1.Text.Trim() + "'";

                int idProduct = 0;
                using (SqlCommand cmd = new SqlCommand(cmdText, sc))
                {
                    SqlDataReader readerProduct = cmd.ExecuteReader();
                    if (readerProduct != null)
                    {
                        while (readerProduct.Read())
                        {
                            idProduct = readerProduct.GetInt32(0);
                        }
                    }
                    readerProduct.Close();
                }

                if (idProduct == 0)
                {
                    SqlCommand cmd1 = new SqlCommand("Insert into [tehcizat].[dbo].[product] (name) values ( N'" + textBox1.Text.Trim() + "')", sc);
                    cmd1.ExecuteNonQuery();
                    using (SqlCommand selectProductId = new SqlCommand("Select id from [tehcizat].[dbo].[product] where name = N'" + textBox1.Text.Trim() + "'", sc))
                    {
                        SqlDataReader readerProductid = selectProductId.ExecuteReader();
                        if (readerProductid != null)
                        {
                            while (readerProductid.Read())
                            {
                                idProduct = readerProductid.GetInt32(0);
                            }
                        }
                        readerProductid.Close();
                    }
                }
                
                int idSource = Convert.ToInt32(comboBox1.SelectedValue);
                int idType = Convert.ToInt32(comboBox2.SelectedValue);
                int idCompany = Convert.ToInt32(comboBox3.SelectedValue);
                int idUnit = Convert.ToInt32(comboBox4.SelectedValue);

                string commOrderer = "Select id from [tehcizat].[dbo].[orderer] where name = N'" + textBox2.Text.Trim() + "' and surname = N'" +
                    textBox3.Text.Trim() + "' and company_id = " + idCompany;

                int idOrderer = 0;
                using (SqlCommand commOrderersql = new SqlCommand(commOrderer, sc))
                {
                    SqlDataReader readerOrder = commOrderersql.ExecuteReader();
                    if (readerOrder != null)
                    {
                        while (readerOrder.Read())
                        {
                            idOrderer = readerOrder.GetInt32(0);
                        }
                    }
                    readerOrder.Close();
                }

                if (idOrderer == 0)
                {
                    SqlCommand AddOrderer = new SqlCommand("Insert into [tehcizat].[dbo].[orderer] (name,surname,company_id) values ( N'" + textBox2.Text.Trim() + "', N'" +
                    textBox3.Text.Trim() + "' ," + idCompany + ")", sc);
                    AddOrderer.ExecuteNonQuery();
                    using (SqlCommand selectProductId = new SqlCommand(commOrderer, sc))
                    {
                        SqlDataReader readerProductid = selectProductId.ExecuteReader();
                        if (readerProductid != null)
                        {
                            while (readerProductid.Read())
                            {
                                idOrderer = readerProductid.GetInt32(0);
                            }
                        }
                        readerProductid.Close();
                    }

                }
                string n = textBoxEtrafli.Text;

                string location = "u";
                if (daxiliRadioButton.Checked)
                    location = "d";
                else if (xariciRadioButton.Checked)
                    location = "x";

                SqlCommand cmd2 = new SqlCommand("Insert into [tehcizat].[dbo].[request] (name,amount,product_id,unit_id,source_id,type_id,company_id,status,orderer_id,user_id, location) values ( N'"
                     + n + "'," + Convert.ToDouble(textBox5.Text) + "," + idProduct + "," + idUnit + "," + idSource + "," + idType + "," + idCompany + ",3," + idOrderer + "," + User.GlobalUserId + ", '" + location + "')", sc);
                cmd2.ExecuteNonQuery();
                sc.Close();
                textBox1.Text = "";

                MessageBox.Show("Müraciət uğurla təchizat agentinə göndərildi.");
            }
            else
            {
                MessageBox.Show("Məlumatları Tamamlayin");
            }
            Form2_Load(sender, e);
        }
    }
}
