using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tehcizat

{
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();         
            
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex < dataGridView1.Rows.Count-1)
            {
                var MyConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Tehcizat"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(MyConnectionString))
                using (SqlCommand cmd = connection.CreateCommand())
                {

                    connection.Open();
                    cmd.CommandText = "SELECT price_list.company_id, price_list.new_or_old, price_list.id, price_list.request_id, company.name AS Şirkət, price_list.price AS qiymət, currency.name AS valyuta " +
                                      "FROM price_list INNER JOIN company ON price_list.company_id = company.id " +
                                      "INNER JOIN currency ON price_list.currency_id = currency.id " +
                                      "WHERE price_list.request_id = " + dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    if (ds.Tables[0].Rows.Count == 0)
                        {
                        dataGridView2.Visible = false;
                        label3.Visible = false;
                        MessageBox.Show("Bu sorğuya hələ baxılmayib");
                        
                    }
                    else
                    {
                        label3.Visible = true;
                        dataGridView2.Visible = true;
                        dataGridView2.DataSource = ds.Tables[0].DefaultView;
                        dataGridView2.Columns[1].Visible = false;
                        dataGridView2.Columns[2].Visible = false;
                        dataGridView2.Columns[3].Visible = false;
                        dataGridView2.Columns[4].Visible = false;
                    }

                }

            }
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tehcizatDataSet.price_list' table. You can move, or remove it, as needed.
            this.price_listTableAdapter.Fill(this.tehcizatDataSet.price_list);
            // TODO: This line of code loads data into the 'tehcizatDataSet.price_list' table. You can move, or remove it, as needed.
            this.price_listTableAdapter.Fill(this.tehcizatDataSet.price_list);

            var MyConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Tehcizat"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(MyConnectionString))
            using (SqlCommand cmd = connection.CreateCommand())
            {

                connection.Open();
                cmd.CommandText = "SELECT request.id AS sorğunun_nömrəsi, request.name AS sorğu, product.name, request.amount AS vayı, request.location AS Yerli_Xarici, unit.name AS vahid, source.name AS mənbə, type.name AS növ, company.name AS şirkət " +
                                  "FROM request INNER JOIN product ON request.product_id = product.id " +
                                  "INNER JOIN unit ON request.unit_id = unit.id " +
                                  "INNER JOIN source ON request.source_id = source.id " +
                                  "INNER JOIN type ON request.type_id = type.id " +
                                  "INNER JOIN company ON request.company_id = company.id " +
                                  "WHERE request.status = 4 ";

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                dataGridView1.Columns[1].Visible = false;
                dataGridView2.Visible = false;
                label3.Visible = false;

            }       

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex < dataGridView2.Rows.Count - 1)
            {
                DialogResult dialogResult = MessageBox.Show("Bu Şirkətdən alamaq son qərarınızdır?", "Əminsiniz?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string MyConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Tehcizat"].ConnectionString;
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = MyConnectionString;
                    connection.Open();

                    string query = "INSERT INTO history (source_id, type_id, company_suplier_id, company_orderer_id, product_id, price, currency_id, amount, unit_id, orderer_id, date) " +
                                  "SELECT   	    request.source_id, request.type_id, price_list.company_id AS suplier, request.company_id AS orderer, " +
                                                   "request.product_id, price_list.price, price_list.currency_id, " +
                                                   "request.amount, request.unit_id, request.orderer_id, '" + DateTime.Now.ToString() + "'" +
                                  "FROM	            price_list INNER JOIN " +
                                                   "request ON price_list.request_id = request.id " +
                                  "WHERE	        price_list.company_id = " + dataGridView2.Rows[e.RowIndex].Cells[1].FormattedValue.ToString() + ";" +
                                  "UPDATE           request " +
                                  "SET              status = 5 " +
                                  "WHERE            (request.id = " + dataGridView2.Rows[e.RowIndex].Cells[4].FormattedValue.ToString() + ") ";

                    SqlCommand cmd = new SqlCommand(query,connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sifarişin alış qaydası təyin olundu.");


                    if (dataGridView2.Rows[e.RowIndex].Cells[2].FormattedValue.ToString().Trim().Equals("n"))
                    {
                        string item_prices_query =  "INSERT INTO		item_prices (product_id, price, currency_id, company_id, date) " +
                                                    "SELECT			    request.product_id, price_list.price, price_list.currency_id, price_list.company_id, '" + DateTime.Now.ToString() + "'" +
                                                    "FROM               request " + 
                                                    "INNER JOIN         price_list ON request.id = price_list.request_id " +
                                                    "WHERE			    price_list.id = " + dataGridView2.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                        SqlCommand item_prices_cmd = new SqlCommand(item_prices_query, connection);
                        item_prices_cmd.ExecuteNonQuery();
                    
                    }

                    Form5_Load(sender, e);
                                  
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }
        } 
    }
}
