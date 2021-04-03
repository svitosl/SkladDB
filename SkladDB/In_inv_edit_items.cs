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
    public partial class In_inv_edit_items : Form
    {
        SqlConnection connection;

        public In_inv_edit_items()
        {
            InitializeComponent();
        }

        private void In_inv_act_items_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=ANDROID-B7CAT1U;Initial Catalog=Sklad;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id_product, name FROM Items", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            combo_items.DataSource = table.AsDataView();
            combo_items.DisplayMember = "name";
            combo_items.ValueMember = "id_product";

            if (DataTransfer.action_change)
            {
                numeric_price.Value = (decimal)DataTransfer.price;
                numeric_quantity.Value = DataTransfer.quantity;
                numeric_mark.Value = DataTransfer.str_mark_num;

                if (DataTransfer.table_act == null)
                {
                    if (DataTransfer.is_new_item)
                        text_items.Text = DataTransfer.Item_value;
                    else
                        combo_items.Text = DataTransfer.Item_value;
                }
                else
                {
                    text_items.Text = DataTransfer.Item_value;
                }
            }
        }

        private void In_inv_act_items_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void btn_add_old_Click(object sender, EventArgs e)
        {
            DataTransfer.action = true;
            DataTransfer.Item_value = combo_items.Text;
            DataTransfer.is_new_item = false;
            DataTransfer.id = (int)combo_items.SelectedValue;
            DataTransfer.price = numeric_price.Value;
            DataTransfer.quantity = (int)numeric_quantity.Value;
            if (DataTransfer.table_act != null)
                DataTransfer.table_act = "Изм. (id)";
            DataTransfer.str_mark_num = (int)numeric_mark.Value;
            this.Close();
        }

        private void btn_add_new_Click(object sender, EventArgs e)
        {
            DataTransfer.action = true;
            DataTransfer.Item_value = text_items.Text;
            DataTransfer.is_new_item = true;
            DataTransfer.id = -1;
            DataTransfer.price = numeric_price.Value;
            DataTransfer.quantity = (int)numeric_quantity.Value;
            if (DataTransfer.table_act != null)
                DataTransfer.table_act = "Изм. (имя)";
            DataTransfer.str_mark_num = (int)numeric_mark.Value;
            this.Close();
        }

        private void numeric_price_ValueChanged(object sender, EventArgs e)
        {
            string tmp = numeric_price.Value.ToString();

            if (tmp.IndexOf(',') != -1)
            {
                string[] temp = numeric_price.Value.ToString().Split(',');
                if (temp[1].Length > 2)
                {
                    MessageBox.Show("Число знаков после запятой должно быть не больше 2-х!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numeric_price.Value = 1.00m;
                }
            }
        }
    }
}
