
namespace ProyectoRestaurante
{
    partial class CAMBIAR_PASS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAMBIAR_PASS));
            this.btnCambiar = new System.Windows.Forms.Button();
            this.checkBoxPass = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNueva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxAnterior = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxConfirmar = new System.Windows.Forms.TextBox();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCambiar
            // 
            this.btnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.Location = new System.Drawing.Point(508, 465);
            this.btnCambiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(139, 62);
            this.btnCambiar.TabIndex = 6;
            this.btnCambiar.Text = "CAMBIAR CONTRASEÑA";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // checkBoxPass
            // 
            this.checkBoxPass.AutoSize = true;
            this.checkBoxPass.Location = new System.Drawing.Point(703, 391);
            this.checkBoxPass.Name = "checkBoxPass";
            this.checkBoxPass.Size = new System.Drawing.Size(153, 21);
            this.checkBoxPass.TabIndex = 5;
            this.checkBoxPass.Text = "Mostrar contraseña";
            this.checkBoxPass.UseVisualStyleBackColor = true;
            this.checkBoxPass.CheckedChanged += new System.EventHandler(this.checkBoxPass_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 37);
            this.label2.TabIndex = 34;
            this.label2.Text = "STEAK INQUEUE";
            // 
            // txtBoxNueva
            // 
            this.txtBoxNueva.Location = new System.Drawing.Point(656, 268);
            this.txtBoxNueva.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNueva.Name = "txtBoxNueva";
            this.txtBoxNueva.Size = new System.Drawing.Size(237, 22);
            this.txtBoxNueva.TabIndex = 3;
            this.txtBoxNueva.UseSystemPasswordChar = true;
            this.txtBoxNueva.TextChanged += new System.EventHandler(this.txtBoxPass_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nueva";
            // 
            // txtBoxAnterior
            // 
            this.txtBoxAnterior.Location = new System.Drawing.Point(656, 204);
            this.txtBoxAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAnterior.Name = "txtBoxAnterior";
            this.txtBoxAnterior.Size = new System.Drawing.Size(237, 22);
            this.txtBoxAnterior.TabIndex = 2;
            this.txtBoxAnterior.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(420, 197);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(213, 37);
            this.lblUsuario.TabIndex = 32;
            this.lblUsuario.Text = "Anterior";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoRestaurante.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 447);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(736, 466);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(157, 62);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 37);
            this.label3.TabIndex = 36;
            this.label3.Text = "Confirmar";
            // 
            // txtBoxConfirmar
            // 
            this.txtBoxConfirmar.Location = new System.Drawing.Point(656, 342);
            this.txtBoxConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxConfirmar.Name = "txtBoxConfirmar";
            this.txtBoxConfirmar.Size = new System.Drawing.Size(237, 22);
            this.txtBoxConfirmar.TabIndex = 4;
            this.txtBoxConfirmar.UseSystemPasswordChar = true;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Location = new System.Drawing.Point(656, 132);
            this.txtBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(237, 22);
            this.txtBoxUsuario.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 37);
            this.label4.TabIndex = 38;
            this.label4.Text = "Usuario";
            // 
            // CAMBIAR_PASS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 585);
            this.Controls.Add(this.txtBoxUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxConfirmar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.checkBoxPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNueva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxAnterior);
            this.Controls.Add(this.lblUsuario);
            this.Name = "CAMBIAR_PASS";
            this.Text = "CAMBIAR CONTRASEÑA";
            this.Load += new System.EventHandler(this.CAMBIAR_PASS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.CheckBox checkBoxPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNueva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxAnterior;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxConfirmar;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.Label label4;
    }
}