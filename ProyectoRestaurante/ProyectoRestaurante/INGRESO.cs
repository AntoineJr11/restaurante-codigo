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
    public partial class INGRESO : Form
    {
        public static string user = "";

        public INGRESO()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string cadena;
            string usuario;
            string contrasena;
            bool encontrado = false;
            string[] campos = new string[16];
            char[] separador = { '|' };

            try
            {

                StreamReader credenciales = new StreamReader("usuarios.txt");

                usuario = txtBoxUsuario.Text;
                user = txtBoxUsuario.Text;
                contrasena = txtBoxPass.Text;               

                cadena = credenciales.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campos = cadena.Split(separador);

                    if (campos[0].Trim() == usuario && campos[1].Trim() == contrasena)
                    {
                        

                        if(user == "admin")
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

                        encontrado = true;
                    }
                    else
                    {
                        cadena = credenciales.ReadLine();
                    }
                }

                if (encontrado == false)
                {
                    MessageBox.Show("CREDENCIAL INVALIDA");
                    txtBoxUsuario.Text = "";
                    txtBoxPass.Text = "";
                    txtBoxUsuario.Focus();
                }

                credenciales.Close();
            }
            catch (FileNotFoundException fe)
            {
                MessageBox.Show("Error" + fe.Message);
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CAMBIAR_PASS ver = new CAMBIAR_PASS();
            ver.Show();
        }
    }
}
