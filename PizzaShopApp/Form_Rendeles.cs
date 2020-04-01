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
using System.IO;

namespace PizzaShopApp
{
    public partial class Form_Rendeles : Form
    {
        public Form_Rendeles()
        {
            InitializeComponent();
        }

        private void Form_Rendeles_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Program.form_navigal.Show();
            e.Cancel = true;
        }

        private void Form_Rendeles_Load(object sender, EventArgs e)
        {
            Vevoket_Betolt();
            Pizzakat_Betolt();
            Tetelek_Update();
        }
        void Vevoket_Betolt()
        {
            comboBox_Vevo.Items.Clear();
            picture_Vevo.Image = null;
            Program.sql.CommandText = "SELECT `vazon`,`vnev`,`vcim` FROM `pvevo` ";
            using (MySqlDataReader dr = Program.sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    comboBox_Vevo.Items.Add(new Vevo(dr.GetInt32("vazon"), dr.GetString("vnev"), dr.GetString("vcim")));
                }
            }
        }
        void Pizzakat_Betolt()
        {
            comboBox_Pizza.Items.Clear();
            picture_Pizza.Image = null;
            Program.sql.CommandText = "SELECT ppizza.pazon, ppizza.pnev, ppizza.par FROM ppizza";
            using (MySqlDataReader dr=Program.sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    comboBox_Pizza.Items.Add(new Rendeles_tetel(dr.GetInt32("pazon"), dr.GetString("pnev"), dr.GetInt32("par"), 0));
                }               
            }
        }
        void Tetelek_Update()
        {
            listBox_Tetelek.Items.Clear();
            foreach (Rendeles_tetel item in comboBox_Pizza.Items)
            {
                if (item.Db>0)
                {
                    listBox_Tetelek.Items.Add(item.Teteles());
                }
            }
        }

        private void comboBox_Vevo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vevo vevo = (Vevo)comboBox_Vevo.SelectedItem;
            string kep = @"Resources\Vevo_" + vevo.Nev + ".png";
            if (File.Exists(kep))
            {
                picture_Vevo.Image = Image.FromFile(kep);
            }
        }
    }
}
