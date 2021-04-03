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
    public partial class Workers : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlParameter param;
        bool is_changed;
        int id;

        public Workers(bool changed)
        {
            is_changed = changed;
            InitializeComponent();
        }

        public Workers(bool changed, int id_value)
        {
            is_changed = changed;
            id = id_value;
            InitializeComponent();
        }

        private void Workers_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=ANDROID-B7CAT1U;Initial Catalog=Sklad;Integrated Security=True");
            connection.Open();

            if (is_changed)
            {
                command = new SqlCommand("SELECT name, surname, midname, profession, salary, date_start FROM [Workers] where id_wrk = " + id, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    txt_name.Text = reader.GetString(0);
                    txt_surname.Text = reader.GetString(1);
                    txt_midname.Text = reader.GetString(2);
                    combo_prof.SelectedItem = reader.GetString(3);
                    txt_salary.Text = reader.GetInt32(4).ToString();
                    date_start.Text = reader.GetDateTime(5).ToString();
                }

                reader.Close();
            }
        }

        private void Workers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (!is_changed)
                command = new SqlCommand("INSERT INTO [Workers] (name, surname, midname, profession, salary, date_start) VALUES (@Name, @Surname, @Midname, @Profession, @Salary, @Date_start)", connection);
            else
                command = new SqlCommand("UPDATE [Workers] SET name = @Name, surname = @Surname, midname = @Midname, profession = @Profession, salary = @Salary, date_start = @Date_start where id_wrk = " + id, connection);

            param = new SqlParameter("@Name", txt_name.Text);
            command.Parameters.Add(param);

            param = new SqlParameter("@Surname", txt_surname.Text);
            command.Parameters.Add(param);

            param = new SqlParameter("@Midname", txt_midname.Text);
            command.Parameters.Add(param);

            param = new SqlParameter("@Profession", combo_prof.Text);
            command.Parameters.Add(param);

            param = new SqlParameter("@Salary", txt_salary.Text);
            command.Parameters.Add(param);

            param = new SqlParameter("@Date_start", date_start.Text);
            command.Parameters.Add(param);

            command.ExecuteNonQuery();
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
