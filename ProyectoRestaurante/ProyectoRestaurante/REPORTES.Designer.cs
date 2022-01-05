
namespace ProyectoRestaurante
{
    partial class REPORTES
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REPORTES));
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.dgvOrdenesNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrdenesNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrdenesProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrdenesTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrdenesFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrdenesEntregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrdenesTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonMOSTRAR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnMayorTiempo = new System.Windows.Forms.Button();
            this.btnMenorTiempo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvOrdenesNumero,
            this.dgvOrdenesNIT,
            this.dgvOrdenesProductos,
            this.dgvOrdenesTotal,
            this.dgvOrdenesFecha,
            this.dgvOrdenesEntregado,
            this.dgvOrdenesTiempo});
            this.dgvOrdenes.Location = new System.Drawing.Point(434, 130);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.RowHeadersWidth = 51;
            this.dgvOrdenes.RowTemplate.Height = 24;
            this.dgvOrdenes.Size = new System.Drawing.Size(707, 270);
            this.dgvOrdenes.TabIndex = 0;
            this.dgvOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenes_CellContentClick);
            // 
            // dgvOrdenesNumero
            // 
            this.dgvOrdenesNumero.HeaderText = "NUMERO ORDEN";
            this.dgvOrdenesNumero.MinimumWidth = 6;
            this.dgvOrdenesNumero.Name = "dgvOrdenesNumero";
            this.dgvOrdenesNumero.Width = 125;
            // 
            // dgvOrdenesNIT
            // 
            this.dgvOrdenesNIT.HeaderText = "NIT";
            this.dgvOrdenesNIT.MinimumWidth = 6;
            this.dgvOrdenesNIT.Name = "dgvOrdenesNIT";
            this.dgvOrdenesNIT.Width = 125;
            // 
            // dgvOrdenesProductos
            // 
            this.dgvOrdenesProductos.HeaderText = "PRODUCTO";
            this.dgvOrdenesProductos.MinimumWidth = 6;
            this.dgvOrdenesProductos.Name = "dgvOrdenesProductos";
            this.dgvOrdenesProductos.Width = 125;
            // 
            // dgvOrdenesTotal
            // 
            this.dgvOrdenesTotal.HeaderText = "TOTAL DE LA ORDEN";
            this.dgvOrdenesTotal.MinimumWidth = 6;
            this.dgvOrdenesTotal.Name = "dgvOrdenesTotal";
            this.dgvOrdenesTotal.Width = 125;
            // 
            // dgvOrdenesFecha
            // 
            this.dgvOrdenesFecha.HeaderText = "FECHA";
            this.dgvOrdenesFecha.MinimumWidth = 6;
            this.dgvOrdenesFecha.Name = "dgvOrdenesFecha";
            this.dgvOrdenesFecha.Width = 125;
            // 
            // dgvOrdenesEntregado
            // 
            this.dgvOrdenesEntregado.HeaderText = "ENTREGADO";
            this.dgvOrdenesEntregado.MinimumWidth = 6;
            this.dgvOrdenesEntregado.Name = "dgvOrdenesEntregado";
            this.dgvOrdenesEntregado.Width = 125;
            // 
            // dgvOrdenesTiempo
            // 
            this.dgvOrdenesTiempo.HeaderText = "TIEMPO ENTREGA";
            this.dgvOrdenesTiempo.MinimumWidth = 6;
            this.dgvOrdenesTiempo.Name = "dgvOrdenesTiempo";
            this.dgvOrdenesTiempo.Width = 125;
            // 
            // buttonMOSTRAR
            // 
            this.buttonMOSTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMOSTRAR.Image = ((System.Drawing.Image)(resources.GetObject("buttonMOSTRAR.Image")));
            this.buttonMOSTRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMOSTRAR.Location = new System.Drawing.Point(434, 441);
            this.buttonMOSTRAR.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMOSTRAR.Name = "buttonMOSTRAR";
            this.buttonMOSTRAR.Size = new System.Drawing.Size(246, 53);
            this.buttonMOSTRAR.TabIndex = 2;
            this.buttonMOSTRAR.Text = "REPORTE DE PEDIDOS";
            this.buttonMOSTRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMOSTRAR.UseVisualStyleBackColor = true;
            this.buttonMOSTRAR.Click += new System.EventHandler(this.buttonMOSTRAR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoRestaurante.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 402);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 37);
            this.label2.TabIndex = 36;
            this.label2.Text = "STEAK INQUEUE";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(12, 478);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 49);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(12, 421);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(101, 49);
            this.btnRegresar.TabIndex = 37;
            this.btnRegresar.Text = "BACK";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnMayorTiempo
            // 
            this.btnMayorTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayorTiempo.Image = ((System.Drawing.Image)(resources.GetObject("btnMayorTiempo.Image")));
            this.btnMayorTiempo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMayorTiempo.Location = new System.Drawing.Point(895, 417);
            this.btnMayorTiempo.Margin = new System.Windows.Forms.Padding(4);
            this.btnMayorTiempo.Name = "btnMayorTiempo";
            this.btnMayorTiempo.Size = new System.Drawing.Size(246, 53);
            this.btnMayorTiempo.TabIndex = 39;
            this.btnMayorTiempo.Text = "MAYOR TIEMPO";
            this.btnMayorTiempo.UseVisualStyleBackColor = true;
            this.btnMayorTiempo.Click += new System.EventHandler(this.btnMayorTiempo_Click);
            // 
            // btnMenorTiempo
            // 
            this.btnMenorTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenorTiempo.Image = ((System.Drawing.Image)(resources.GetObject("btnMenorTiempo.Image")));
            this.btnMenorTiempo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenorTiempo.Location = new System.Drawing.Point(895, 482);
            this.btnMenorTiempo.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenorTiempo.Name = "btnMenorTiempo";
            this.btnMenorTiempo.Size = new System.Drawing.Size(246, 53);
            this.btnMenorTiempo.TabIndex = 40;
            this.btnMenorTiempo.Text = "MENOR TIEMPO";
            this.btnMenorTiempo.UseVisualStyleBackColor = true;
            this.btnMenorTiempo.Click += new System.EventHandler(this.btnMenorTiempo_Click);
            // 
            // REPORTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 539);
            this.Controls.Add(this.btnMenorTiempo);
            this.Controls.Add(this.btnMayorTiempo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMOSTRAR);
            this.Controls.Add(this.dgvOrdenes);
            this.Name = "REPORTES";
            this.Text = "REPORTES";
            this.Load += new System.EventHandler(this.REPORTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.Button buttonMOSTRAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrdenesNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrdenesNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrdenesProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrdenesTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrdenesFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrdenesEntregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrdenesTiempo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnMayorTiempo;
        private System.Windows.Forms.Button btnMenorTiempo;
    }
}