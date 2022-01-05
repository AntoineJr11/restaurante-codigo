using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRestaurante
{
    class NodoOrden
    {
        public int Numero { get; set; }
        public string NIT { get; set; }
        public string Productos { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }
        public bool Entregado { get; set; }
        public int Tiempo { get; set; }
        public object data { get; set; }
        public NodoOrden liga { get; set; }

        public NodoOrden(int numero, string nit, string productos, double total,DateTime fecha, bool entregado, int tiempo)
        {
            Numero = numero;
            NIT = nit;
            Productos = productos;
            Total = total;
            Fecha = fecha;
            Entregado = entregado;
            Tiempo = tiempo;
            liga = null;
        }

        public NodoOrden(object Data)
        {
            data = Data;
            liga = null;
        }
    }
}
