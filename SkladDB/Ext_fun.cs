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
    public partial class Ext_fun : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlParameter Parametr;
        SqlParameter ResStrParam;

        public Ext_fun()
        {
            InitializeComponent();
        }

        private void Ext_fun_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=ANDROID-B7CAT1U;Initial Catalog=Sklad;Integrated Security=True");
            connection.Open();
        }

        private void Ext_fun_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("sp_change_citytel", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            Parametr = new SqlParameter
            {
                ParameterName = "@old_num",
                Value = old_tel_code.Value
            };
            command.Parameters.Add(Parametr);

            Parametr = new SqlParameter
            {
                ParameterName = "@new_num",
                Value = new_tel_code.Value
            };
            command.Parameters.Add(Parametr);

            ResStrParam = new SqlParameter
            {
                ParameterName = "@res",
                SqlDbType = SqlDbType.NVarChar,
                Size = 45
            };
            ResStrParam.Direction = ParameterDirection.Output;
            command.Parameters.Add(ResStrParam);

            command.ExecuteNonQuery();

            MessageBox.Show((string)command.Parameters["@res"].Value, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
