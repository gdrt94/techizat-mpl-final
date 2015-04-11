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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tehcizatDataSet.currency' table. You can move, or remove it, as needed.
            this.currencyTableAdapter.Fill(this.tehcizatDataSet.currency);
            // TODO: This line of code loads data into the 'tehcizatDataSet.company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.tehcizatDataSet.company);
            // TODO: This line of code loads data into the 'tehcizatDataSet.unit' table. You can move, or remove it, as needed.
            this.unitTableAdapter.Fill(this.tehcizatDataSet.unit);
            usernameLabel.Text = User.GlobalUsername;

            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["Tehcizat"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                string cmdText = "SELECT r.id, p.name, r.name, r.amount, u.name, s.name, t.name, r.location, c.name, o.name, o.surname, us.username, p.id " +
                    " FROM [tehcizat].[dbo].[request] r " +
                    " JOIN [tehcizat].[dbo].[product] p " +
                    " ON r.product_id = p.id " +
                    " JOIN [tehcizat].[dbo].[unit] u " +
                    " ON r.unit_id = u.id " +
                    " JOIN [tehcizat].[dbo].[source] s " +
                    " ON r.source_id = s.id " +
                    " JOIN [tehcizat].[dbo].[type] t " +
                    " ON r.type_id = t.id " +
                    " JOIN [tehcizat].[dbo].[company] c " +
                    " ON r.company_id = c.id " +
                    " JOIN [tehcizat].[dbo].[orderer] o " +
                    " ON r.orderer_id = o.id " +
                    " JOIN [tehcizat].[dbo].[user] us " +
                    " ON r.user_id = us.id " +
                    " WHERE status = 3";

                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                }

                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].HeaderText = "Məhsul";
                dataGridView1.Columns[2].HeaderText = "Ətraflı";
                dataGridView1.Columns[3].HeaderText = "Miqdar";
                dataGridView1.Columns[4].HeaderText = "Ölçü vahidi";
                dataGridView1.Columns[5].HeaderText = "Mənbə";
                dataGridView1.Columns[6].HeaderText = "Növü";
                dataGridView1.Columns[7].HeaderText = "x/d";
                dataGridView1.Columns[8].HeaderText = "Şirkət";
                dataGridView1.Columns[9].HeaderText = "Sifarişçinin adı";
                dataGridView1.Columns[10].HeaderText = "Sifarişçinin soyadı";
                dataGridView1.Columns[11].HeaderText = "Təchizat Agenti";
                dataGridView1.Columns[12].Visible = false;
                conn.Close();
            }
        }

        string insert_command = "INSERT INTO [tehcizat].[dbo].[price_list] (request_id, new_or_old, company_id, price, currency_id) VALUES ";
        int request_id = -1;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                request_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int mehsul_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[12].Value);

                var connection = System.Configuration.ConfigurationManager.ConnectionStrings["Tehcizat"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string cmdText = "SELECT ip.id, ip.price, cur.name, c.name, date, c.id, cur.id " +
                        " FROM [tehcizat].[dbo].[item_prices] ip " +
                        " JOIN [tehcizat].[dbo].[product] p " +
                        " ON ip.product_id = p.id " +
                        " JOIN [tehcizat].[dbo].[currency] cur " +
                        " ON ip.currency_id = cur.id " +
                        " JOIN [tehcizat].[dbo].[company] c " +
                        " ON ip.company_id = c.id " +
                        " WHERE p.id = " + mehsul_id;

                    using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                    {
                        SqlDataAdapter adap = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adap.Fill(ds);
                        dataGridView2.DataSource = ds.Tables[0].DefaultView;
                    }

                    conn.Close();

                    dataGridView1.Columns[0].HeaderText = "Id";
                    dataGridView1.Columns[1].HeaderText = "Qiymət";
                    dataGridView1.Columns[2].HeaderText = "Valyuta";
                    dataGridView1.Columns[3].HeaderText = "Şirkət";
                    dataGridView1.Columns[4].HeaderText = "Tarix";
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        insert_command += " ( " + request_id + ", 'o', " + row.Cells[5].Value.ToString() + ", " + row.Cells[1].Value.ToString() + ", " + row.Cells[6].Value.ToString() + "), ";
                    }

                    dataGridView1.Columns[0].HeaderText = "Id";
                    dataGridView1.Columns[1].HeaderText = "Məhsul";
                    dataGridView1.Columns[2].HeaderText = "Ətraflı";
                    dataGridView1.Columns[3].HeaderText = "Miqdar";
                    dataGridView1.Columns[4].HeaderText = "Ölçü vahidi";
                    dataGridView1.Columns[5].HeaderText = "Mənbə";
                    dataGridView1.Columns[6].HeaderText = "Növü";
                    dataGridView1.Columns[7].HeaderText = "x/d";
                    dataGridView1.Columns[8].HeaderText = "Şirkət";
                    dataGridView1.Columns[9].HeaderText = "Sifarişçinin adı";
                    dataGridView1.Columns[10].HeaderText = "Sifarişçinin soyadı";
                    dataGridView1.Columns[11].HeaderText = "Təchizat Agenti";
                    dataGridView1.Columns[12].Visible = false;
                }
            }
            catch {}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Məlumatların düzgünlüyündən əminsinizmi?",
                "Important Question", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.No)
                return;

            if (request_id != -1)
            {
                if (numericUpDown1.Value > 0)
                    insert_command += " ( " + request_id + ", 'n', " + Convert.ToInt32(companycombo1.SelectedValue) + ", " + numericUpDown1.Value + ", " + Convert.ToInt32(currencycombo1.SelectedValue) + "), ";
                if (numericUpDown2.Value > 0)
                    insert_command += " ( " + request_id + ", 'n', " + Convert.ToInt32(companycombo2.SelectedValue) + ", " + numericUpDown2.Value + ", " + Convert.ToInt32(currencycombo2.SelectedValue) + "), ";
                if (numericUpDown3.Value > 0)
                    insert_command += " ( " + request_id + ", 'n', " + Convert.ToInt32(companycombo3.SelectedValue) + ", " + numericUpDown3.Value + ", " + Convert.ToInt32(currencycombo3.SelectedValue) + "), ";
                if (numericUpDown4.Value > 0)
                    insert_command += " ( " + request_id + ", 'n', " + Convert.ToInt32(companycombo4.SelectedValue) + ", " + numericUpDown4.Value + ", " + Convert.ToInt32(currencycombo4.SelectedValue) + "), ";
                if (numericUpDown5.Value > 0)
                    insert_command += " ( " + request_id + ", 'n', " + Convert.ToInt32(companycombo5.SelectedValue) + ", " + numericUpDown5.Value + ", " + Convert.ToInt32(currencycombo5.SelectedValue) + "),";
            }
            
            if (insert_command.ToLower().Contains("values"))
            {
                var connection = System.Configuration.ConfigurationManager.ConnectionStrings["Tehcizat"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    insert_command = insert_command.TrimEnd();
                    //insert_command = insert_command.TrimEnd(',');
                    insert_command = insert_command.Remove(insert_command.Length - 1, 1) + ";";
                    SqlCommand command = new SqlCommand(insert_command, conn);
                    command.ExecuteNonQuery();

                    string update_command = " UPDATE [tehcizat].[dbo].[request] SET status = 4 WHERE id = " + request_id;
                    command = new SqlCommand(update_command, conn);
                    command.ExecuteNonQuery();
                    
                    conn.Close();
                    //increment status 
                }
            }
            MessageBox.Show("Təklifləriniz uğurla audit departamentinə göndərildi.");
            Form4_Load(sender, e);
        }
    }
}
