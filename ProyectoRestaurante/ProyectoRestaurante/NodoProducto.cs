using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRestaurante
{
    class NodoProducto
    {
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public double Valor { get; set; }
        public object data { get; set; }
        public NodoProducto liga { get; set; }

        public NodoProducto(string tipo, string nombre, string codigo, double valor)
        {
            Tipo = tipo;
            Nombre = nombre;
            Codigo = codigo;
            Valor = valor;
            liga = null;
        }

        public NodoProducto(object Data)
        {
            data = Data;
            liga = null;
        }
    }
}
