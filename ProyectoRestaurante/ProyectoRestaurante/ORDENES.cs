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
    public partial class ORDENES : Form
    {
        NodoOrden nodoorden;
        ListaOrden listaorden;

        String[,] ordenes = new string[10, 4];

        public ORDENES()
        {
            InitializeComponent();

            listaorden = new ListaOrden("ordenes.txt");
            Actualizardgv();
            
            timer1.Enabled = true;
            InitializeTimer();
        }

        public void Actualizardgv()
        {
            ordenes = listaorden.GetLista();

            for (int i = 0; i < ordenes.GetLength(0); i++)
            {
                if(ordenes[i, 5] == "False")
                {
                    dgvCajero1.Rows.Add(ordenes[i, 0], ordenes[i, 1], ordenes[i, 4]);
                }
            }
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MENUGENERAL ver = new MENUGENERAL();
            ver.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            TOMARORDEN ver = new TOMARORDEN();
            ver.ShowDialog();
        }

        private void InitializeTimer()
        {
            timer1.Interval = 1000;  //timer para que el intervalo sea en segundos
            timer1.Tick += new EventHandler(btnActualizar_Click);  //va presionando el boto de actualizar

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)  
        {
            DateTime hora;     //donde la hora de creacion del pedido para ir actualizando los colores
            DateTime ahora = DateTime.Now;

            foreach (DataGridViewRow row in dgvCajero1.Rows)
            {
                row.Selected = true;
            }

            foreach (DataGridViewRow row in dgvCajero1.Rows) //despacho de la orden
            {
                hora = Convert.ToDateTime(row.Cells[2].Value);

                TimeSpan diferencia = ahora.Subtract(hora);
                int segundos = (int)diferencia.TotalSeconds;

                row.Cells[3].Value = segundos;
            }

            foreach (DataGridViewRow row in dgvCajero1.Rows) //actualizar los colores conforme al semaforo
            {
                if(Convert.ToInt64(row.Cells[3].Value) < 300)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;

                }
                else if (Convert.ToInt64(row.Cells[3].Value) >= 300 && Convert.ToInt64(row.Cells[3].Value) < 600)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;

                }
                else if (Convert.ToInt64(row.Cells[3].Value) >= 600)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }

            foreach (DataGridViewRow row in dgvCajero1.Rows)
            {
                row.Selected = false;
            }
        }

        private void labelHora_Click(object sender, EventArgs e)
        {

        }

        private void ORDENES_Load(object sender, EventArgs e)
        {

        }

        private void dgvCajero1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime hora;
            DateTime ahora = DateTime.Now;

            //Actualizardgv("1", "123", ahora);
        }

        private void button3_Click(object sender, EventArgs e)  //para realizar el despacho de la orden
        {
            String mensaje = "";
            string[] campos = new string[6];
            String orden = "";
            int numorden = 0;
            int tiempo = 0;
            double minutos = 0;
            bool entregado = true;

            try
            {
                numorden = Convert.ToInt32(dgvCajero1.CurrentRow.Cells[0].Value);
                tiempo = Convert.ToInt32(dgvCajero1.CurrentRow.Cells[3].Value);
                minutos = tiempo / 60;

                orden = listaorden.Buscar(numorden.ToString());
                campos = orden.Split('|');

                nodoorden = new NodoOrden(numorden, campos[1].ToString(), campos[2].ToString(), double.Parse(campos[3]),
                     DateTime.Parse(campos[4]), entregado, tiempo);

                mensaje = listaorden.ModificarOrden(numorden.ToString(), nodoorden);

                dgvCajero1.Rows.RemoveAt(dgvCajero1.CurrentRow.Index);

                MessageBox.Show("Orden " + numorden + " entregada en " + minutos + " minutos");
            }
            catch
            {

            }
        }
    }
}