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
    public partial class CLIENTES : Form
    {
        NodoCliente nodocliente;
        ListaCliente listacliente;

        String[,] clientes = new string[10, 5];

        public CLIENTES()
        {
            InitializeComponent();

            listacliente = new ListaCliente("clientes.txt");

            Actualizardgv();
        }

        public void Actualizardgv()
        {
            clientes = listacliente.GetLista();

            for (int i = 0; i < clientes.GetLength(0); i++)
            {
                dgvClientes.Rows.Add(clientes[i, 0], clientes[i, 1], clientes[i, 2],
                                  clientes[i, 3], clientes[i, 4]);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if(INGRESO.user == "admin")
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (string.IsNullOrEmpty(txtBoxNIT.Text) || string.IsNullOrEmpty(txtBoxNombres.Text) ||
                string.IsNullOrEmpty(txtBoxApellidos.Text))
            {
                MessageBox.Show("Ingresar todos los valores del campo");
            }

            else
            {
                nodocliente = new NodoCliente(txtBoxNIT.Text, txtBoxNombres.Text, txtBoxApellidos.Text, txtBoxDireccion.Text, txtBoxCorreo.Text);

                mensaje = listacliente.GuardarCliente(nodocliente);

                MessageBox.Show(mensaje);

                Actualizardgv();

                txtBoxNIT.Clear();
                txtBoxNombres.Clear();
                txtBoxApellidos.Clear();
                txtBoxDireccion.Clear();
                txtBoxCorreo.Clear();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtBoxNIT.Text = Convert.ToString(dgvClientes.CurrentRow.Cells[0].Value);
            txtBoxNombres.Text = Convert.ToString(dgvClientes.CurrentRow.Cells[1].Value);
            txtBoxApellidos.Text = Convert.ToString(dgvClientes.CurrentRow.Cells[2].Value);
            txtBoxDireccion.Text = Convert.ToString(dgvClientes.CurrentRow.Cells[3].Value);
            txtBoxCorreo.Text = Convert.ToString(dgvClientes.CurrentRow.Cells[4].Value);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje;

            try
            {
                nodocliente = new NodoCliente(txtBoxNIT.Text, txtBoxNombres.Text, txtBoxApellidos.Text, txtBoxDireccion.Text, txtBoxCorreo.Text);

                mensaje = listacliente.ModificarCliente(txtBoxNIT.Text, nodocliente);

                MessageBox.Show(mensaje);

                Actualizardgv();

                txtBoxNIT.Clear();
                txtBoxNombres.Clear();
                txtBoxApellidos.Clear();
                txtBoxDireccion.Clear();
                txtBoxCorreo.Clear();
            }

            catch
            {

            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            string mensaje;

            if(INGRESO.user == "admin")
            {
                try
                {
                    mensaje = listacliente.EliminarCliente(txtBoxNIT.Text);

                    MessageBox.Show(mensaje);

                    Actualizardgv();

                    txtBoxNIT.Clear();
                    txtBoxNombres.Clear();
                    txtBoxApellidos.Clear();
                    txtBoxDireccion.Clear();
                    txtBoxCorreo.Clear();
                }

                catch
                {

                }
            }
            else
            {
                MessageBox.Show("No tiene permiso para borrar clientes");
            }
        }

        private void CLIENTES_Load(object sender, EventArgs e)
        {

        }
    }
}
