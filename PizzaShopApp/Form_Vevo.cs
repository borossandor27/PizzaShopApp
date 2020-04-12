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
using PizzaShopApp.Properties;

namespace PizzaShopApp
{
    public partial class Form_Vevo : Form
    {
        public Form_Vevo()
        {
            InitializeComponent();
        }

        private void Form_Vevo_Load(object sender, EventArgs e)
        {
            Create_Vevok_tabla();
            Vevok_tabla_Update();
        }

        void Create_Vevok_tabla()
        {
            dataGridView_Osszes_vevo.Columns.Clear();
            /*
             * A dataGridView elem tulajdonságainak beállítása
             */
            dataGridView_Osszes_vevo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridView_Osszes_vevo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_Osszes_vevo.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView_Osszes_vevo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Osszes_vevo.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            dataGridView_Osszes_vevo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_Osszes_vevo.MultiSelect = false;
            dataGridView_Osszes_vevo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //-- Az id oszlop --------------------------------------------------
            DataGridViewColumn column_ID = new DataGridViewColumn();
            {
                column_ID.Name = "ID";
                column_ID.DataPropertyName = "ID";
                column_ID.CellTemplate = new DataGridViewTextBoxCell();
                column_ID.Visible = true;
            }
            dataGridView_Osszes_vevo.Columns.Add(column_ID);

            //-- A név oszlop --------------------------------------------------
            DataGridViewTextBoxColumn column_Nev = new DataGridViewTextBoxColumn();
            {
                column_Nev.HeaderText = "Név";
                column_Nev.Name = "Nev";
                column_Nev.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView_Osszes_vevo.Columns.Add(column_Nev);
            //-- A cim oszlop --------------------------------------------------
            DataGridViewTextBoxColumn column_Cim = new DataGridViewTextBoxColumn();
            {
                column_Cim.HeaderText = "Cím";
                column_Cim.Name = "Cim";
                column_Cim.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView_Osszes_vevo.Columns.Add(column_Cim);
        }
        void Vevok_tabla_Update()
        {
            dataGridView_Osszes_vevo.Rows.Clear();
            Program.sql.CommandText = "SELECT `vazon`,`vnev`,`vcim` FROM `pvevo` ;";
            Program.sql.Parameters.Clear();
            try
            {
                //Program.conn.Open();
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int uj_sor_index = dataGridView_Osszes_vevo.Rows.Add();

                        DataGridViewRow uj_sor = dataGridView_Osszes_vevo.Rows[uj_sor_index];
                        uj_sor.Cells["ID"].Value = dr.GetInt32("vazon");
                        uj_sor.Cells["Nev"].Value = dr.GetString("vnev");
                        uj_sor.Cells["Cim"].Value = dr.GetString("vcim");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\nVevőadatok betöltése sikertelen!");
                return;
            }
        }

        private void Form_Vevo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide(); 
            Program.form_navigal.Show();
 
            e.Cancel = true;

        }

        /// <summary>
        /// Betölti az adott sorban lévő adatokat a beviteli mezőbe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_Osszes_vevo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int akt = dataGridView_Osszes_vevo.SelectedRows[0].Index;
            textBox_Vevo_id.Text = dataGridView_Osszes_vevo.Rows[akt].Cells["ID"].Value.ToString();
            textBox_Vevo_nev.Text = dataGridView_Osszes_vevo.Rows[akt].Cells["Nev"].Value.ToString();
            textBox_Vevo_cim.Text = dataGridView_Osszes_vevo.Rows[akt].Cells["Cim"].Value.ToString();
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            string nev = textBox_Vevo_nev.Text.Trim();
            if (string.IsNullOrEmpty(nev))
            {
                MessageBox.Show("Kérem, adjon meg nevet!");
                textBox_Vevo_nev.Select(0, 0);
                textBox_Vevo_nev.Focus();
                return;
            }
            string cim = textBox_Vevo_cim.Text.Trim();
            if (string.IsNullOrEmpty(cim))
            {
                MessageBox.Show("Kérem, adjon meg címet!");
                textBox_Vevo_cim.Focus();
                textBox_Vevo_cim.Select(0, 0);
                return;
            }
            try
            {
                Program.sql.CommandText = "SELECT * FROM `pvevo` WHERE `vnev` = @nev; ";
                Program.sql.Parameters.Clear();
                Program.sql.Parameters.AddWithValue("@nev", nev);
                MySqlDataReader dr = Program.sql.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show($"{nev} névvel már rögzítettek vevőt!");
                    return;
                }
                Program.sql.CommandText = "INSERT INTO `pvevo` (`vazon`, `vnev`, `vcim`) VALUES (NULL, @vnev, @vcim);";
                Program.sql.Parameters.Clear();
                Program.sql.Parameters.AddWithValue("@vnev", nev);
                Program.sql.Parameters.AddWithValue("@vcim", cim);
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\nA vevő rögzítése sikertelen!");
                return;
            }
            MessageBox.Show(nev + " nevű vevő rögzítése sikeres!");
            textBox_Vevo_nev.Text = "";
            textBox_Vevo_cim.Text = "";
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string id = textBox_Vevo_id.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Nincs kiválasztott vevő!");
                return;
            }
            Program.sql.CommandText = "DELETE FROM `pvevo` WHERE `pvevo`.`vazon` = @id;";
            Program.sql.Parameters.Clear();
            Program.sql.Parameters.AddWithValue("@id", id);
            try
            {
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\nA vevő törlése sikertelen!");
                return;
            }
            textBox_Vevo_id.Text = "";
            textBox_Vevo_nev.Text = "";
            textBox_Vevo_cim.Text = "";
            Vevok_tabla_Update();
            MessageBox.Show("Sikeres törlés!");
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            string id = textBox_Vevo_id.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Nincs kiválasztott vevő!");
                return;
            }
            string nev = textBox_Vevo_nev.Text.Trim();
            if (string.IsNullOrEmpty(nev))
            {
                MessageBox.Show("Kérem, adjon meg nevet!");
                textBox_Vevo_nev.Select(0, 0);
                textBox_Vevo_nev.Focus();
                return;
            }
            string cim = textBox_Vevo_cim.Text.Trim();
            if (string.IsNullOrEmpty(cim))
            {
                MessageBox.Show("Kérem, adjon meg címet!");
                textBox_Vevo_cim.Focus();
                textBox_Vevo_cim.Select(0, 0);
                return;
            }
            Program.sql.CommandText = "UPDATE `pvevo` SET `vnev` = @nev, `vcim` = @cim WHERE `pvevo`.`vazon` = @id; ";
            Program.sql.Parameters.Clear();
            Program.sql.Parameters.AddWithValue("@nev", nev);
            Program.sql.Parameters.AddWithValue("@cim", cim);
            Program.sql.Parameters.AddWithValue("@id", id);
            try
            {
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\nA módosítás sikertelen!");
                return;
            }
            textBox_Vevo_id.Text = "";
            textBox_Vevo_nev.Text = "";
            textBox_Vevo_cim.Text = "";
            Vevok_tabla_Update();
            MessageBox.Show("Az adatok módosítása sikeres!");
        }
    }
}
