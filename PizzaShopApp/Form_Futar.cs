using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PizzaShopApp
{
    public partial class Form_Futar : Form
    {
        public Form_Futar()
        {
            InitializeComponent();
        }

        private void Form_Futar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Program.form_navigal.Show();
            e.Cancel = true;
        }

        private void Form_Futar_Load(object sender, EventArgs e)
        {
            Lista_Update();
        }

        void Lista_Update()
        {
            listBox_Futarok.Items.Clear();
            Program.futarok.Clear();
            try
            {
                Program.sql.CommandText = "SELECT `fazon`,`fnev`,`ftel` FROM `pfutar` ORDER BY `fnev`;";
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Futar uj = new Futar(dr.GetInt32("fazon"), dr.GetString("fnev"), dr.GetString("ftel"));
                        listBox_Futarok.Items.Add(uj);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\nAz adatok betöltése sikertelen!");
                Environment.Exit(0);
            }
        }

    }
}
