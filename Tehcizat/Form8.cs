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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["Tehcizat"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                string cmdText = "SELECT h.id, s.name, t.name, comp1.name, comp2.name, p.name, h.price," +
                    " curr.name, h.amount, u.name, o.name, o.surname, h.date " +
                    " FROM [tehcizat].[dbo].[history] h " +
                    " JOIN [tehcizat].[dbo].[source] s " +
                    " ON h.source_id = s.id " +
                    " JOIN [tehcizat].[dbo].[type] t " +
                    " ON h.type_id = t.id " +
                    " JOIN [tehcizat].[dbo].[company] comp1 " +
                    " ON h.company_suplier_id = comp1.id " +
                    " JOIN [tehcizat].[dbo].[company] comp2 " +
                    " ON h.company_orderer_id = comp2.id " +
                    " JOIN [tehcizat].[dbo].[product] p " +
                    " ON h.product_id = p.id " +
                    " JOIN [tehcizat].[dbo].[currency] curr " +
                    " ON h.currency_id = curr.id " +
                    " JOIN [tehcizat].[dbo].[unit] u " +
                    " ON h.unit_id = u.id " +
                    " JOIN [tehcizat].[dbo].[orderer] o " +
                    " ON h.orderer_id = o.id ";

                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                }

                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].HeaderText = "Mənbə";
                dataGridView1.Columns[2].HeaderText = "Növü";
                dataGridView1.Columns[3].HeaderText = "Sifarişçi şirkət";
                dataGridView1.Columns[4].HeaderText = "Təchizatçı şirkət";
                dataGridView1.Columns[5].HeaderText = "Məhsul";
                dataGridView1.Columns[6].HeaderText = "Qiymət";
                dataGridView1.Columns[7].HeaderText = "Valyuta";
                dataGridView1.Columns[8].HeaderText = "Miqdar";
                dataGridView1.Columns[9].HeaderText = "Ölçü vahidi";
                dataGridView1.Columns[10].HeaderText = "Sifarişçinin adı";
                dataGridView1.Columns[11].HeaderText = "Sifarişçinin soyadı";
                dataGridView1.Columns[12].HeaderText = "Tarix";
                conn.Close();
            }
        }
    }
}
