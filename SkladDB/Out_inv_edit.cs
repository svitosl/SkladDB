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
    public partial class Out_inv_edit: Form
    {
        SqlConnection connection;
        DataSet ds;
        DataTable newtable;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        SqlCommand command;
        SqlParameter param;
        List<int> del_list = new List<int>();
        int id;

        public Out_inv_edit()
        {
            InitializeComponent();
        }

        public Out_inv_edit(int id_inv)
        {
            InitializeComponent();
            id = id_inv;
        }


        private decimal calc_sum()
        {
            decimal sum = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                sum += (decimal)ds.Tables[0].Rows[i][4];

            return sum;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            int i, id_item;

            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (grid_items_in_inv.Rows[i].Cells[7].Value.ToString() == "Изм. (id)") // Изм.(id)
                {
                    command = new SqlCommand("UPDATE Items_in_inv SET id_product = @id_product, quantity = @quantity, price_one =  @price_one, mark_number = @mark_number WHERE id_write = " + grid_items_in_inv.Rows[i].Cells[0].Value.ToString(), connection);
                    param = new SqlParameter("@id_product", (int)grid_items_in_inv.Rows[i].Cells[6].Value);
                    command.Parameters.Add(param);

                    param = new SqlParameter("@quantity", (int)grid_items_in_inv.Rows[i].Cells[2].Value * -1);
                    command.Parameters.Add(param);

                    param = new SqlParameter("@price_one", (decimal)grid_items_in_inv.Rows[i].Cells[3].Value);
                    command.Parameters.Add(param);

                    param = new SqlParameter("@mark_number", (int)grid_items_in_inv.Rows[i].Cells[5].Value);
                    command.Parameters.Add(param);

                    command.ExecuteNonQuery();
                }

                if (grid_items_in_inv.Rows[i].Cells[7].Value == DBNull.Value) // Новое значение
                {
                    id_item = (int)ds.Tables[0].Rows[i][6];

                    command = new SqlCommand("INSERT INTO Items_in_inv (id_product, id_in_invoice, quantity, price_one, mark_number) VALUES (@id_product, @id_in_invoice, @quantity, @price_one, @mark_number)", connection);

                    param = new SqlParameter("@id_product", id_item);
                    command.Parameters.Add(param);

                    param = new SqlParameter("@id_in_invoice", id);
                    command.Parameters.Add(param);

                    param = new SqlParameter("@quantity", (int)ds.Tables[0].Rows[i][2] * -1);
                    command.Parameters.Add(param);

                    param = new SqlParameter("@price_one", ds.Tables[0].Rows[i][3]);
                    command.Parameters.Add(param);

                    param = new SqlParameter("@mark_number", (int)grid_items_in_inv.Rows[i].Cells[5].Value);
                    command.Parameters.Add(param);

                    command.ExecuteNonQuery();
                }
            }

            if (del_list.Count > 0)
            {
                for (i = 0; i < del_list.Count; i++)
                {
                    command = new SqlCommand("DELETE FROM Items_in_inv WHERE id_write = " + del_list[i], connection);
                    command.ExecuteNonQuery();
                }

                del_list.Clear();
            }

            command = new SqlCommand("UPDATE In_invoices SET id_wrk = @id_wrk, id_org = @id_org, num_out_invoice = @num_out_invoice, date_in = @date_in, notes = @notes, fio_exp = @fio_exp, prof_exp = @prof_exp WHERE id_in_invoice = " + id, connection);

            param = new SqlParameter("@id_wrk", (int)combo_worker.SelectedValue);
            command.Parameters.Add(param);

            param = new SqlParameter("@id_org", (int)combo_org.SelectedValue);
            command.Parameters.Add(param);

            param = new SqlParameter("@num_out_invoice", txt_num_inv.Text);
            command.Parameters.Add(param);

            param = new SqlParameter("@date_in", date_out.Text);
            command.Parameters.Add(param);

            param = new SqlParameter("@notes", notes.Text);
            command.Parameters.Add(param);

            param = new SqlParameter("@fio_exp", fio_exp.Text);
            command.Parameters.Add(param);

            param = new SqlParameter("@prof_exp", prof_exp.Text);
            command.Parameters.Add(param);

            command.ExecuteNonQuery();

            this.Close();
        }

        private void In_inv_act_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=ANDROID-B7CAT1U;Initial Catalog=Sklad;Integrated Security=True");
            connection.Open();

            DataTransfer.id = -1;
            ds = new DataSet();

            newtable = ds.Tables.Add();
            adapter = new SqlDataAdapter("SELECT Items_in_inv.id_write AS '№', Items.name AS 'Имя', " +
                                         "Items_in_inv.quantity * -1 AS 'Колличество', Items_in_inv.price_one AS 'Цена (ед.)', " +
                                         "Items_in_inv.quantity * -1 * Items_in_inv.price_one AS 'Общая стоимость', " +
                                         "Items_in_inv.mark_number AS 'Номер маркировки', " +
                                         "Items.id_product AS 'Номер товара (нов.)', 'Выгружено' AS 'Действие' " +
                                         "FROM Items_in_inv " +
                                         "INNER JOIN Items ON Items_in_inv.id_product = Items.id_product " +
                                         "INNER JOIN In_invoices ON Items_in_inv.id_in_invoice = In_invoices.id_in_invoice " +
                                         "WHERE Items_in_inv.id_in_invoice = " + id, connection);

            adapter.Fill(ds.Tables[0]);

            newtable = ds.Tables.Add();
            ds.Tables[0].Columns.Add("Номер товара (стар.)", typeof(int));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i][8] = ds.Tables[0].Rows[i][6];
                ds.Tables[0].Rows[i][6] = DBNull.Value;
            }
            grid_items_in_inv.DataSource = ds.Tables[0];
            foreach (DataGridViewColumn column in grid_items_in_inv.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            grid_items_in_inv.Columns[0].Visible = false;
            grid_items_in_inv.Columns[6].Visible = false;
            grid_items_in_inv.Columns[7].Visible = false;
            grid_items_in_inv.Columns[8].Visible = false;
            num_calc_sum.Value = calc_sum();

            newtable = ds.Tables.Add();
            adapter = new SqlDataAdapter("SELECT id_wrk, concat(surname, ' ', name, ' ', midname) AS FIO FROM Workers WHERE date_end is null", connection);
            adapter.Fill(ds.Tables[1]);
            combo_worker.DataSource = ds.Tables[1].AsDataView();
            combo_worker.DisplayMember = "FIO";
            combo_worker.ValueMember = "id_wrk";

            newtable = ds.Tables.Add();
            adapter = new SqlDataAdapter("SELECT id_org, org_name FROM Organizations", connection);
            adapter.Fill(ds.Tables[2]);
            combo_org.DataSource = ds.Tables[2].AsDataView();
            combo_org.DisplayMember = "org_name";
            combo_org.ValueMember = "id_org";

            command = new SqlCommand("SELECT concat(Workers.surname, ' ', Workers.name, ' ', Workers.midname) AS FIO FROM In_invoices " +
                                     "INNER JOIN Workers ON In_invoices.id_wrk = Workers.id_wrk " +
                                     "WHERE id_in_invoice = " + id, connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                combo_worker.Text = reader.GetString(0);
            }
            reader.Close();

            command = new SqlCommand("SELECT Organizations.org_name FROM In_invoices " +
                                     "INNER JOIN Organizations ON In_invoices.id_org = Organizations.id_org " +
                                     "WHERE id_in_invoice = " + id, connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                combo_org.Text = reader.GetString(0);
            }
            reader.Close();

            command = new SqlCommand("SELECT num_out_invoice, fio_exp, prof_exp, notes, date_in FROM In_invoices WHERE id_in_invoice = " + id, connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txt_num_inv.Text = reader.GetString(0);
                fio_exp.Text = reader.GetString(1);
                prof_exp.Text = reader.GetString(2);
                notes.Text = reader.GetString(3);
                date_out.Text = reader.GetDateTime(4).ToString();
            }
            reader.Close();
        }

        private void In_inv_act_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataTransfer.str_datetime = date_out.Value.ToString("yyyyMMdd HH:mm:ss");

            Out_inv_act_items itms = new Out_inv_act_items();
            itms.ShowDialog();

            if (DataTransfer.action)
            { 
                ds.Tables[0].Rows.Add(DBNull.Value, DataTransfer.Item_value, DataTransfer.quantity, DataTransfer.price, DataTransfer.price * DataTransfer.quantity, DataTransfer.str_mark_num, DataTransfer.id);

                num_calc_sum.Value = calc_sum();
            }

            DataTransfer.action = false;
            DataTransfer.id = -1;
            DataTransfer.Item_value = null;
            DataTransfer.price = 0;
            DataTransfer.quantity = 0;
            DataTransfer.str_mark_num = -1;
            DataTransfer.str_datetime = null;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (grid_items_in_inv.CurrentRow != null)
            {
                DataTransfer.str_datetime = date_out.Value.ToString("yyyyMMdd HH:mm:ss");
                DataTransfer.str_num = grid_items_in_inv.CurrentRow.Index;
                DataTransfer.action_change = true;
                DataTransfer.quantity = (int)grid_items_in_inv.CurrentRow.Cells[2].Value;
                DataTransfer.str_mark_num = (int)grid_items_in_inv.CurrentRow.Cells[5].Value;
                if (grid_items_in_inv.CurrentRow.Cells[7].Value != DBNull.Value)
                    DataTransfer.table_act = (string)grid_items_in_inv.CurrentRow.Cells[7].Value;

                Out_inv_act_items itms = new Out_inv_act_items();
                itms.ShowDialog();

                if (DataTransfer.action)
                {
                    ds.Tables[0].Rows[DataTransfer.str_num][1] = DataTransfer.Item_value;
                    ds.Tables[0].Rows[DataTransfer.str_num][2] = DataTransfer.quantity;
                    ds.Tables[0].Rows[DataTransfer.str_num][3] = DataTransfer.price;
                    ds.Tables[0].Rows[DataTransfer.str_num][4] = DataTransfer.price * DataTransfer.quantity;
                    ds.Tables[0].Rows[DataTransfer.str_num][5] = DataTransfer.str_mark_num;
                    ds.Tables[0].Rows[DataTransfer.str_num][6] = DataTransfer.id;
                    if (DataTransfer.table_act != null)
                        ds.Tables[0].Rows[DataTransfer.str_num][7] = DataTransfer.table_act;

                    num_calc_sum.Value = calc_sum();
                }

                DataTransfer.str_num = -1;
                DataTransfer.action = false;
                DataTransfer.action_change = false;
                DataTransfer.id = -1;
                DataTransfer.Item_value = null;
                DataTransfer.table_act = null;
                DataTransfer.price = 0;
                DataTransfer.quantity = 0;
                DataTransfer.str_mark_num = -1;
                DataTransfer.str_datetime = null;
            }
            else
                MessageBox.Show("Не выбран товар", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (grid_items_in_inv.CurrentRow != null)
            {
                if (grid_items_in_inv.CurrentRow.Cells[7].Value != DBNull.Value)
                    del_list.Add(Convert.ToInt32(grid_items_in_inv.CurrentRow.Cells[0].Value));

                ds.Tables[0].Rows.RemoveAt(grid_items_in_inv.CurrentRow.Index);

                num_calc_sum.Value = calc_sum();
            }
            else
                MessageBox.Show("Не выбран товар", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void grid_items_in_inv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_edit_Click(null, null);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
