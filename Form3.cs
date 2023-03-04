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
    public partial class FormularioAdministracionMedicamentos : Form
    {
        private MySqlConnection conexionBD = new MySqlConnection("server=localhost; " + "port=3306; " + "database=ludb; " + " user id=root; " + "password=lu151;");
        public FormularioAdministracionMedicamentos()
        {
            InitializeComponent();
        }

        private void Guardar1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está Seguro de querer guardar esta informacion ?", "Agregar a Inventario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            string vid = id1.Text.TrimEnd();
            string vnombremedi = nomed.Text.TrimEnd();
            string vprecio = pre.Text.TrimEnd();
            string vcantidad = canti.Text.TrimEnd();
            string vfechavenci = fevenci.Text.TrimEnd();
            conexionBD.Open();
                try
                {
                    MySqlCommand comando = new MySqlCommand("insert into medicamentos(id_med, nombre,precio) values ('" + vid + "','" + vnombremedi + "','" + vprecio + "')", conexionBD);
                    MySqlCommand comando2 = new MySqlCommand("insert into inventario(id_med, cantidad, fecha_vencimiento) values ('" + vid + "','" + vcantidad + "','" + vfechavenci + "')", conexionBD);
                    comando.ExecuteNonQuery();
                    comando2.ExecuteNonQuery();
                    MessageBox.Show(" ¡Registro Exitoso! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show(" Operación Abortada... ");
            }
            conexionBD.Close();
        }

        private void Nuevo1_Click(object sender, EventArgs e)
        {
            id1.Clear();
            nomed.Clear();
            pre.Clear();
            canti.Clear();
            fevenci.Clear();
        }

        private void Cancelar1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Buscar1_Click(object sender, EventArgs e)
        {
            string identificador1 = id1.Text.TrimEnd();
            string comandoconsulta = "select*from medicamentos where id_med = " + identificador1;
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand(comandoconsulta, conexionBD);
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                id1.Text = registro["id_med"].ToString();
                nomed.Text = registro["nombre"].ToString();
                pre.Text = registro["precio"].ToString();
            }
            else
            {
                MessageBox.Show(" Hubo un Error En la Consulta, Verifique sus datos ... ");
            }
            conexionBD.Close();
            conexionBD.Open();
            string comandoconsulta2 = "select*from inventario where id_med = " + identificador1;
            MySqlCommand comando2 = new MySqlCommand(comandoconsulta2, conexionBD);
            MySqlDataReader registro2 = comando2.ExecuteReader();
            try
            {
                if (registro2.Read())
                {
                    canti.Text = registro2["cantidad"].ToString();
                    fevenci.Text = registro2["fecha_vencimiento"].ToString();
                }
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(" Hubo un Error En la Consulta, Verifique sus datos ... " + Ex.ToString());
            }
            conexionBD.Close();
        }

        private void Eliminar1_Click(object sender, EventArgs e)
        {
            
        }

        private void id1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Numeros ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void pre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Numeros ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void canti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Numeros ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nomed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96 || (e.KeyChar >= 123 && e.KeyChar <= 255)))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Letras ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
