using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRestaurante
{
    class NodoUsuario
    {
        public string User { get; set; }
        public string Password { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Tipo { get; set; }
        public object data { get; set; }
        public NodoUsuario liga { get; set; }

        public NodoUsuario(string user, string password, string nombres, string apellidos, string tipo)
        {
            User = user;
            Password = password;
            Nombres = nombres;
            Apellidos = apellidos;
            Tipo = tipo;
            liga = null;
        }

        public NodoUsuario(object Data)
        {
            data = Data;
            liga = null;
        }
    }
}
