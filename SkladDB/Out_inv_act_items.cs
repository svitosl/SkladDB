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
    public partial class Out_inv_act_items : Form
    {
        SqlConnection connection;

        public Out_inv_act_items()
        {
            InitializeComponent();
        }

        private void In_inv_act_items_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=ANDROID-B7CAT1U;Initial Catalog=Sklad;Integrated Security=True");
            connection.Open();

            if (DataTransfer.action_change)
            {
                numeric_mark.Value = DataTransfer.str_mark_num;
                btn_search_Click(null, null);
                numeric_quantity.Value = DataTransfer.quantity;
            }
        }

        private void In_inv_act_items_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void btn_add_old_Click(object sender, EventArgs e)
        {
            if (txt_name_item.Text == "" || numeric_quantity.Value == 0 || numeric_number.Value == 0 || numeric_price.Value == 0.00m)
            {
                MessageBox.Show("Товар не выбран.", "Списание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTransfer.action = true;
                DataTransfer.Item_value = txt_name_item.Text;
                DataTransfer.id = (int)numeric_number.Value;
                DataTransfer.price = numeric_price.Value;
                DataTransfer.quantity = (int)numeric_quantity.Value;
                DataTransfer.str_mark_num = (int)numeric_mark.Value;
                if (DataTransfer.table_act != null)
                    DataTransfer.table_act = "Изм. (id)";
                this.Close();
            }
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

        private void numeric_quantity_ValueChanged(object sender, EventArgs e)
        {
            if (numeric_quantity.Value > numeric_cnt.Value)
            {
                MessageBox.Show("Число единиц товра, которое должно быть списано, не должно быть больше текущего остатка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numeric_quantity.Value = 1;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT TOP 1 Items_in_inv.id_product, Items.name, Items_in_inv.price_one " + 
                                                "FROM Items_in_inv " +
                                                "INNER JOIN Items ON Items_in_inv.id_product = Items.id_product " +
                                                "WHERE Items_in_inv.mark_number = " + numeric_mark.Value, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                numeric_number.Value = reader.GetInt32(0);
                txt_name_item.Text = reader.GetString(1);
                numeric_price.Value = reader.GetDecimal(2);
                reader.Close();
            }
            else
            {
                MessageBox.Show("Такой маркировки товара не найдено.", "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numeric_number.Value = 0;
                txt_name_item.Text = "";
                numeric_price.Value = 0.00m;
                reader.Close();
                return;
            }

            command = new SqlCommand("SELECT SUM(kol.quantity) " +
                                     "FROM " +
                                     "(SELECT Items.name, Items_in_inv.quantity, In_invoices.date_in " +
                                     "FROM In_invoices " +
                                     "INNER JOIN Items_in_inv ON In_invoices.id_in_invoice = Items_in_inv.id_in_invoice " +
                                     "INNER JOIN Items ON Items_in_inv.id_product = Items.id_product " +
                                     "WHERE Items_in_inv.mark_number = " + numeric_mark.Value + " AND In_invoices.date_in < '" + DataTransfer.str_datetime + "') AS kol", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();

                if(reader.IsDBNull(0))
                {
                    MessageBox.Show("Товара с датой принятия раньше даты списания накладной не найдено.", "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numeric_number.Value = 0;
                    txt_name_item.Text = "";
                    numeric_price.Value = 0.00m;
                    reader.Close();
                    return;
                }

                if (reader.GetInt32(0) != 0)
                {
                    numeric_cnt.Value = reader.GetInt32(0);
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Весь товар на складе с такой маркировкой списан!", "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numeric_number.Value = 0;
                    txt_name_item.Text = "";
                    numeric_price.Value = 0.00m;
                    reader.Close();
                }
            }
            else
                reader.Close();
        }
    }
}
