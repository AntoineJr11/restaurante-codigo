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
    public partial class USUARIOS : Form
    {
        NodoUsuario nodousuario;
        ListaUsuario listausuario;

        String tipo, user;
        String[,] usuarios = new string[10, 5];

        public USUARIOS()
        {
            InitializeComponent();

            listausuario = new ListaUsuario("usuarios.txt");

            Actualizardgv();

            txtBoxUsuario.Text = user;
        }

        public void Actualizardgv()
        {
            usuarios = listausuario.GetLista();
      
            for (int i = 0; i < usuarios.GetLength(0); i++)
            {
                dgvUsuarios.Rows.Add(usuarios[i, 0], usuarios[i, 1], usuarios[i, 2],
                                  usuarios[i, 3], usuarios[i, 4]);
            }
        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void USUARIOS_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string mensaje;

            switch (comboBoxTipo.SelectedIndex)
            {
                case 0:
                    tipo = "Cajero";
                    break;

                case 1:
                    tipo = "Despachador";
                    break;
            }

            try
            {
                nodousuario = new NodoUsuario(txtBoxUsuario.Text, txtBoxPass.Text, txtBoxNombre.Text, txtBoxApellidos.Text, tipo);

                mensaje = listausuario.ModificarUsuario(txtBoxUsuario.Text, nodousuario);

                MessageBox.Show(mensaje);

                Actualizardgv();

                txtBoxUsuario.Clear();
                txtBoxPass.Clear();
                txtBoxNombre.Clear();
                txtBoxApellidos.Clear();
                comboBoxTipo.ResetText();

            }

            catch
            {

            }
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxPass.UseSystemPasswordChar == false)
            {
                txtBoxPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtBoxPass.UseSystemPasswordChar = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (string.IsNullOrEmpty(txtBoxNombre.Text) || string.IsNullOrEmpty(txtBoxApellidos.Text) ||
                string.IsNullOrEmpty(txtBoxPass.Text))
            {
                MessageBox.Show("Ingresar todos los valores del campo");
            }

            else
            {

                switch (comboBoxTipo.SelectedIndex)
                {
                    case 0:
                        tipo = "Cajero";
                        user = "caj" + txtBoxNombre.Text[0] + txtBoxApellidos.Text;
                        break;

                    case 1:
                        tipo = "Despachador";
                        user = "desp" + txtBoxNombre.Text[0] + txtBoxApellidos.Text;
                        break;
                }

                nodousuario = new NodoUsuario(user, txtBoxPass.Text, txtBoxNombre.Text, txtBoxApellidos.Text, tipo);

                mensaje = listausuario.GuardarUsuario(nodousuario);

                MessageBox.Show(mensaje);

                Actualizardgv();

                txtBoxUsuario.Clear();
                txtBoxPass.Clear();
                txtBoxNombre.Clear();
                txtBoxApellidos.Clear();
                comboBoxTipo.ResetText();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MENUADMIN ver = new MENUADMIN();
            ver.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtBoxUsuario.Text = Convert.ToString(dgvUsuarios.CurrentRow.Cells[0].Value);
            txtBoxPass.Text = Convert.ToString(dgvUsuarios.CurrentRow.Cells[1].Value);
            txtBoxNombre.Text = Convert.ToString(dgvUsuarios.CurrentRow.Cells[2].Value);
            txtBoxApellidos.Text = Convert.ToString(dgvUsuarios.CurrentRow.Cells[3].Value);
            comboBoxTipo.Text = Convert.ToString(dgvUsuarios.CurrentRow.Cells[4].Value);
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            string mensaje;

            try
            {
                mensaje = listausuario.EliminarUsuario(txtBoxUsuario.Text);

                MessageBox.Show(mensaje);

                Actualizardgv();

                txtBoxUsuario.Clear();
                txtBoxPass.Clear();
                txtBoxNombre.Clear();
                txtBoxApellidos.Clear();
                comboBoxTipo.ResetText();
            }

            catch
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
