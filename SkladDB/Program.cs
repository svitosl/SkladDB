using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkladDB
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    static class DataTransfer
    {
        public static string Item_value { get; set; }
        public static string table_act { get; set; }
        public static bool is_new_item { get; set; }
        public static int id { get; set; }
        public static decimal price { get; set; }
        public static int quantity { get; set; }
        public static bool action { get; set; }
        public static bool action_change { get; set; }
        public static int str_num { get; set; }
        public static int str_mark_num { get; set; }
        public static string str_datetime { get; set; }
    }
}
