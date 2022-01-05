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
    public partial class REPORTES : Form
    {
        ListaOrden reporteOrden;

        String[,] pedidos = new string[50, 7];
        int orden = 1;

        public REPORTES()
        {
            InitializeComponent();

            reporteOrden = new ListaOrden("ordenes.txt");  //leer solamente el archivo de ordenes

        }

        public void ActualizarPed()
        {
            dgvOrdenes.Rows.Clear();

            int tiempo;
            double minutos;
            pedidos = reporteOrden.GetLista();

            for (int i = 0; i < pedidos.GetLength(0); i++)
            {
                tiempo = Convert.ToInt32(pedidos[i, 6]);
                minutos = tiempo / 60;

                dgvOrdenes.Rows.Add(pedidos[i, 0], pedidos[i, 1], pedidos[i, 2],
                                  pedidos[i, 3], pedidos[i, 4], pedidos[i, 5], minutos);

            }

            /*foreach(DataGridViewRow row in dgvOrdenes.Rows)
            {
                if(orden > 3)
                {
                    dgvOrdenes.CurrentRow.Visible = false;
                    orden++;
                }
                else
                {
                    orden++;
                }
            }*/
        }

        private void MayorTiempo()
        {
            dgvOrdenes.Rows.Clear();

            int tiempo;
            double minutos;
            pedidos = reporteOrden.GetLista();

            for (int i = 0; i < pedidos.GetLength(0); i++)
            {
                tiempo = Convert.ToInt32(pedidos[i, 6]);
                minutos = tiempo / 60;

                dgvOrdenes.Rows.Add(pedidos[i, 0], pedidos[i, 1], pedidos[i, 2],
                                  pedidos[i, 3], pedidos[i, 4], pedidos[i, 5], minutos);

                dgvOrdenes.Sort(dgvOrdenesTiempo, ListSortDirection.Descending); 
            }
        }

        private void MenorTiempo()
        {
            dgvOrdenes.Rows.Clear();

            int tiempo;
            double minutos;
            pedidos = reporteOrden.GetLista();

            for (int i = 0; i < pedidos.GetLength(0); i++)
            {
                tiempo = Convert.ToInt32(pedidos[i, 6]);
                minutos = tiempo / 60;

                dgvOrdenes.Rows.Add(pedidos[i, 0], pedidos[i, 1], pedidos[i, 2],
                                  pedidos[i, 3], pedidos[i, 4], pedidos[i, 5], minutos);

                dgvOrdenes.Sort(dgvOrdenesTiempo, ListSortDirection.Ascending);
            }
        }

        private void buttonMOSTRAR_Click(object sender, EventArgs e)
        {
            ActualizarPed();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (INGRESO.user == "admin")
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
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void REPORTES_Load(object sender, EventArgs e)
        {

        }

        private void btnMayorTiempo_Click(object sender, EventArgs e)
        {
            MayorTiempo();
        }

        private void btnMenorTiempo_Click(object sender, EventArgs e)
        {
            MenorTiempo();
        }
    }
}
