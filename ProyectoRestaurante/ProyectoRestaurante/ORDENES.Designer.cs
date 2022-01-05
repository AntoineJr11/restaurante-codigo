
namespace ProyectoRestaurante
{
    partial class ORDENES
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ORDENES));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCajero1 = new System.Windows.Forms.DataGridView();
            this.dgvCajero1Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCajero1NIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCajero1Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCajero1Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnDespachar = new System.Windows.Forms.Button();
            this.btnCajero1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 37);
            this.label2.TabIndex = 35;
            this.label2.Text = "STEAK INQUEUE";
            // 
            // dgvCajero1
            // 
            this.dgvCajero1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCajero1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCajero1Numero,
            this.dgvCajero1NIT,
            this.dgvCajero1Hora,
            this.dgvCajero1Tiempo});
            this.dgvCajero1.Location = new System.Drawing.Point(424, 194);
            this.dgvCajero1.Name = "dgvCajero1";
            this.dgvCajero1.RowHeadersWidth = 51;
            this.dgvCajero1.RowTemplate.Height = 24;
            this.dgvCajero1.Size = new System.Drawing.Size(534, 253);
            this.dgvCajero1.TabIndex = 2;
            this.dgvCajero1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCajero1_CellContentClick);
            // 
            // dgvCajero1Numero
            // 
            this.dgvCajero1Numero.HeaderText = "NUMERO DE ORDEN";
            this.dgvCajero1Numero.MinimumWidth = 6;
            this.dgvCajero1Numero.Name = "dgvCajero1Numero";
            this.dgvCajero1Numero.Width = 125;
            // 
            // dgvCajero1NIT
            // 
            this.dgvCajero1NIT.HeaderText = "NIT";
            this.dgvCajero1NIT.MinimumWidth = 6;
            this.dgvCajero1NIT.Name = "dgvCajero1NIT";
            this.dgvCajero1NIT.Width = 125;
            // 
            // dgvCajero1Hora
            // 
            this.dgvCajero1Hora.HeaderText = "HORA";
            this.dgvCajero1Hora.MinimumWidth = 6;
            this.dgvCajero1Hora.Name = "dgvCajero1Hora";
            this.dgvCajero1Hora.Width = 125;
            // 
            // dgvCajero1Tiempo
            // 
            this.dgvCajero1Tiempo.HeaderText = "TIEMPO EN ESPERA";
            this.dgvCajero1Tiempo.MinimumWidth = 6;
            this.dgvCajero1Tiempo.Name = "dgvCajero1Tiempo";
            this.dgvCajero1Tiempo.Width = 125;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(12, 513);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 49);
            this.btnSalir.TabIndex = 5;
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
            this.btnRegresar.Location = new System.Drawing.Point(12, 454);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(101, 49);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "BACK";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnDespachar
            // 
            this.btnDespachar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespachar.Image = ((System.Drawing.Image)(resources.GetObject("btnDespachar.Image")));
            this.btnDespachar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDespachar.Location = new System.Drawing.Point(484, 479);
            this.btnDespachar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDespachar.Name = "btnDespachar";
            this.btnDespachar.Size = new System.Drawing.Size(221, 58);
            this.btnDespachar.TabIndex = 3;
            this.btnDespachar.Text = "      DESPACHAR";
            this.btnDespachar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDespachar.UseVisualStyleBackColor = true;
            this.btnDespachar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCajero1
            // 
            this.btnCajero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajero1.Image = ((System.Drawing.Image)(resources.GetObject("btnCajero1.Image")));
            this.btnCajero1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCajero1.Location = new System.Drawing.Point(474, 103);
            this.btnCajero1.Margin = new System.Windows.Forms.Padding(4);
            this.btnCajero1.Name = "btnCajero1";
            this.btnCajero1.Size = new System.Drawing.Size(151, 58);
            this.btnCajero1.TabIndex = 1;
            this.btnCajero1.Text = "      TOMAR ORDEN";
            this.btnCajero1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCajero1.UseVisualStyleBackColor = true;
            this.btnCajero1.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoRestaurante.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 405);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(12, 7);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(58, 20);
            this.labelHora.TabIndex = 9;
            this.labelHora.Text = "HORA";
            this.labelHora.Click += new System.EventHandler(this.labelHora_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(233, 470);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ORDENES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 574);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnDespachar);
            this.Controls.Add(this.dgvCajero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCajero1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ORDENES";
            this.Text = "ORDENES";
            this.Load += new System.EventHandler(this.ORDENES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCajero1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCajero1;
        private System.Windows.Forms.Button btnDespachar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCajero1Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCajero1NIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCajero1Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCajero1Tiempo;
    }
}