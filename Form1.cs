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

namespace ProyectoBDII
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
        }

        private void Ingresar_Click_1(object sender, EventArgs e)
        {
            string vusuario = textUsuario.Text.TrimEnd();
            string vcontraseña = textContraseña.Text.TrimEnd();
            string vdatos = "";
            string vConexion = "server=localhost; " + "port=3306;" + " user id=" + vusuario + "; password=" + vcontraseña + "; database=mysql;";
            MySqlConnection conexionMysql = new MySqlConnection(vConexion);
            try
            {
                conexionMysql.Open();
                MySqlDataReader lector = null;
                MySqlCommand comando = new MySqlCommand("show databases", conexionMysql);
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    vdatos += lector.GetString(0) + "\n";
                }
                MessageBox.Show("¡Conexión Establecida Exitosamente!");
                FormularioPrincipal menu = new FormularioPrincipal();
                menu.Show();
                this.Hide();
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(" ¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡Conexión Denegada!!!!!!!!!!!!!!!!!! " + "\n" + "Problemas con la conexión ---------------|" + "\n" +Ex.ToString());
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

