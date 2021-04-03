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
    public partial class journal : Form
    {
        SqlConnection connection;

        public journal()
        {
            InitializeComponent();
        }

        private void Journal_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=ANDROID-B7CAT1U;Initial Catalog=Sklad;Integrated Security=True");
            connection.Open();

            string sqlExpression = "SELECT * FROM Control_Workers WHERE action = 'Изменение'";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<List<int>> list = new List<List<int>>();
            List<string> col_name = new List<string>();
            int count = 0;
            int row = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                        count = 0;

                        if (!reader.IsDBNull(4) || !reader.IsDBNull(11)) // name
                        {
                            list.Add(new List<int>());
                            list[count].Add(4);
                            list[count].Add(11);
                            col_name.Add("Имя");
                            count++;
                        }

                        if (!reader.IsDBNull(5) || !reader.IsDBNull(12)) // surname
                        {
                            list.Add(new List<int>());
                            list[count].Add(5);
                            list[count].Add(12);
                            col_name.Add("Фамилия");
                            count++;
                        }

                        if (!reader.IsDBNull(6) || !reader.IsDBNull(13)) // midname
                        {
                            list.Add(new List<int>());
                            list[count].Add(6);
                            list[count].Add(13);
                            col_name.Add("Отчество");
                            count++;
                        }

                        if (!reader.IsDBNull(7) || !reader.IsDBNull(14)) // profession
                        {
                            list.Add(new List<int>());
                            list[count].Add(7);
                            list[count].Add(14);
                            col_name.Add("Должность");
                            count++;
                        }

                        if (!reader.IsDBNull(8) || !reader.IsDBNull(15)) // salary
                        {
                            list.Add(new List<int>());
                            list[count].Add(8);
                            list[count].Add(15);
                            col_name.Add("Зар. плата");
                            count++;
                        }

                        if (!reader.IsDBNull(9) || !reader.IsDBNull(16)) // date_start
                        {
                            list.Add(new List<int>());
                            list[count].Add(9);
                            list[count].Add(16);
                            col_name.Add("Дата принятия");
                            count++;
                        }

                        if(!reader.IsDBNull(10)) // date_end
                        {
                            list.Add(new List<int>());
                            list[count].Add(10);
                            col_name.Add("Дата увольнения");
                            count++;
                        }

                        for(int i=0; i < list.Count; i++)
                        {
                            grid_change_cntrl.Rows.Add(reader.GetInt32(18).ToString(), reader.GetString(1), reader.GetDateTime(2).ToString(), reader.GetString(3));

                            if ((list[i][0] == 8) && (list[i][1] == 15))
                            {
                                grid_change_cntrl.Rows[row].Cells[4].Value = col_name[i];
                                grid_change_cntrl.Rows[row].Cells[5].Value = reader.GetInt32(list[i][0]).ToString();
                                grid_change_cntrl.Rows[row].Cells[6].Value = reader.GetInt32(list[i][1]).ToString();
                            }
                            else if ((list[i][0] == 9) && (list[i][1] == 16))
                            {
                                grid_change_cntrl.Rows[row].Cells[4].Value = col_name[i];
                                grid_change_cntrl.Rows[row].Cells[5].Value = reader.GetDateTime(list[i][0]).ToString();
                                grid_change_cntrl.Rows[row].Cells[6].Value = reader.GetDateTime(list[i][1]).ToString();
                            }
                            else if (list[i][0] == 10)
                            {
                                grid_change_cntrl.Rows[row].Cells[4].Value = col_name[i];
                                grid_change_cntrl.Rows[row].Cells[5].Value = reader.GetDateTime(list[i][0]).ToString();
                            }
                            else
                            {
                                grid_change_cntrl.Rows[row].Cells[4].Value = col_name[i];
                                grid_change_cntrl.Rows[row].Cells[5].Value = reader.GetString(list[i][0]);
                                grid_change_cntrl.Rows[row].Cells[6].Value = reader.GetString(list[i][1]);
                            }

                            grid_change_cntrl.Rows[row].Cells[7].Value = reader.GetString(19); 
                            row++;
                        }
                        list.Clear();
                        col_name.Clear();
                }
            }
            reader.Close();

            DataSet ds = new DataSet();
            DataTable newtable = ds.Tables.Add();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id_wrk, change_name, change_datetime, action, changed_name, changed_surname, changed_midname, changed_profession, changed_salary, changed_date_start, wrk_days FROM Control_Workers WHERE action = 'Добавление' OR action = 'Удаление'", connection);
            adapter.Fill(ds.Tables[0]);
            control_journal2.DataSource = ds.Tables[0];
            control_journal2.Columns[0].HeaderText = "№:";
            control_journal2.Columns[0].Width = 40;
            control_journal2.Columns[1].HeaderText = "Логин";
            control_journal2.Columns[1].Width = 50;
            control_journal2.Columns[2].HeaderText = "Дата/время изм.";
            control_journal2.Columns[2].Width = 120;
            control_journal2.Columns[3].HeaderText = "Действие";
            control_journal2.Columns[3].Width = 80;
            control_journal2.Columns[4].HeaderText = "Имя";
            control_journal2.Columns[5].HeaderText = "Фамилия";
            control_journal2.Columns[6].HeaderText = "Отчество";
            control_journal2.Columns[7].HeaderText = "Должность";
            control_journal2.Columns[8].HeaderText = "Зар. плата";
            control_journal2.Columns[9].HeaderText = "Дата принятия:";
            control_journal2.Columns[9].Width = 120;
            control_journal2.Columns[10].HeaderText = "Доп. информация:";
            control_journal2.Columns[10].Width = 400;
        }

           private void Journal_FormClosing(object sender, FormClosingEventArgs e)
           {
               if (connection != null && connection.State != ConnectionState.Closed)
                   connection.Close();
           }
        }
}   
