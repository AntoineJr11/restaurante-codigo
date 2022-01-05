using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoRestaurante
{
    public partial class TOMARORDEN : Form
    {
        ListaProducto listaproducto;
        String tipo = "";
        double totalorden = 0;
        int codigoorden = 0;

        public static string numorden = "";
        public static DateTime hora;

        NodoOrden nodoorden;
        ListaOrden listaorden;

        public TOMARORDEN()
        {
            InitializeComponent();

            listaproducto = new ListaProducto("productos.txt");  //leer archivo de productos
            listaorden = new ListaOrden("ordenes.txt");  // leer archivo de ordenes

            using (StreamReader lector = new StreamReader("productos.txt"))  
            {
                while(lector.Peek() >= 0)
                {
                    comboBoxProducto.Items.Add(lector.ReadLine().Split('|')[2]);
                }
            }

            using (StreamReader lector = new StreamReader("clientes.txt"))  //leer el archivo de clientes
            {
                while (lector.Peek() >= 0)
                {
                    comboBoxClientes.Items.Add(lector.ReadLine().Split('|')[0]);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TOMARORDEN_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            CLIENTES ver = new CLIENTES();
            ver.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            String productos = "";

            if (string.IsNullOrEmpty(comboBoxProducto.Text) || string.IsNullOrEmpty(txtBoxCantidad.Text) ||
                string.IsNullOrEmpty(comboBoxClientes.Text))
            {
                MessageBox.Show("Ingresar todos los valores del campo");
            }
            else
            {
                bool entregado = false;
                hora = DateTime.Now;
                codigoorden = listaorden.GetNumero(); //leer las ordenes generadas para crear el correlativo de la orden

                foreach(DataGridViewRow row in dgvOrden.Rows)
                {
                    productos = productos +","+ row.Cells[1].Value + "," + row.Cells[3].Value + "," + row.Cells[4].Value;
                }

                nodoorden = new NodoOrden(codigoorden, comboBoxClientes.SelectedItem.ToString(), productos, totalorden, hora, entregado, 0);

                mensaje = listaorden.GuardarOrden(nodoorden);  //guardar la nueva orden 

                MessageBox.Show(mensaje + " - Numero de orden: "  + codigoorden);
                this.Hide();
                ORDENES ver = new ORDENES(); //regresar al forms donde esta el monitor de ordenes
                ver.Show();
            }
        }

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e) //para hacer la seleccion de productos del archivo
        {
            String producto = "";
            string[] campos = new string[3];
            char[] separador = { '|' };

            producto = listaproducto.Buscar(comboBoxProducto.SelectedItem.ToString());

            campos = producto.Split(separador);

            txtBoxPrecio.Text = campos[3].Trim();
            tipo = campos[1].Trim();
        }

        private void txtBoxPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e) //seleccion de clientes
        {
            double precio, total, cantidad;

            precio = double.Parse(txtBoxPrecio.Text);
            cantidad = double.Parse(txtBoxCantidad.Text);
            total = precio * cantidad;

            txtBoxTotal.Text = total.ToString();
            totalorden = totalorden + total;
        }

        private void button1_Click(object sender, EventArgs e) //valida que todo los campos vayan llenos 
        {
            if (string.IsNullOrEmpty(comboBoxProducto.Text) || string.IsNullOrEmpty(txtBoxCantidad.Text) ||
                string.IsNullOrEmpty(comboBoxClientes.Text))
            {
                MessageBox.Show("Ingresar todos los valores del campo");
            }
            else
            {
                dgvOrden.Rows.Add(comboBoxClientes.SelectedItem.ToString(), comboBoxProducto.SelectedItem.ToString(), tipo, txtBoxCantidad.Text, txtBoxTotal.Text);
            }            
        }
    }
}
