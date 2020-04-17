using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaShopApp.Properties;

namespace PizzaShopApp
{
    public partial class Form_Navigal : Form
    {
        public Form_Navigal()
        {
            InitializeComponent();
        }

        private void button_Rendelés_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_rendeles.ShowDialog();
        }

        private void button_Vevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_vevo.ShowDialog();
        }

        private void button_Futar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_futar.Show();
        }
    }
}
