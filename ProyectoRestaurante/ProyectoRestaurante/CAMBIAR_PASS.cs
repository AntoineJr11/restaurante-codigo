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
    public partial class CAMBIAR_PASS : Form
    {

        public CAMBIAR_PASS()
        {
            InitializeComponent();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxAnterior.UseSystemPasswordChar == false && txtBoxNueva.UseSystemPasswordChar == false &&
                txtBoxConfirmar.UseSystemPasswordChar == false)
            {
                txtBoxAnterior.UseSystemPasswordChar = true;
                txtBoxNueva.UseSystemPasswordChar = true;
                txtBoxConfirmar.UseSystemPasswordChar = true;
            }
            else
            {
                txtBoxAnterior.UseSystemPasswordChar = false;
                txtBoxNueva.UseSystemPasswordChar = false;
                txtBoxConfirmar.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            INGRESO ver = new INGRESO();
            ver.Show();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, usuario, vieja, nueva, confirmar;
            bool encontrado = false;
            string[] campos = new string[17];
            char[] separador = { '|' };

            try
            {
                lectura = File.OpenText("usuarios.txt");

                usuario = txtBoxUsuario.Text;
                vieja = txtBoxAnterior.Text;
                nueva = txtBoxNueva.Text;
                confirmar = txtBoxConfirmar.Text;
                cadena = lectura.ReadLine();

                if (nueva != confirmar)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    txtBoxNueva.Clear();
                    txtBoxConfirmar.Clear();
                    this.Hide();
                    INGRESO ver = new INGRESO();
                    ver.Show();
                }
                else
                {                    
                    escribir = File.CreateText("temporal.txt");

                    while (cadena != null)
                    {
                        campos = cadena.Split(separador);
                        if (campos[0].Trim().Equals(usuario) && campos[1].Trim().Equals(vieja))
                        {
                            encontrado = true;
                            escribir.WriteLine(string.Format("{0}|{1}|{2}|{3}|{4}", campos[0], nueva, campos[2], campos[3], campos[4]));

                            MessageBox.Show("Contraseña Cambiada");
                        }
                        else
                        {
                            escribir.WriteLine(cadena);
                        }

                        cadena = lectura.ReadLine();
                    }

                    if (encontrado == false)
                    {
                        MessageBox.Show("Contraseña Invalida");
                    }


                    lectura.Close();
                    escribir.Close();

                    File.Delete("usuarios.txt");
                    File.Move("temporal.txt",
                        "usuarios.txt");
                }
            }

            catch (FileNotFoundException fe)
            {
                MessageBox.Show("Error" + fe.Message);
            }
        }

        private void CAMBIAR_PASS_Load(object sender, EventArgs e)
        {

        }
    }
}
