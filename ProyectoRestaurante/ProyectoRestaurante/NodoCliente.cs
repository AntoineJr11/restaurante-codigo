using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRestaurante
{
    class NodoCliente
    {
        public string NIT { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public object data { get; set; }
        public NodoCliente liga { get; set; }

        public NodoCliente(string nit, string nombre, string apellido, string direccion, string correo)
        {
            NIT = nit;
            Nombres = nombre;
            Apellidos = apellido;
            Direccion = direccion;
            Correo = correo;
            liga = null;
        }

        public NodoCliente(object Data)
        {
            data = Data;
            liga = null;
        }
    }
}
