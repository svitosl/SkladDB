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

namespace SkladDB
{
    public partial class Dismiss : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter;
        int id;

        public Dismiss(int id_item)
        {
            InitializeComponent();
            id = id_item;
        }

        private void Dismiss_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=ANDROID-B7CAT1U;Initial Catalog=Sklad;Integrated Security=True");
            connection.Open();
        }

        private void Dismiss_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dismiss_Click(object sender, EventArgs e)
        {
            string sql;
            adapter = new SqlDataAdapter();
            sql = "UPDATE [Workers] SET date_end = '" + date_end.Text + "' where id_wrk = " + id;
            adapter.InsertCommand = new SqlCommand(sql, connection);
            adapter.InsertCommand.ExecuteNonQuery();
            this.Close();
        }
    }
}
