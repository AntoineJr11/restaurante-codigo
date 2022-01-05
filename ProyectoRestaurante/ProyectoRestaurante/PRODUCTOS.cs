using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRestaurante
{
    public partial class PRODUCTOS : Form
    {
        NodoProducto nodoproducto;
        ListaProducto listaproducto;

        String tipo, codigo;
        String[,] productos = new string[10, 5];

        public PRODUCTOS()
        {
            InitializeComponent();

            listaproducto = new ListaProducto("productos.txt");

            Actualizardgv();

            txtBoxCodigo.Text = codigo;
        }

        public void Actualizardgv()
        {
            productos = listaproducto.GetLista();

            for (int i = 0; i < productos.GetLength(0); i++)
            {
                dgvProductos.Rows.Add(productos[i, 0], productos[i, 1], productos[i, 2],
                                  productos[i, 3]);
            }
        }

        private void PRODUCTOS_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (INGRESO.user == "admin")
            {
                this.Hide();
                MENUADMIN ver = new MENUADMIN();
                ver.Show();
            }
            else
            {
                this.Hide();
                MENUGENERAL ver = new MENUGENERAL();
                ver.Show();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            comboBoxTipo.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[0].Value);
            txtBoxNombre.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[1].Value);
            txtBoxCodigo.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[2].Value);
            txtBoxValor.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[3].Value);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje;

            switch (comboBoxTipo.SelectedIndex)
            {
                case 0:
                    tipo = "Entrada";
                    break;
                case 1:
                    tipo = "Plato fuerte";
                    break;
                case 2:
                    tipo = "Sopas";
                    break;
                case 3:
                    tipo = "Postres";
                    break;
                case 4:
                    tipo = "Bebida natural";
                    break;
                case 5:
                    tipo = "Bebida alcoholica";
                    break;
                case 6:
                    tipo = "Vinos";
                    break;
            }

            try
            {
                nodoproducto = new NodoProducto(tipo, txtBoxNombre.Text, txtBoxCodigo.Text, double.Parse(txtBoxValor.Text));

                mensaje = listaproducto.ModificarProducto(txtBoxCodigo.Text, nodoproducto);

                MessageBox.Show(mensaje);

                Actualizardgv();

                comboBoxTipo.ResetText();
                txtBoxNombre.Clear();
                txtBoxCodigo.Clear();
                txtBoxValor.Clear();
            }

            catch
            {

            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (INGRESO.user == "admin")
            {
                try
                {
                    mensaje = listaproducto.EliminarProducto(txtBoxCodigo.Text);

                    MessageBox.Show(mensaje);

                    Actualizardgv();

                    comboBoxTipo.ResetText();
                    txtBoxNombre.Clear();
                    txtBoxCodigo.Clear();
                    txtBoxValor.Clear();
                }

                catch
                {

                }
            }
            else
            {
                MessageBox.Show("No tiene permiso para borrar productos");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (string.IsNullOrEmpty(txtBoxNombre.Text) || string.IsNullOrEmpty(txtBoxValor.Text))
            {
                MessageBox.Show("Ingresar todos los valores del campo");
            }

            else
            {

                switch (comboBoxTipo.SelectedIndex)
                {
                    case 0:
                        tipo = "Entrada";
                        codigo = "01-" + txtBoxNombre.Text;
                        break;
                    case 1:
                        tipo = "Plato fuerte";
                        codigo = "02-" + txtBoxNombre.Text;
                        break;
                    case 2:
                        tipo = "Sopas";
                        codigo = "03-" + txtBoxNombre.Text;
                        break;
                    case 3:
                        tipo = "Postres";
                        codigo = "11-" + txtBoxNombre.Text;
                        break;
                    case 4:
                        tipo = "Bebida natural";
                        codigo = "21-" + txtBoxNombre.Text;
                        break;
                    case 5:
                        tipo = "Bebida alcoholica";
                        codigo = "22-" + txtBoxNombre.Text;
                        break;
                    case 6:
                        tipo = "Vinos";
                        codigo = "50-" + txtBoxNombre.Text;
                        break;
                }

                nodoproducto = new NodoProducto(tipo, txtBoxNombre.Text, codigo, double.Parse(txtBoxValor.Text));

                mensaje = listaproducto.GuardarProducto(nodoproducto);

                MessageBox.Show(mensaje);

                Actualizardgv();

                comboBoxTipo.ResetText();
                txtBoxNombre.Clear();
                txtBoxCodigo.Clear();
                txtBoxValor.Clear();
            }
        }
    }
}
