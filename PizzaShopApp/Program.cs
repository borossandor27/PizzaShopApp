using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PizzaShopApp
{
    static class Program
    {
        public static Form form_navigal = null;
        public static Form form_rendeles = null;
        public static Form form_vevo = null;
        public static MySqlConnection conn = null;
        public static MySqlCommand sql = null;
        public static List<Vevo> vevok = null;
        public static List<Rendeles_tetel> tetelek = null;
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "pizzashop";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\n\nA program leáll!", "Adatbázis hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_navigal = new Form_Navigal();
            form_rendeles = new Form_Rendeles();
            form_vevo = new Form_Vevo();
            Application.Run(form_navigal);
        }
    }
}
