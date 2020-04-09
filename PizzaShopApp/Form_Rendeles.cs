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
        List<Rendeles_tetel> rendelesek = new List<Rendeles_tetel>();
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
            Futarokat_Betolt();
            Rendeles_Tetelek_Update();
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
            Program.sql.CommandText = "SELECT ppizza.pazon, ppizza.pnev, ppizza.par FROM ppizza;";
            using (MySqlDataReader dr=Program.sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    comboBox_Pizza.Items.Add(new Pizza(dr.GetInt32("pazon"), dr.GetString("pnev"), dr.GetInt32("par")));
                    rendelesek.Add(new Rendeles_tetel(dr.GetInt32("pazon"), dr.GetString("pnev"), dr.GetInt32("par"), 0));
                }               
            }
        }
        void Futarokat_Betolt()
        {
            Program.sql.CommandText = "SELECT `fazon`,`fnev`,`ftel` FROM `pfutar`; ";
            using (MySqlDataReader dr = Program.sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    comboBox_Futar_neve.Items.Add(new Futar(dr.GetInt32("fazon"), dr.GetString("fnev"), dr.GetString("ftel")));
                }
            }
        }
        void Rendeles_Tetelek_Update()
        {
            listBox_Tetelek.Items.Clear();
            textBox_Fizetendo.Text = "";
            int sum = 0;
            foreach (Rendeles_tetel item in rendelesek)
            {
                if (item.Db>0)
                {
                    listBox_Tetelek.Items.Add(item);
                    sum += item.PizzaAr * item.Db;
                }
            }
            textBox_Fizetendo.Text = sum.ToString("#,##0");
        }
        void Futar_Update()
        {
            comboBox_Futar_neve.Items.Clear();
            textBox_Futar_telefonszama.Text = "";

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

        private void comboBox_Pizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Pizza.SelectedIndex < 0)
            {
                return;
            }
            Pizza pizza = (Pizza)comboBox_Pizza.SelectedItem;
            picture_Pizza.Image = pizza.PizzaKep;
        }

        private void button_Listaba_Click(object sender, EventArgs e)
        {
            if (comboBox_Pizza.SelectedIndex < 0)
            {
                MessageBox.Show("Nem választott ki pizza-t!");
                return;
            }
            if (numeric_Mennyiseg.Value < 1)
            {
                MessageBox.Show("Nem adott meg mennyiséget!");
                return;
            }
            Pizza rp = (Pizza)comboBox_Pizza.SelectedItem;
            rendelesek.Add(new Rendeles_tetel(rp.PizzaId, rp.PizzaNev, rp.PizzaAr, (int)numeric_Mennyiseg.Value));
            Rendeles_Tetelek_Update();
            comboBox_Pizza.SelectedIndex = -1;
            numeric_Mennyiseg.Value = 0;
        }

        private void comboBox_Futar_neve_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Futar_neve.SelectedIndex < 0)
            {
                textBox_Futar_telefonszama.Text = "";
                return;
            }
            Futar futar = (Futar)comboBox_Futar_neve.SelectedItem;
            textBox_Futar_telefonszama.Text = futar.Telefon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_Vevo.SelectedIndex < 0)
            {
                MessageBox.Show("Nem választott vevőt!");
                return;
            }
            if (listBox_Tetelek.Items.Count < 1)
            {
                MessageBox.Show("Nem adott meg vásárolandó pizza-t!");
                return;
            }
            if (comboBox_Futar_neve.SelectedIndex < 0)
            {
                MessageBox.Show("Válasszon futárt!");
                return;
            }
            Futar futar = (Futar)comboBox_Futar_neve.SelectedItem;
            Vevo vevo = (Vevo)comboBox_Vevo.SelectedItem;
            // A adatbázis konzisztenciájának megőrzése miatt használjuk a tranzakció követést!
            MySqlTransaction myTrans = Program.conn.BeginTransaction();
            try
            {
                Program.sql.CommandText = "INSERT INTO `prendeles` (`razon`, `vazon`, `fazon`, `datum`) VALUES (NULL, @vazon, @fazon, @datum); ";
                Program.sql.Parameters.Clear();
                Program.sql.Parameters.AddWithValue("@vazon", vevo.Id);
                Program.sql.Parameters.AddWithValue("@fazon", futar.Id);
                Program.sql.Parameters.AddWithValue("@datum", DateTime.Now);
                Program.sql.ExecuteNonQuery();
                int razon = Convert.ToInt32(Program.sql.LastInsertedId);
                //-- A tételek rögzítése
                Program.sql.CommandText = "INSERT INTO `ptetel` (`razon`, `pazon`, `db`) VALUES (@razon, @pazon, @db); ";
                foreach (Rendeles_tetel item in listBox_Tetelek.Items)
                {
                    Program.sql.Parameters.Clear();
                    Program.sql.Parameters.AddWithValue("@razon", razon);
                    Program.sql.Parameters.AddWithValue("@pazon", item.PizzaId);
                    Program.sql.Parameters.AddWithValue("@db", item.Db);
                    Program.sql.ExecuteNonQuery();
                }

                myTrans.Commit(); //-- az adatbázisműveletek rögzítése
                MessageBox.Show("Az adatok rögzítése sikeres!");
                listBox_Tetelek.Items.Clear();
                Futarokat_Betolt();
                Vevoket_Betolt();
                Pizzakat_Betolt();
            }
            catch (MySqlException ex)
            {

                myTrans.Rollback();
                MessageBox.Show(ex.Message + "\n\nAz adatok rögzítése sikertelen!");
                return;
            }

        }
    }
}
