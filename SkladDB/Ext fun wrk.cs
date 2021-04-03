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
    public partial class Ext_fun_wrk : Form
    {
        SqlConnection connection;
        DataSet ds;
        DataTable newtable;
        SqlDataAdapter adapter;

        public Ext_fun_wrk()
        {
            InitializeComponent();
        }

        private void Ext_fun_wrk_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=ANDROID-B7CAT1U;Initial Catalog=Sklad;Integrated Security=True");
            connection.Open();

            ds = new DataSet();

            newtable = ds.Tables.Add();
            adapter = new SqlDataAdapter("SELECT DISTINCT profession from Workers", connection);
            adapter.Fill(ds.Tables[0]);
            combo_prof.DataSource = ds.Tables[0].AsDataView();
            combo_prof.DisplayMember = "profession";

            newtable = ds.Tables.Add();
            grid_salary.DataSource = ds.Tables[1];
        }

        private void Ext_fun_wrk_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            ds.Tables[1].Clear();
            adapter = new SqlDataAdapter("SELECT id_wrk AS '№:', concat(surname, ' ', name, ' ', midname) AS 'ФИО:', " +
                                         "profession AS 'Должность:', salary AS 'Зар. плата:', date_start AS 'Дата принятия:', " +
                                         "date_end AS 'Дата увольнения:' " +
                                         "FROM Workers " +
                                         "WHERE salary > ALL(SELECT salary from Workers where profession = '" + combo_prof.Text + "')", connection);
            adapter.Fill(ds.Tables[1]);
        }
    }
}
