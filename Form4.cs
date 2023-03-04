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
using System.Drawing.Printing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp;
using System.IO;
using Rectangle = System.Drawing.Rectangle;

namespace ProyectoBDII
{
    public partial class Factura : Form
    {
        private MySqlConnection conexionBD = new MySqlConnection("server=localhost; " + "port=3306; " + "database=ludb; " + " user id=root; " + "password=lu151;");
        public Factura()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string documentocliente = docum.Text.TrimEnd();
            string comandoconsultaclient = "select*from clientes where cedula =" + documentocliente;
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand(comandoconsultaclient, conexionBD);
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                nomu.Text = registro["nombres"].ToString();
                apu.Text = registro["apellidos"].ToString();
                telu.Text = registro["telefono"].ToString();
                regu.Text = registro["regimen"].ToString();
                edu.Text = registro["edad"].ToString();
            }
            else
            {
                MessageBox.Show("No existe un Usuario con ese Numero de Documento ingresado");
            }
            conexionBD.Close();
            int[] numeros = new int[25];
            Random r = new Random();

            int auxiliar = 0;
            int contador = 0;

            for (int i = 0; i < 25; i++)
            {
                auxiliar = r.Next(1, 9999);
                bool continuar = false;

                while (!continuar)
                {
                    for (int j = 0; j <= contador; j++)
                    {
                        if (auxiliar == numeros[j])
                        {
                            continuar = true;
                            j = contador;
                        }
                    }

                    if (continuar)
                    {
                        auxiliar = r.Next(1, 9999);
                        continuar = false;
                    }
                    else
                    {
                        continuar = true;
                        numeros[contador] = auxiliar;
                        contador++;
                    }
                }
            }
            numfactu.Text = auxiliar.ToString();
            DateTime fecha = DateTime.Now;
            fechafactu.Text = fecha.ToString();
        }

        private void numfactu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = fact.Rows.Add();
            string ide = idemedfact.Text.TrimEnd();
            double a=0, b=0;
            double c;
            string comandoconsulta = "select*from medicamentos where id_med = " + ide;
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand(comandoconsulta, conexionBD);
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                fact.Rows[n].Cells[0].Value = registro["id_med"].ToString();
                fact.Rows[n].Cells[1].Value = registro["nombre"].ToString();
                fact.Rows[n].Cells[2].Value = registro["precio"].ToString();
                a = Convert.ToDouble(fact.Rows[n].Cells[2].Value);
            }
            else
            {
                MessageBox.Show(" Hubo un Error En la Consulta, Verifique sus datos ... ");
            }
            conexionBD.Close();
            conexionBD.Open();
            string comandoconsulta2 = "select*from inventario where id_med = " + ide;
            MySqlCommand comando2 = new MySqlCommand(comandoconsulta2, conexionBD);
            MySqlDataReader registro2 = comando2.ExecuteReader();
            try
            {
                if (registro2.Read())
                {
                    
                    string auxiliar = registro2["Cantidad"].ToString();
                    if (((Convert.ToInt32(cantidadfactme.Text)) <= ((Convert.ToInt32(auxiliar)))))
                    {
                        fact.Rows[n].Cells[3].Value = cantidadfactme.Text;
                    }
                    else
                    {
                        MessageBox.Show(" La cantidad que ingreso se excede del inventario ... ");
                    }
                    fact.Rows[n].Cells[4].Value = registro2["fecha_vencimiento"].ToString();
                    b = Convert.ToDouble(fact.Rows[n].Cells[3].Value);
                }
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(" Hubo un Error En la Consulta, Verifique sus datos ... " + Ex.ToString());
            }
            conexionBD.Close();
            idemedfact.Clear();
            cantidadfactme.Clear();
            c = Convert.ToDouble(a * b);
            fact.Rows[n].Cells[5].Value = c;
            double total =0;
            foreach (DataGridViewRow row in fact.Rows)
            {
                total += Convert.ToDouble(row.Cells["Total"].Value);
            }
            totalfact.Text = Convert.ToString(total);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string varidfact = numfactu.Text.TrimEnd();
            string varcedula = docum.Text.TrimEnd();
            string varnombres = nomu.Text.TrimEnd();
            string varapellidos = apu.Text.TrimEnd();
            string vartelefono = telu.Text.TrimEnd();
            string varregimen = regu.Text.TrimEnd();
            string varedad = edu.Text.TrimEnd();
            string varfechfact = fechafactu.Text.TrimEnd();
            string varmedicamento = "";
            string varmedicamentoprecio = "";
            string varmedicamentocantidad = "";
            string varmedicamentototal = "";
            double descuento = 0;
            double descuento2 = 0;
            double totaldescuento =0;
            string ruta ="";
            TextWriter exportar;
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivos De Texto|*.txt";
            guardar.Title = "Guardar";
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                ruta = guardar.FileName;
                exportar = new StreamWriter(ruta);
                exportar.WriteLine("-----------------------------FACTURA DE VENTA -----------------------------");
                exportar.WriteLine("");
                exportar.WriteLine("");
                exportar.WriteLine("----------------INFO DEL CLIENTE----------------------");
                exportar.WriteLine("");
                exportar.WriteLine("-Nombres: " + nomu.Text);
                exportar.WriteLine("-Apellidos: " + apu.Text);
                exportar.WriteLine("-Telefono: " + telu.Text);
                exportar.WriteLine("-Regimen: " + regu.Text);
                exportar.WriteLine("-Edad: " + edu.Text);
                exportar.WriteLine("");
                exportar.WriteLine("---------------INFO DE LA FACTURA--------------------");
                exportar.WriteLine("");
                exportar.WriteLine("-Numero de Factura: " + numfactu.Text);
                exportar.WriteLine("-Fecha Y Hora De Facturacion: " + fechafactu.Text);
                exportar.WriteLine("-Medicamentos: ");
                exportar.WriteLine("");
                for (int i = 0; i < fact.RowCount - 1; i++)
                {
                    for (int j = 0; j < fact.ColumnCount; j++)
                    {
                        exportar.Write(" - "+fact[j, i].Value);
                    }
                    exportar.WriteLine("\n");
                }
                descuento = Convert.ToDouble(totalfact.Text);
                descuento2 = (descuento * 10) / 100;
                totaldescuento = descuento - descuento2;
                exportar.WriteLine("----------------------------------------------");
                exportar.WriteLine("TOTAL DE SU FACTURA: " + totalfact.Text);
                if (regu.Text == "subsidiado")
                {
                    exportar.WriteLine("DESCUENTO: " + descuento2);
                }
                exportar.WriteLine("TOTAL DE SU FACTURA CON EL DESCUENTO: " + totaldescuento);
                exportar.Close();
            }
            guardar.Dispose();
            if (regu.Text == "subsidiado")
            {
                MessageBox.Show("Estimado Cliente Ustéd es acreditador de un descuento del 10% =" + descuento2  + ", sobre el total de su factura por ser subsidiado, el descuento se verá reflejado en su factura...");
            }
            MessageBox.Show(" Su Factura se Generó Exitosamente y se Guardó en la ruta: "+ruta);
            conexionBD.Open();
            try
            {
                foreach (DataGridViewRow row in fact.Rows)
                {
                    varmedicamento = Convert.ToString(row.Cells["Nombre"].Value);
                    varmedicamentoprecio = Convert.ToString(row.Cells["Precio"].Value);
                    varmedicamentocantidad = Convert.ToString(row.Cells["Cantidad"].Value);
                    varmedicamentototal = Convert.ToString(row.Cells["Total"].Value);
                    MySqlCommand comandofact = new MySqlCommand("insert into factura(id_fac,cedula, nombres, apellidos, telefono, regimen, edad,medicamentos,cantidad,precio,total,fecha_factura) values ('"+ varidfact + "','" + varcedula + "','" + varnombres + "','" + varapellidos + "','" + vartelefono + "','" + varregimen + "','" + varedad + "','" +  varmedicamento  + "','" + varmedicamentocantidad + "','" + varmedicamentoprecio  +"','" + varmedicamentototal + "','" + varfechfact  + "')", conexionBD);
                    comandofact.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexionBD.Close();
        }

        private void fact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void docum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Numeros ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void idemedfact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Numeros ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cantidadfactme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Numeros ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
/*
//guardar.Filter = "Archivos PDF|*.pdf";
TextWriter exportar;
exportar = new StreamWriter("C:\\Users\\Lucas\\Desktop\\Factura.txt");
exportar.WriteLine("Total De su Factura: "+totalfact.Text);
exportar.Close();
*/
/*SaveFileDialog guarda = new SaveFileDialog();
guarda.Filter = "Imagen png|*.png";
guarda.ShowDialog();
if (guarda.FileName != "")
{
    Bitmap bm = new Bitmap(fact.Width, fact.Height) ; //863; 668 //fact.Width, fact.Height
    fact.DrawToBitmap(bm, new Rectangle(0, 0, fact.Width, fact.Height)); //public partial class Factura : Form
    FileStream flujo = new FileStream(guarda.FileName, FileMode.Create, FileAccess.Write);
    bm.Save(flujo, System.Drawing.Imaging.ImageFormat.Bmp);
    flujo.Close();
    bm.Dispose();
}*/
