using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRestaurante
{
    public partial class MENUADMIN : Form
    {
        public MENUADMIN()
        {
            InitializeComponent();
        }

        private void MENUADMIN_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            USUARIOS ver = new USUARIOS();
            ver.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            CLIENTES ver = new CLIENTES();
            ver.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            PRODUCTOS ver = new PRODUCTOS();
            ver.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            REPORTES ver = new REPORTES();
            ver.Show();
        }
    }
}
