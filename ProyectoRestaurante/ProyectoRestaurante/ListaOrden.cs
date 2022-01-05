using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoRestaurante
{
    class ListaOrden
    {
        public NodoOrden PrimerNodo;
        public NodoOrden UltimoNodo;
        public int ContadorNodos;

        String ArchivoOrden;
        String cadenaOrden;

        public ListaOrden()
        {
            PrimerNodo = null;
            UltimoNodo = null;
            ContadorNodos = 0;
        }

        public ListaOrden(String file)
        {
            PrimerNodo = null;
            UltimoNodo = null;
            ContadorNodos = 0;
            ArchivoOrden = file;
        }

        public bool EsListaVacia()
        {
            return PrimerNodo == null;
        }

        public string AgregarNodoAlFinal(NodoOrden valor)
        {
            NodoOrden nuevoNodo = new NodoOrden(valor.Numero, valor.NIT, valor.Productos, valor.Total, valor.Fecha, valor.Entregado, valor.Tiempo);

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
            String[,] orden = new string[10, 7];
            int n = 0;

            NodoOrden nodoTemporal;

            nodoTemporal = PrimerNodo;

            while (nodoTemporal != null)
            {
                orden[n, 0] = Convert.ToString(nodoTemporal.Numero);
                orden[n, 1] = Convert.ToString(nodoTemporal.NIT);
                orden[n, 2] = Convert.ToString(nodoTemporal.Productos);
                orden[n, 3] = Convert.ToString(nodoTemporal.Total);
                orden[n, 4] = Convert.ToString(nodoTemporal.Fecha);
                orden[n, 5] = Convert.ToString(nodoTemporal.Entregado);
                orden[n, 6] = Convert.ToString(nodoTemporal.Tiempo);
                n++;

                nodoTemporal = nodoTemporal.liga;
            }

            return orden;
        }

        //Metodos del archivo
        public string GuardarOrden(NodoOrden valor)
        {
            using (StreamWriter srFile = new StreamWriter(ArchivoOrden, true))
            {
                srFile.WriteLine($"{valor.Numero}|{valor.NIT}|{valor.Productos}|{valor.Total}|{valor.Fecha}|{valor.Entregado}|{valor.Tiempo}");
            }

            return "Valor guardado";
        }

        public string Buscar(string numero)
        {
            String nombrecliente = "";

            using (StreamReader srFile = new StreamReader(ArchivoOrden, true))
            {
                bool encontrado = false;
                string[] campos = new string[6];
                char[] separador = { '|' };

                cadenaOrden = srFile.ReadLine();

                while (cadenaOrden != null && encontrado == false)
                {
                    campos = cadenaOrden.Split(separador);

                    if (campos[0].Trim().Equals(numero))
                    {
                        nombrecliente = cadenaOrden;
                        encontrado = true;
                    }
                    else
                    {
                        cadenaOrden = srFile.ReadLine();
                    }
                }
            }
            return nombrecliente;
        }

        public string[,] GetLista()  //busca en el archivo de ordenes y lo va agegando a la lista simple enlazada
        {
            if (!File.Exists(ArchivoOrden))
            {

            }

            ListaOrden lista = new ListaOrden();
            String[,] ordenes = new string[10, 5];

            using (StreamReader srFile = new StreamReader(ArchivoOrden))
            {
                string[] ordenRegistro;
                string strRegistro = string.Empty;

                NodoOrden nodo;

                while ((strRegistro = srFile.ReadLine()) != null)
                {
                    ordenRegistro = strRegistro.Split('|');

                    nodo = new NodoOrden(
                        int.Parse(ordenRegistro[0]),
                        ordenRegistro[1],
                        ordenRegistro[2],
                        double.Parse(ordenRegistro[3]),
                        DateTime.Parse(ordenRegistro[4]),
                        bool.Parse(ordenRegistro[5]),
                        int.Parse(ordenRegistro[6])
                        );

                    lista.AgregarNodoAlFinal(nodo);  //lista simple enlazada
                }
            }
            //return lista;
            ordenes = lista.Recorrido();  //recorrido de la lista
            return ordenes;
        }

        public string EliminarOrdenes(int numero)
        {
            using (StreamReader srFile = new StreamReader(ArchivoOrden, true))
            {
                bool encontrado = false;
                string[] campos = new string[4];
                char[] separador = { '|' };

                StreamWriter temp = new StreamWriter("temporal.txt", true);

                cadenaOrden = srFile.ReadLine();

                while (cadenaOrden != null)
                {
                    campos = cadenaOrden.Split(separador);

                    if (campos[0].Trim().Equals(numero))
                    {
                        encontrado = true;

                    }
                    else
                    {
                        temp.WriteLine(cadenaOrden);
                    }

                    cadenaOrden = srFile.ReadLine();
                }

                if (encontrado == false)
                {
                    return "Orden no encontrado";
                }
                else
                {
                    srFile.Close();
                    temp.Close();

                    File.Delete(ArchivoOrden);
                    File.Move("temporal.txt", ArchivoOrden);

                    return "Cliente eliminado";
                }
            }
        }

        public string ModificarOrden(string numero, NodoOrden valor)
        {
            using (StreamReader srFile = new StreamReader(ArchivoOrden, true))
            {
                bool encontrado = false;
                string[] campos = new string[4];
                char[] separador = { '|' };

                StreamWriter temp = new StreamWriter("temporal.txt", true);

                cadenaOrden = srFile.ReadLine();

                while (cadenaOrden != null)
                {
                    campos = cadenaOrden.Split(separador);

                    if (campos[0].Trim().Equals(numero))
                    {
                        temp.WriteLine($"{valor.Numero}|{valor.NIT}|{valor.Productos}|{valor.Total}|{valor.Fecha}|{valor.Entregado}|{valor.Tiempo}");
                        encontrado = true;
                    }
                    else
                    {
                        temp.WriteLine(cadenaOrden);
                    }

                    cadenaOrden = srFile.ReadLine();
                }

                if (encontrado == false)
                {
                    return "Orden no encontrada";
                }
                else
                {
                    srFile.Close();
                    temp.Close();

                    File.Delete(ArchivoOrden);
                    File.Move("temporal.txt", ArchivoOrden);

                    return "Orden modificada";
                }
            }
        }

        public int GetNumero()  //para obtener el ultimo numero de orden en el archivo de las ordenes
        {
            int codigo = 0; ;

            if (!File.Exists(ArchivoOrden))
            {

            }

            using (StreamReader srFile = new StreamReader(ArchivoOrden))
            {
                string[] campos = new string[6];

                cadenaOrden = srFile.ReadLine();

                while(cadenaOrden != null)
                {
                    campos = cadenaOrden.Split('|');
                    codigo = int.Parse(campos[0]);
                    cadenaOrden = srFile.ReadLine();
                }

            }
            return codigo + 1;
        }
    }
}
