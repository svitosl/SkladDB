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
    public partial class In_inv_act : Form
    {
        SqlConnection connection;
        DataSet ds;
        DataTable newtable;
        SqlDataAdapter adapter;
        SqlCommand command;
        SqlParameter param;

        public In_inv_act()
        {
            InitializeComponent();
        }
        
        private decimal calc_sum()
        {
            decimal sum = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                sum += (decimal)ds.Tables[0].Rows[i][3];

            return sum;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            int id_invoice, id_item;

            command = new SqlCommand("INSERT INTO In_invoices (id_wrk, id_org, num_invoice, date_in, date_purchase, notes, fio_exp, prof_exp) VALUES (@id_wrk, @id_org, @num_invoice, @date_in, @date_purchase, @notes, @fio_exp, @prof_exp); SELECT CAST(SCOPE_IDENTITY() AS int)", connection);

            param = new SqlParameter("@id_wrk", (int)combo_worker.SelectedValue);
            command.Parameters.Add(param);

            param = new SqlParameter("@id_org", (int)combo_org.SelectedValue);
            command.Parameters.Add(param);

            param = new SqlParameter("@num_invoice", txt_num_inv.Text);
            command.Parameters.Add(param);

            param = new SqlParameter("@date_in", date_in.Text);
            command.Parameters.Add(param);

            param = new SqlParameter("@date_purchase", date_purchase.Text);
            command.Parameters.Add(param);

            param = new SqlParameter("@notes", notes.Text);
            command.Parameters.Add(param);

            param = new SqlParameter("@fio_exp", fio_exp.Text);
            command.Parameters.Add(param);

            param = new SqlParameter("@prof_exp", prof_exp.Text);
            command.Parameters.Add(param);

            id_invoice = (int)command.ExecuteScalar();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if ((bool)ds.Tables[0].Rows[i][4])
                {
                    command = new SqlCommand("INSERT INTO Items (name) VALUES (@name); SELECT CAST(SCOPE_IDENTITY() AS int)", connection);
                    param = new SqlParameter("@name", (string)ds.Tables[0].Rows[i][0]);
                    command.Parameters.Add(param);

                    id_item = (int)command.ExecuteScalar();

                }
                else
                    id_item = (int)ds.Tables[0].Rows[i][5];

                command = new SqlCommand("INSERT INTO Items_in_inv (id_product, id_in_invoice, quantity, price_one, mark_number) VALUES (@id_product, @id_in_invoice, @quantity, @price_one, @mark_number)", connection);

                param = new SqlParameter("@id_product", id_item);
                command.Parameters.Add(param);

                param = new SqlParameter("@id_in_invoice", id_invoice);
                command.Parameters.Add(param);

                param = new SqlParameter("@quantity", (int)ds.Tables[0].Rows[i][1]);
                command.Parameters.Add(param);

                param = new SqlParameter("@price_one", ds.Tables[0].Rows[i][2]);
                command.Parameters.Add(param);

                param = new SqlParameter("@mark_number", ds.Tables[0].Rows[i][6]);
                command.Parameters.Add(param);

                command.ExecuteNonQuery();
            }
            this.Close();
        }

        private void In_inv_act_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=ANDROID-B7CAT1U;Initial Catalog=Sklad;Integrated Security=True");
            connection.Open();

            DataTransfer.id = -1;
            ds = new DataSet();

            newtable = ds.Tables.Add();
            newtable.Columns.Add("Имя", typeof(string));
            newtable.Columns.Add("Колличество", typeof(int));
            newtable.Columns.Add("Цена (ед.)", typeof(decimal));
            newtable.Columns.Add("Общая стоимость", typeof(decimal));
            newtable.Columns.Add("Новый товар ?", typeof(bool));
            newtable.Columns.Add("Номер товара", typeof(int));
            newtable.Columns.Add("Номер маркировки", typeof(int));
            grid_items_in_inv.DataSource = ds.Tables[0];
            foreach (DataGridViewColumn column in grid_items_in_inv.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            grid_items_in_inv.Columns[4].Visible = false;
            grid_items_in_inv.Columns[5].Visible = false;

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
        }

        private void In_inv_act_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            In_inv_act_items itms = new In_inv_act_items();
            itms.ShowDialog();

            if (DataTransfer.action)
            { 
                if (DataTransfer.id == -1)
                ds.Tables[0].Rows.Add(DataTransfer.Item_value, DataTransfer.quantity, DataTransfer.price, DataTransfer.price * DataTransfer.quantity, DataTransfer.is_new_item, DBNull.Value, DataTransfer.str_mark_num);
                else
                ds.Tables[0].Rows.Add(DataTransfer.Item_value, DataTransfer.quantity, DataTransfer.price, DataTransfer.price * DataTransfer.quantity, DataTransfer.is_new_item, DataTransfer.id, DataTransfer.str_mark_num);

                num_calc_sum.Value = calc_sum();
            }

            DataTransfer.action = false;
            DataTransfer.is_new_item = false;
            DataTransfer.id = -1;
            DataTransfer.Item_value = null;
            DataTransfer.price = 0;
            DataTransfer.quantity = 0;
            DataTransfer.str_mark_num = -1;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            if (grid_items_in_inv.CurrentRow != null)
            {
                DataTransfer.str_num = grid_items_in_inv.CurrentRow.Index;
                DataTransfer.action_change = true;
                DataTransfer.Item_value = (string)grid_items_in_inv.CurrentRow.Cells[0].Value;
                DataTransfer.quantity = (int)grid_items_in_inv.CurrentRow.Cells[1].Value;
                DataTransfer.price = (decimal)grid_items_in_inv.CurrentRow.Cells[2].Value;
                DataTransfer.is_new_item = (bool)grid_items_in_inv.CurrentRow.Cells[4].Value;
                if (grid_items_in_inv.CurrentRow.Cells[5].Value != DBNull.Value)
                    DataTransfer.id = (int)grid_items_in_inv.CurrentRow.Cells[5].Value;
                DataTransfer.str_mark_num = (int)grid_items_in_inv.CurrentRow.Cells[6].Value;

                In_inv_act_items itms = new In_inv_act_items();
                itms.ShowDialog();

                if (DataTransfer.action)
                {
                    ds.Tables[0].Rows[DataTransfer.str_num][0] = DataTransfer.Item_value;
                    ds.Tables[0].Rows[DataTransfer.str_num][1] = DataTransfer.quantity;
                    ds.Tables[0].Rows[DataTransfer.str_num][2] = DataTransfer.price;
                    ds.Tables[0].Rows[DataTransfer.str_num][3] = DataTransfer.price * DataTransfer.quantity;
                    ds.Tables[0].Rows[DataTransfer.str_num][4] = DataTransfer.is_new_item;
                    if (DataTransfer.id != -1)
                        ds.Tables[0].Rows[DataTransfer.str_num][5] = DataTransfer.id;
                    else if (ds.Tables[0].Rows[DataTransfer.str_num][5] != DBNull.Value)
                        ds.Tables[0].Rows[DataTransfer.str_num][5] = DBNull.Value;
                    ds.Tables[0].Rows[DataTransfer.str_num][6] = DataTransfer.str_mark_num;

                    num_calc_sum.Value = calc_sum();
                }

                DataTransfer.str_num = -1;
                DataTransfer.action = false;
                DataTransfer.action_change = false;
                DataTransfer.is_new_item = false;
                DataTransfer.id = -1;
                DataTransfer.Item_value = null;
                DataTransfer.price = 0;
                DataTransfer.quantity = 0;
                DataTransfer.str_mark_num = -1;
            }
            else
                MessageBox.Show("Не выбран товар", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (grid_items_in_inv.CurrentRow != null)
            {
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
