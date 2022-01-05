using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoRestaurante
{
    class ListaUsuario
    {
        public NodoUsuario PrimerNodo;
        public NodoUsuario UltimoNodo;
        public int ContadorNodos;

        String ArchivoUsuario;
        String cadenaUsuario;

        public ListaUsuario()
        {
            PrimerNodo = null;
            UltimoNodo = null;
            ContadorNodos = 0;
        }

        public ListaUsuario(String file)
        {
            PrimerNodo = null;
            UltimoNodo = null;
            ContadorNodos = 0;
            ArchivoUsuario = file;
        }

        public bool EsListaVacia()
        {
            return PrimerNodo == null;
        }

        public string AgregarNodoAlFinal(NodoUsuario valor)
        {
            NodoUsuario nuevoNodo = new NodoUsuario(valor.User, valor.Password, valor.Nombres, valor.Apellidos, valor.Tipo);

            if (EsListaVacia())
            {
                PrimerNodo = nuevoNodo;
            }

            else
            {
                UltimoNodo.liga = nuevoNodo;
                UltimoNodo = nuevoNodo;
            }

            UltimoNodo = nuevoNodo;
            ContadorNodos++;

            return "Nodo agregado al final de la lista!";

        }

        public string[,] Recorrido()
        {
            string nodo = string.Empty;
            String[,] usuario = new string[10, 5];
            int n = 0;

            NodoUsuario nodoTemporal;

            nodoTemporal = PrimerNodo;

            while (nodoTemporal != null)
            {
                usuario[n, 0] = Convert.ToString(nodoTemporal.User);
                usuario[n, 1] = Convert.ToString(nodoTemporal.Password);
                usuario[n, 2] = Convert.ToString(nodoTemporal.Nombres);
                usuario[n, 3] = Convert.ToString(nodoTemporal.Apellidos);
                usuario[n, 4] = Convert.ToString(nodoTemporal.Tipo);
                n++;

                nodoTemporal = nodoTemporal.liga;
            }

            return usuario;
        }

        //Metodos del archivo
        public string GuardarUsuario(NodoUsuario valor)
        {
            using (StreamWriter srFile = new StreamWriter(ArchivoUsuario, true))
            {
                srFile.WriteLine($"{valor.User}|{valor.Password}|{valor.Nombres}|{valor.Apellidos}|{valor.Tipo}");
            }

            return "Valor guardado";
        }

        public string Buscar(string user)
        {
            String nombreusuario = "";

            using (StreamReader srFile = new StreamReader(ArchivoUsuario, true))
            {
                bool encontrado = false;
                string[] campos = new string[4];
                char[] separador = { '|' };

                cadenaUsuario = srFile.ReadLine();

                while (cadenaUsuario != null && encontrado == false)
                {
                    campos = cadenaUsuario.Split(separador);

                    if (campos[0].Trim().Equals(user))
                    {
                        nombreusuario = cadenaUsuario;
                        encontrado = true;
                    }
                    else
                    {
                        cadenaUsuario = srFile.ReadLine();
                    }
                }
            }

            return nombreusuario;
        }

        public string[,] GetLista() //realizar la estructura de la lista
        {
            if (!File.Exists(ArchivoUsuario))
            {

            }

            ListaUsuario lista = new ListaUsuario();
            String[,] usuarios = new string[10, 5];

            using (StreamReader srFile = new StreamReader(ArchivoUsuario))
            {
                string[] usuarioRegistro;
                string strRegistro = string.Empty;

                NodoUsuario nodo;

                while ((strRegistro = srFile.ReadLine()) != null)
                {
                    usuarioRegistro = strRegistro.Split('|');

                    nodo = new NodoUsuario(
                        usuarioRegistro[0],
                        usuarioRegistro[1],
                        usuarioRegistro[2],
                        usuarioRegistro[3],
                        usuarioRegistro[4]
                        );

                    lista.AgregarNodoAlFinal(nodo);
                }
            }
            //return lista;
            usuarios = lista.Recorrido();
            return usuarios;
        }

        public string EliminarUsuario(string nit)
        {
            using (StreamReader srFile = new StreamReader(ArchivoUsuario, true))
            {
                bool encontrado = false;
                string[] campos = new string[4];
                char[] separador = { '|' };

                StreamWriter temp = new StreamWriter("temporal.txt", true);

                cadenaUsuario = srFile.ReadLine();

                while (cadenaUsuario != null)
                {
                    campos = cadenaUsuario.Split(separador);

                    if (campos[0].Trim().Equals(nit))
                    {
                        encontrado = true;

                    }
                    else
                    {
                        temp.WriteLine(cadenaUsuario);
                    }

                    cadenaUsuario = srFile.ReadLine();
                }

                if (encontrado == false)
                {
                    return "Usuario no encontrado";
                }
                else
                {
                    srFile.Close();
                    temp.Close();

                    File.Delete(ArchivoUsuario);
                    File.Move("temporal.txt", ArchivoUsuario);

                    return "Usuario eliminado";
                }
            }
        }

        public string ModificarUsuario(String user, NodoUsuario valor)
        {
            using (StreamReader srFile = new StreamReader(ArchivoUsuario, true))
            {
                bool encontrado = false;
                string[] campos = new string[4];
                char[] separador = { '|' };

                StreamWriter temp = new StreamWriter("temporal.txt", true);

                cadenaUsuario = srFile.ReadLine();

                while (cadenaUsuario != null)
                {
                    campos = cadenaUsuario.Split(separador);

                    if (campos[0].Trim().Equals(user))
                    {
                        temp.WriteLine($"{valor.User}|{valor.Password}|{valor.Nombres}|{valor.Apellidos}|{valor.Tipo}");
                        encontrado = true;
                    }
                    else
                    {
                        temp.WriteLine(cadenaUsuario);
                    }

                    cadenaUsuario = srFile.ReadLine();
                }

                if (encontrado == false)
                {
                    return "Usuario no encontrado";
                }
                else
                {
                    srFile.Close();
                    temp.Close();

                    File.Delete(ArchivoUsuario);
                    File.Move("temporal.txt", ArchivoUsuario);

                    return "Usuario modificado";
                }
            }
        }
    }
}
