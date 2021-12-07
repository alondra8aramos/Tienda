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

namespace PoS
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios; SSL mode=none");
           conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("SELECT * from usuarios where numero_de_empleado = '" + txtuser.Text + "' and password = '" + txtpassword.Text + "'");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Bienvenido");
                PuntoDeVenta llamar = new PuntoDeVenta();
                llamar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
            conectar.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
