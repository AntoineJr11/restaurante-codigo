using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoRestaurante
{
    class ListaCliente
    {
        public NodoCliente PrimerNodo;
        public NodoCliente UltimoNodo;
        public int ContadorNodos;

        String ArchivoCliente;
        String cadenaCliente;

        public ListaCliente()
        {
            PrimerNodo = null;
            UltimoNodo = null;
            ContadorNodos = 0;
        }

        public ListaCliente(String file)
        {
            PrimerNodo = null;
            UltimoNodo = null;
            ContadorNodos = 0;
            ArchivoCliente = file;
        }

        public bool EsListaVacia()
        {
            return PrimerNodo == null;
        }

        public string AgregarNodoAlFinal(NodoCliente valor)
        {
            NodoCliente nuevoNodo = new NodoCliente(valor.NIT, valor.Nombres, valor.Apellidos, valor.Direccion, valor.Correo);

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
            String[,] cliente = new string[10, 5];
            int n = 0;

            NodoCliente nodoTemporal;

            nodoTemporal = PrimerNodo;

            while (nodoTemporal != null)
            {
                cliente[n, 0] = Convert.ToString(nodoTemporal.NIT);
                cliente[n, 1] = Convert.ToString(nodoTemporal.Nombres);
                cliente[n, 2] = Convert.ToString(nodoTemporal.Apellidos);
                cliente[n, 3] = Convert.ToString(nodoTemporal.Direccion);
                cliente[n, 4] = Convert.ToString(nodoTemporal.Correo);
                n++;
                
                nodoTemporal = nodoTemporal.liga;
            }

            return cliente;
        }

        //Metodos del archivo
        public string GuardarCliente(NodoCliente valor) //Abrir el archivo para guardar la informacion
        {
            using (StreamWriter srFile = new StreamWriter(ArchivoCliente, true))
            {
                srFile.WriteLine($"{valor.NIT}|{valor.Nombres}|{valor.Apellidos}|{valor.Direccion}|{valor.Correo}");
            }

            return "Valor guardado";
        }

        public string Buscar(string nit) //Busqueda del cliente por medio del nit registrado, busqueda en el archivo
        {
            String nombrecliente = "";

            using (StreamReader srFile = new StreamReader(ArchivoCliente, true))
            {
                bool encontrado = false;
                string[] campos = new string[4];
                char[] separador = { '|' };

                cadenaCliente = srFile.ReadLine();

                while (cadenaCliente != null && encontrado == false)
                {
                    campos = cadenaCliente.Split(separador);

                    if (campos[0].Trim().Equals(nit))
                    {
                        nombrecliente = cadenaCliente;
                        encontrado = true;
                    }
                    else
                    {
                        cadenaCliente = srFile.ReadLine();
                    }
                }
            }

            return nombrecliente;
        }

        public string[,] GetLista()  //para generar la lista con la informacion del archivo
        {
            if (!File.Exists(ArchivoCliente))
            {

            }

            ListaCliente lista = new ListaCliente();
            String[,] clientes = new string[10, 5];

            using (StreamReader srFile = new StreamReader(ArchivoCliente))
            {
                string[] clienteRegistro;
                string strRegistro = string.Empty;

                NodoCliente nodo;

                while ((strRegistro = srFile.ReadLine()) != null)
                {
                    clienteRegistro = strRegistro.Split('|');

                    nodo = new NodoCliente(
                        clienteRegistro[0],
                        clienteRegistro[1],
                        clienteRegistro[2],
                        clienteRegistro[3],
                        clienteRegistro[4]
                        );

                    lista.AgregarNodoAlFinal(nodo);
                }
            }
            //return lista;
            clientes = lista.Recorrido();
            return clientes;
        }

        public string EliminarCliente(string nit)
        {
            using (StreamReader srFile = new StreamReader(ArchivoCliente, true))
            {
                bool encontrado = false;
                string[] campos = new string[4];
                char[] separador = { '|' };

                StreamWriter temp = new StreamWriter("temporal.txt", true);

                cadenaCliente = srFile.ReadLine();

                while (cadenaCliente != null)
                {
                    campos = cadenaCliente.Split(separador);

                    if (campos[0].Trim().Equals(nit))
                    {
                        encontrado = true;

                    }
                    else
                    {
                        temp.WriteLine(cadenaCliente);
                    }

                    cadenaCliente = srFile.ReadLine();
                }

                if (encontrado == false)
                {
                    return "Cliente no encontrado";
                }
                else
                {
                    srFile.Close();
                    temp.Close();

                    File.Delete(ArchivoCliente);
                    File.Move("temporal.txt", ArchivoCliente);

                    return "Cliente eliminado";
                }
            }
        }

        public string ModificarCliente(String nit, NodoCliente valor)
        {
            using (StreamReader srFile = new StreamReader(ArchivoCliente, true))
            {
                bool encontrado = false;
                string[] campos = new string[4];
                char[] separador = { '|' };

                StreamWriter temp = new StreamWriter("temporal.txt", true);

                cadenaCliente = srFile.ReadLine();

                while (cadenaCliente != null)
                {
                    campos = cadenaCliente.Split(separador);

                    if (campos[0].Trim().Equals(nit))
                    {
                        temp.WriteLine($"{valor.NIT}|{valor.Nombres}|{valor.Apellidos}|{valor.Direccion}|{valor.Correo}");
                        encontrado = true;
                    }
                    else
                    {
                        temp.WriteLine(cadenaCliente);
                    }

                    cadenaCliente = srFile.ReadLine();
                }

                if (encontrado == false)
                {
                    return "Cliente no encontrado";
                }
                else
                {
                    srFile.Close();
                    temp.Close();

                    File.Delete(ArchivoCliente);
                    File.Move("temporal.txt", ArchivoCliente);

                    return "Cliente modificado";
                }
            }
        }
    }
}
