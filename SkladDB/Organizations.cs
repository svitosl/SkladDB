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
    public partial class Organizations : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlParameter Parametr;
        bool is_changed;
        int id;

        public Organizations(bool action)
        {
            InitializeComponent();
            is_changed = action;
        }

        public Organizations(bool action, int id_item)
        {
            InitializeComponent();
            is_changed = action;
            id = id_item;
        }

        private void Organizations_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=ANDROID-B7CAT1U;Initial Catalog=Sklad;Integrated Security=True");
            connection.Open();

            if (is_changed)
            {
                command = new SqlCommand("sp_GetOrg", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                Parametr = new SqlParameter
                {
                    ParameterName = "@id_org",
                    Value = id
                };
                command.Parameters.Add(Parametr);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    txt_org_name.Text = reader.GetString(0);
                    txt_org_type.Text = reader.GetString(1);
                    combo_org_form.SelectedItem = reader.GetString(2);
                    txt_org_adress.Text = reader.GetString(3);
                    country_tel.Text = reader.GetInt32(4).ToString();
                    city_tel.Text = reader.GetInt32(5).ToString();
                    number_tel.Text = reader.GetInt32(6).ToString();
                }

                reader.Close();
            }
        }

        private void Organizations_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void bет_wrk_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_wrk_add_Click(object sender, EventArgs e)
        {
            if (is_changed)
                command = new SqlCommand("sp_UpdateOrg", connection);
            else
                command = new SqlCommand("sp_InsertOrg", connection);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            if (is_changed)
            {
                Parametr = new SqlParameter
                {
                    ParameterName = "@id_org",
                    Value = id
                };
                command.Parameters.Add(Parametr);
            }

            Parametr = new SqlParameter
            {
                ParameterName = "@Org_name",
                Value = txt_org_name.Text
            };
            command.Parameters.Add(Parametr);

            Parametr = new SqlParameter
            {
                ParameterName = "@Type",
                Value = txt_org_type.Text
            };
            command.Parameters.Add(Parametr);

            Parametr = new SqlParameter
            {
                ParameterName = "@Form",
                Value = combo_org_form.Text
            };
            command.Parameters.Add(Parametr);

            Parametr = new SqlParameter
            {
                ParameterName = "@Adress",
                Value = txt_org_adress.Text
            };
            command.Parameters.Add(Parametr);

            Parametr = new SqlParameter
            {
                ParameterName = "@tel_country_code",
                Value = country_tel.Text
            };
            command.Parameters.Add(Parametr);

            Parametr = new SqlParameter
            {
                ParameterName = "@tel_city_code",
                Value = city_tel.Text
            };
            command.Parameters.Add(Parametr);

            Parametr = new SqlParameter
            {
                ParameterName = "@tel_number",
                Value = number_tel.Text
            };
            command.Parameters.Add(Parametr);
            command.ExecuteNonQuery();
            this.Close();
        }
    }
}
