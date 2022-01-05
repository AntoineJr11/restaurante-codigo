using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoRestaurante
{
    class ListaProducto
    {
        public NodoProducto PrimerNodo;
        public NodoProducto UltimoNodo;
        public int ContadorNodos;

        String ArchivoProducto;
        String cadenaProducto;

        public ListaProducto()
        {
            PrimerNodo = null;
            UltimoNodo = null;
            ContadorNodos = 0;
        }

        public ListaProducto(String file)
        {
            PrimerNodo = null;
            UltimoNodo = null;
            ContadorNodos = 0;
            ArchivoProducto = file;
        }

        public bool EsListaVacia()
        {
            return PrimerNodo == null;
        }

        public string AgregarNodoAlFinal(NodoProducto valor)
        {
            NodoProducto nuevoNodo = new NodoProducto(valor.Tipo, valor.Nombre, valor.Codigo, valor.Valor);

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
            String[,] producto = new string[10, 5];
            int n = 0;

            NodoProducto nodoTemporal;

            nodoTemporal = PrimerNodo;

            while (nodoTemporal != null)
            {
                producto[n, 0] = Convert.ToString(nodoTemporal.Tipo);
                producto[n, 1] = Convert.ToString(nodoTemporal.Nombre);
                producto[n, 2] = Convert.ToString(nodoTemporal.Codigo);
                producto[n, 3] = Convert.ToString(nodoTemporal.Valor);
                n++;

                nodoTemporal = nodoTemporal.liga;
            }

            return producto;
        }

        //Metodos del archivo
        public string GuardarProducto(NodoProducto valor)
        {
            using (StreamWriter srFile = new StreamWriter(ArchivoProducto, true))
            {
                srFile.WriteLine($"{valor.Tipo}|{valor.Nombre}|{valor.Codigo}|{valor.Valor}");
            }

            return "Valor guardado";
        }

        public string Buscar(string codigo) //la busqueda se realiza por medio del codigo generado del producto
        {
            String nombreproducto = "";

            using (StreamReader srFile = new StreamReader(ArchivoProducto, true))
            {
                bool encontrado = false;
                string[] campos = new string[3];
                char[] separador = { '|' };

                cadenaProducto = srFile.ReadLine();

                while (cadenaProducto != null && encontrado == false)
                {
                    campos = cadenaProducto.Split(separador);

                    if (campos[2].Trim().Equals(codigo))
                    {
                        nombreproducto = cadenaProducto;
                        encontrado = true;
                    }
                    else
                    {
                        cadenaProducto = srFile.ReadLine();
                    }
                }
            }

            return nombreproducto;
        }

        public string[,] GetLista()
        {
            if (!File.Exists(ArchivoProducto))
            {

            }

            ListaProducto lista = new ListaProducto();
            String[,] productos = new string[10, 5];

            using (StreamReader srFile = new StreamReader(ArchivoProducto))
            {
                string[] productoRegistro;
                string strRegistro = string.Empty;

                NodoProducto nodo;

                while ((strRegistro = srFile.ReadLine()) != null)
                {
                    productoRegistro = strRegistro.Split('|');

                    nodo = new NodoProducto(
                        productoRegistro[0],
                        productoRegistro[1],
                        productoRegistro[2],
                        double.Parse(productoRegistro[3])
                        );

                    lista.AgregarNodoAlFinal(nodo);
                }
            }
            //return lista;
            productos = lista.Recorrido();
            return productos;
        }

        public string EliminarProducto(string codigo)
        {
            using (StreamReader srFile = new StreamReader(ArchivoProducto, true))
            {
                bool encontrado = false;
                string[] campos = new string[3];
                char[] separador = { '|' };

                StreamWriter temp = new StreamWriter("temporal.txt", true);

                cadenaProducto = srFile.ReadLine();

                while (cadenaProducto != null)
                {
                    campos = cadenaProducto.Split(separador);

                    if (campos[0].Trim().Equals(codigo))
                    {
                        encontrado = true;

                    }
                    else
                    {
                        temp.WriteLine(cadenaProducto);
                    }

                    cadenaProducto = srFile.ReadLine();
                }

                if (encontrado == false)
                {
                    return "Producto no encontrado";
                }
                else
                {
                    srFile.Close();
                    temp.Close();

                    File.Delete(ArchivoProducto);
                    File.Move("temporal.txt", ArchivoProducto);

                    return "Producto eliminado";
                }
            }
        }

        public string ModificarProducto(String codigo, NodoProducto valor)
        {
            using (StreamReader srFile = new StreamReader(ArchivoProducto, true))
            {
                bool encontrado = false;
                string[] campos = new string[3];
                char[] separador = { '|' };

                StreamWriter temp = new StreamWriter("temporal.txt", true);

                cadenaProducto = srFile.ReadLine();

                while (cadenaProducto != null)
                {
                    campos = cadenaProducto.Split(separador);

                    if (campos[2].Trim().Equals(codigo))
                    {
                        temp.WriteLine($"{valor.Tipo}|{valor.Nombre}|{valor.Codigo}|{valor.Valor}");
                        encontrado = true;
                    }
                    else
                    {
                        temp.WriteLine(cadenaProducto);
                    }

                    cadenaProducto = srFile.ReadLine();
                }

                if (encontrado == false)
                {
                    return "Producto no encontrado";
                }
                else
                {
                    srFile.Close();
                    temp.Close();

                    File.Delete(ArchivoProducto);
                    File.Move("temporal.txt", ArchivoProducto);

                    return "Producto modificado";
                }
            }
        }
    }
}
