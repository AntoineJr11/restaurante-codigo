
namespace ProyectoRestaurante
{
    partial class TOMARORDEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TOMARORDEN));
            this.label21 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.dgvOrden = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvOrdenNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrdenProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrdenTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrdenCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrdenTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(13, 9);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(319, 36);
            this.label21.TabIndex = 176;
            this.label21.Text = "REGISTRO DE ORDENES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 177;
            this.label4.Text = "PRODUCTO:";
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(136, 65);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(263, 24);
            this.comboBoxProducto.TabIndex = 1;
            this.comboBoxProducto.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 179;
            this.label1.Text = "PRECIO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Location = new System.Drawing.Point(512, 65);
            this.txtBoxPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.ReadOnly = true;
            this.txtBoxPrecio.Size = new System.Drawing.Size(263, 22);
            this.txtBoxPrecio.TabIndex = 7;
            this.txtBoxPrecio.TextChanged += new System.EventHandler(this.txtBoxPrecio_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 181;
            this.label2.Text = "CANTIDAD:";
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Location = new System.Drawing.Point(136, 115);
            this.txtBoxCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(263, 22);
            this.txtBoxCantidad.TabIndex = 2;
            // 
            // dgvOrden
            // 
            this.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvOrdenNIT,
            this.dgvOrdenProducto,
            this.dgvOrdenTipo,
            this.dgvOrdenCantidad,
            this.dgvOrdenTotal});
            this.dgvOrden.Location = new System.Drawing.Point(19, 282);
            this.dgvOrden.Name = "dgvOrden";
            this.dgvOrden.RowHeadersWidth = 51;
            this.dgvOrden.RowTemplate.Height = 24;
            this.dgvOrden.Size = new System.Drawing.Size(756, 129);
            this.dgvOrden.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 184;
            this.label3.Text = "NIT:";
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(136, 174);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(263, 24);
            this.comboBoxClientes.TabIndex = 3;
            this.comboBoxClientes.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientes_SelectedIndexChanged);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(512, 174);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(134, 30);
            this.btnCliente.TabIndex = 9;
            this.btnCliente.Text = "Agregar Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(418, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 187;
            this.label5.Text = "TOTAL:";
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Location = new System.Drawing.Point(512, 117);
            this.txtBoxTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.ReadOnly = true;
            this.txtBoxTotal.Size = new System.Drawing.Size(263, 22);
            this.txtBoxTotal.TabIndex = 8;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(602, 451);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(173, 57);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "CONFIRMAR ORDEN";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvOrdenNIT
            // 
            this.dgvOrdenNIT.HeaderText = "NIT";
            this.dgvOrdenNIT.MinimumWidth = 6;
            this.dgvOrdenNIT.Name = "dgvOrdenNIT";
            this.dgvOrdenNIT.Width = 125;
            // 
            // dgvOrdenProducto
            // 
            this.dgvOrdenProducto.HeaderText = "CODIGO";
            this.dgvOrdenProducto.MinimumWidth = 6;
            this.dgvOrdenProducto.Name = "dgvOrdenProducto";
            this.dgvOrdenProducto.Width = 125;
            // 
            // dgvOrdenTipo
            // 
            this.dgvOrdenTipo.HeaderText = "TIPO PRODUCTO";
            this.dgvOrdenTipo.MinimumWidth = 6;
            this.dgvOrdenTipo.Name = "dgvOrdenTipo";
            this.dgvOrdenTipo.Width = 125;
            // 
            // dgvOrdenCantidad
            // 
            this.dgvOrdenCantidad.HeaderText = "CANTIDAD";
            this.dgvOrdenCantidad.MinimumWidth = 6;
            this.dgvOrdenCantidad.Name = "dgvOrdenCantidad";
            this.dgvOrdenCantidad.Width = 125;
            // 
            // dgvOrdenTotal
            // 
            this.dgvOrdenTotal.HeaderText = "TOTAL";
            this.dgvOrdenTotal.MinimumWidth = 6;
            this.dgvOrdenTotal.Name = "dgvOrdenTotal";
            this.dgvOrdenTotal.Width = 125;
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(270, 221);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(129, 32);
            this.btnAgregarP.TabIndex = 4;
            this.btnAgregarP.Text = "Agregar Producto";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.button1_Click);
            // 
            // TOMARORDEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 531);
            this.Controls.Add(this.btnAgregarP);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.comboBoxClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvOrden);
            this.Controls.Add(this.txtBoxCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label21);
            this.Name = "TOMARORDEN";
            this.Text = "TOMARORDEN";
            this.Load += new System.EventHandler(this.TOMARORDEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.DataGridView dgvOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrdenNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrdenProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrdenTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrdenCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrdenTotal;
        private System.Windows.Forms.Button btnAgregarP;
    }
}