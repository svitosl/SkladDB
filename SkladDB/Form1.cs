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
    public partial class Form1 : Form
    {
        SqlConnection connection;
        DataTable newtable;
        SqlDataAdapter adapter;
        SqlCommand command;
        DataSet ds;

        string query_wrk = "SELECT id_wrk AS '№:', concat(surname, ' ', name, ' ', midname) AS 'ФИО:', " +
                    "profession AS 'Должность:', salary AS 'Зар. плата:', date_start AS 'Дата принятия:', " +
                    "date_end AS 'Дата увольнения:' " +
                    "FROM Workers";

        string query_org = "SELECT id_org AS '№:', concat(form,' ', org_name) AS 'Наименование:', type AS 'Тип:', " +
                    "adress AS 'Адрес:', concat('+',tel_country_code,tel_city_code,tel_number) AS 'Телефон:' " + 
                    "FROM Organizations";

        string query_ininv = "SELECT * FROM InInvWrkOrg";

        string query_outinv = "SELECT * FROM OutInvWrkOrg";

        string query_items_col = "SELECT Items.name AS 'Товар', SUM(Items_in_inv.quantity) AS 'Остаток (кол-во)', " +
                                 "SUM(Items_in_inv.quantity* Items_in_inv.price_one) AS 'Остаток (сумма)' " +
                                 "FROM Items_in_inv " +
                                 "INNER JOIN Items ON Items_in_inv.id_product = Items.id_product " +
                                 "GROUP BY Items.name " +
                                 "HAVING SUM(Items_in_inv.quantity) > 0";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=ANDROID-B7CAT1U;Initial Catalog=Sklad;Integrated Security=True");
            connection.Open();

            ds = new DataSet();

            newtable = ds.Tables.Add();
            adapter = new SqlDataAdapter(query_wrk, connection);
            adapter.Fill(ds.Tables[0]);
            wrk_grid.DataSource = ds.Tables[0];
            wrk_grid.Columns[0].Width = 25;
            wrk_grid.Columns[1].Width = 150;

            newtable = ds.Tables.Add();
            adapter = new SqlDataAdapter(query_org, connection);
            adapter.Fill(ds.Tables[1]);
            org_grid.DataSource = ds.Tables[1];
            wrk_grid.Columns[0].Width = 25;

            newtable = ds.Tables.Add();
            adapter = new SqlDataAdapter(query_ininv, connection);
            adapter.Fill(ds.Tables[2]);
            main_grid.DataSource = ds.Tables[2];
            main_grid.Columns[0].Width = 25;

            newtable = ds.Tables.Add();
            adapter = new SqlDataAdapter(query_outinv, connection);
            adapter.Fill(ds.Tables[3]);
            grid_out_inv.DataSource = ds.Tables[3];
            grid_out_inv.Columns[0].Width = 25;

            newtable = ds.Tables.Add();
            adapter = new SqlDataAdapter(query_items_col, connection);
            adapter.Fill(ds.Tables[4]);
            grid_items_col.DataSource = ds.Tables[4];

            newtable = ds.Tables.Add();
            grid_initem.DataSource = ds.Tables[5];

            newtable = ds.Tables.Add();
            grid_outitem.DataSource = ds.Tables[6];
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Workers wrks = new Workers(false);
            wrks.ShowDialog();

            ds.Tables[0].Clear();
            adapter = new SqlDataAdapter(query_wrk, connection);
            adapter.Fill(ds.Tables[0]);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void btn_wrk_edit_Click(object sender, EventArgs e)
        {
            if (wrk_grid.CurrentRow != null)
            {
                if (wrk_grid.CurrentRow.Cells[5].Value.ToString() == "")
                {
                    int id_item = Convert.ToInt32(wrk_grid.CurrentRow.Cells[0].Value);
                    Workers wrks = new Workers(true, id_item);
                    wrks.ShowDialog();

                    ds.Tables[0].Clear();
                    adapter = new SqlDataAdapter(query_wrk, connection);
                    adapter.Fill(ds.Tables[0]);
                }
                else
                    MessageBox.Show("Сотрудник уволен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Не выбран сотрудник", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void wrk_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_wrk_edit_Click(null, null);
        }

        private void btn_dismiss_Click(object sender, EventArgs e)
        {
            if (wrk_grid.CurrentRow != null)
            {
                if (wrk_grid.CurrentRow.Cells[5].Value.ToString() == "")
                {
                    int id_item = Convert.ToInt32(wrk_grid.CurrentRow.Cells[0].Value);
                    Dismiss dism = new Dismiss(id_item);
                    dism.ShowDialog();

                    ds.Tables[0].Clear();
                    adapter = new SqlDataAdapter(query_wrk, connection);
                    adapter.Fill(ds.Tables[0]);
                }
                else
                    MessageBox.Show("Сотрудник уже уволен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Не выбран сотрудник", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (wrk_grid.CurrentRow != null)
            {
                if (wrk_grid.CurrentRow.Cells[5].Value.ToString() == "")
                {
                    DialogResult result = MessageBox.Show("Удалить запись о сотруднике?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int id_item = Convert.ToInt32(wrk_grid.CurrentRow.Cells[0].Value);
                        command = new SqlCommand("DELETE FROM [Workers] WHERE id_wrk = " + id_item, connection);
                        command.ExecuteNonQuery();

                        ds.Tables[0].Clear();
                        adapter = new SqlDataAdapter(query_wrk, connection);
                        adapter.Fill(ds.Tables[0]);
                    }

                }
                else
                    MessageBox.Show("Сотрудник уже уволен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Не выбран сотрудник", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_org_add_Click(object sender, EventArgs e)
        {
            Organizations org = new Organizations(false);
            org.ShowDialog();

            ds.Tables[1].Clear();
            adapter = new SqlDataAdapter(query_org, connection);
            adapter.Fill(ds.Tables[1]);
        }

        private void btn_org_edit_Click(object sender, EventArgs e)
        {
            if (org_grid.CurrentRow != null)
            {
                int id_item = Convert.ToInt32(org_grid.CurrentRow.Cells[0].Value);
                Organizations org = new Organizations(true, id_item);
                org.ShowDialog();

                ds.Tables[1].Clear();
                adapter = new SqlDataAdapter(query_org, connection);
                adapter.Fill(ds.Tables[1]);
            }
            else
                MessageBox.Show("Не выбрана оргнанизация", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void org_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_org_edit_Click(null, null);
        }

        private void btn_org_del_Click(object sender, EventArgs e)
        {
            if (org_grid.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Удалить запись о организации?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int id_item = Convert.ToInt32(org_grid.CurrentRow.Cells[0].Value);
                    command = new SqlCommand("sp_DeleteOrg", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter Parametr = new SqlParameter
                    {
                        ParameterName = "@id_org",
                        Value = id_item
                    };
                    command.Parameters.Add(Parametr);
                    command.ExecuteNonQuery();

                    ds.Tables[1].Clear();
                    adapter = new SqlDataAdapter(query_org, connection);
                    adapter.Fill(ds.Tables[1]);
                }
            }
            else
                MessageBox.Show("Не выбрана организация", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_journal_Click(object sender, EventArgs e)
        {
            journal jrl = new journal();
            jrl.ShowDialog();
        }

        private void btn_ext_fun_Click(object sender, EventArgs e)
        {
            Ext_fun ext = new Ext_fun();
            ext.ShowDialog();

            ds.Tables[1].Clear();
            adapter = new SqlDataAdapter(query_org, connection);
            adapter.Fill(ds.Tables[1]);
        }

        private void btn_main_add_Click(object sender, EventArgs e)
        {
            In_inv_act act = new In_inv_act();
            act.ShowDialog();

            ds.Tables[2].Clear();
            adapter = new SqlDataAdapter(query_ininv, connection);
            adapter.Fill(ds.Tables[2]);
        }

        private void btn_main_edit_Click(object sender, EventArgs e)
        {
            if (main_grid.CurrentRow != null)
            {
                In_inv_edit edit = new In_inv_edit(Convert.ToInt32(main_grid.CurrentRow.Cells[0].Value));
                edit.ShowDialog();

                ds.Tables[2].Clear();
                adapter = new SqlDataAdapter(query_ininv, connection);
                adapter.Fill(ds.Tables[2]);
            }
            else
                MessageBox.Show("Не выбрана накладная", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void main_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_main_edit_Click(null, null);
        }

        private void btn_ininv_del_Click(object sender, EventArgs e)
        {
            if (main_grid.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Удалить запись о накладной?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    command = new SqlCommand("DELETE FROM Items_in_inv WHERE id_in_invoice = " + Convert.ToInt32(main_grid.CurrentRow.Cells[0].Value), connection);
                    command.ExecuteNonQuery();

                    command = new SqlCommand("DELETE FROM In_invoices WHERE id_in_invoice = " + Convert.ToInt32(main_grid.CurrentRow.Cells[0].Value), connection);
                    command.ExecuteNonQuery();

                    ds.Tables[2].Clear();
                    adapter = new SqlDataAdapter(query_ininv, connection);
                    adapter.Fill(ds.Tables[2]);
                }
            }
            else
                MessageBox.Show("Не выбрана накладная", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_outinv_add_Click(object sender, EventArgs e)
        {
            Out_inv_act act = new Out_inv_act();
            act.ShowDialog();

            ds.Tables[3].Clear();
            adapter = new SqlDataAdapter(query_outinv, connection);
            adapter.Fill(ds.Tables[3]);
        }

        private void btn_outinv_edit_Click(object sender, EventArgs e)
        {
            if (grid_out_inv.CurrentRow != null)
            {
                Out_inv_edit edit = new Out_inv_edit(Convert.ToInt32(grid_out_inv.CurrentRow.Cells[0].Value));
                edit.ShowDialog();

                ds.Tables[3].Clear();
                adapter = new SqlDataAdapter(query_outinv, connection);
                adapter.Fill(ds.Tables[3]);
            }
            else
                MessageBox.Show("Не выбрана накладная", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void grid_out_inv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_outinv_edit_Click(null, null);
        }

        private void btn_outinv_del_Click(object sender, EventArgs e)
        {
            if (grid_out_inv.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Удалить запись о накладной?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    command = new SqlCommand("DELETE FROM Items_in_inv WHERE id_in_invoice = " + Convert.ToInt32(grid_out_inv.CurrentRow.Cells[0].Value), connection);
                    command.ExecuteNonQuery();

                    command = new SqlCommand("DELETE FROM In_invoices WHERE id_in_invoice = " + Convert.ToInt32(grid_out_inv.CurrentRow.Cells[0].Value), connection);
                    command.ExecuteNonQuery();

                    ds.Tables[3].Clear();
                    adapter = new SqlDataAdapter(query_outinv, connection);
                    adapter.Fill(ds.Tables[3]);
                }
            }
            else
                MessageBox.Show("Не выбрана накладная", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void but_ext_fun_Click(object sender, EventArgs e)
        {
            Ext_fun_wrk ext = new Ext_fun_wrk();
            ext.ShowDialog();
        }

        private void btn_select_qty_Click(object sender, EventArgs e)
        {
            ds.Tables[5].Clear();
            adapter = new SqlDataAdapter(
            "SELECT kol.name AS 'Имя', SUM(kol.quantity) AS 'Кол-во', " +
            "SUM(kol.quantity * kol.price_one) AS 'Общая стоимость' " +
            "FROM " +
            "(SELECT Items.name, Items_in_inv.quantity, Items_in_inv.price_one, In_invoices.date_in, " +
            "CASE " +
            "WHEN In_invoices.date_in BETWEEN '" + numeric_year.Value + "-01-01 00:00:00' AND '" + numeric_year.Value + "-31-03 23:59:59' " +
            "THEN '1-й квартал' " +
            "WHEN In_invoices.date_in BETWEEN '" + numeric_year.Value + "-01-04 00:00:00' AND '" + numeric_year.Value + "-30-06 23:59:59' " +
            "THEN '2-й квартал' " +
            "WHEN In_invoices.date_in BETWEEN '" + numeric_year.Value + "-01-07 00:00:00' AND '" + numeric_year.Value + "-30-09 23:59:59' " +
            "THEN '3-й квартал' " +
            "WHEN In_invoices.date_in BETWEEN '" + numeric_year.Value + "-01-10 00:00:00' AND '" + numeric_year.Value + "-31-12 23:59:59' " +
            "THEN '4-й квартал' " +
            "END AS qrt " +
            "FROM In_invoices " +
            "INNER JOIN Items_in_inv ON In_invoices.id_in_invoice = Items_in_inv.id_in_invoice " +
            "INNER JOIN Items ON Items_in_inv.id_product = Items.id_product " +
            "WHERE In_invoices.num_invoice is not null) AS kol " +
            "WHERE qrt = '" + combo_qrt.Text + "' " +
            "GROUP BY kol.name", connection);
            adapter.Fill(ds.Tables[5]);

            ds.Tables[6].Clear();
            adapter = new SqlDataAdapter(
            "SELECT kol.name AS 'Имя', SUM(kol.quantity) * -1 AS 'Кол-во', " +
            "SUM(kol.quantity * kol.price_one) * -1 AS 'Общая стоимость' " +
            "FROM " +
            "(SELECT Items.name, Items_in_inv.quantity, Items_in_inv.price_one, In_invoices.date_in, " +
            "CASE " +
            "WHEN In_invoices.date_in BETWEEN '" + numeric_year.Value + "-01-01 00:00:00' AND '" + numeric_year.Value + "-31-03 23:59:59' " +
            "THEN '1-й квартал' " +
            "WHEN In_invoices.date_in BETWEEN '" + numeric_year.Value + "-01-04 00:00:00' AND '" + numeric_year.Value + "-30-06 23:59:59' " +
            "THEN '2-й квартал' " +
            "WHEN In_invoices.date_in BETWEEN '" + numeric_year.Value + "-01-07 00:00:00' AND '" + numeric_year.Value + "-30-09 23:59:59' " +
            "THEN '3-й квартал' " +
            "WHEN In_invoices.date_in BETWEEN '" + numeric_year.Value + "-01-10 00:00:00' AND '" + numeric_year.Value + "-31-12 23:59:59' " +
            "THEN '4-й квартал' " +
            "END AS qrt " +
            "FROM In_invoices " +
            "INNER JOIN Items_in_inv ON In_invoices.id_in_invoice = Items_in_inv.id_in_invoice " +
            "INNER JOIN Items ON Items_in_inv.id_product = Items.id_product " +
            "WHERE In_invoices.num_out_invoice is not null) AS kol " +
            "WHERE qrt = '" + combo_qrt.Text + "' " +
            "GROUP BY kol.name", connection);
            adapter.Fill(ds.Tables[6]);
        }

        private void btn_ininv_upd_Click(object sender, EventArgs e)
        {
            ds.Tables[2].Clear();
            adapter = new SqlDataAdapter(query_ininv, connection);
            adapter.Fill(ds.Tables[2]);
        }

        private void btn_outinv_upd_Click(object sender, EventArgs e)
        {
            ds.Tables[3].Clear();
            adapter = new SqlDataAdapter(query_outinv, connection);
            adapter.Fill(ds.Tables[3]);
        }

        private void btn_items_upd_Click(object sender, EventArgs e)
        {
            ds.Tables[4].Clear();
            adapter = new SqlDataAdapter(query_items_col, connection);
            adapter.Fill(ds.Tables[4]);
        }
    }
}
