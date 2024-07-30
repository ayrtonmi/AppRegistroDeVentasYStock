namespace Presentacion
{
    partial class MercaderiaAgregar
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
            this.cbxArticulos = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblAgregarCantidad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAgregarPrecio = new System.Windows.Forms.Label();
            this.lblAgregarArt = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblAgregarArticulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxArticulos
            // 
            this.cbxArticulos.FormattingEnabled = true;
            this.cbxArticulos.Location = new System.Drawing.Point(92, 66);
            this.cbxArticulos.Name = "cbxArticulos";
            this.cbxArticulos.Size = new System.Drawing.Size(156, 21);
            this.cbxArticulos.TabIndex = 23;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(92, 179);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(156, 20);
            this.txtCantidad.TabIndex = 22;
            // 
            // lblAgregarCantidad
            // 
            this.lblAgregarCantidad.AutoSize = true;
            this.lblAgregarCantidad.Location = new System.Drawing.Point(12, 182);
            this.lblAgregarCantidad.Name = "lblAgregarCantidad";
            this.lblAgregarCantidad.Size = new System.Drawing.Size(74, 13);
            this.lblAgregarCantidad.TabIndex = 21;
            this.lblAgregarCantidad.Text = "Cantidad (Kg):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 20;
            // 
            // lblAgregarPrecio
            // 
            this.lblAgregarPrecio.AutoSize = true;
            this.lblAgregarPrecio.Location = new System.Drawing.Point(19, 126);
            this.lblAgregarPrecio.Name = "lblAgregarPrecio";
            this.lblAgregarPrecio.Size = new System.Drawing.Size(62, 13);
            this.lblAgregarPrecio.TabIndex = 19;
            this.lblAgregarPrecio.Text = "Precio (Kg):";
            // 
            // lblAgregarArt
            // 
            this.lblAgregarArt.AutoSize = true;
            this.lblAgregarArt.Location = new System.Drawing.Point(35, 69);
            this.lblAgregarArt.Name = "lblAgregarArt";
            this.lblAgregarArt.Size = new System.Drawing.Size(45, 13);
            this.lblAgregarArt.TabIndex = 18;
            this.lblAgregarArt.Text = "Articulo:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(31, 242);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 45);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(190, 242);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 45);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblAgregarArticulo
            // 
            this.lblAgregarArticulo.AutoSize = true;
            this.lblAgregarArticulo.Location = new System.Drawing.Point(12, 23);
            this.lblAgregarArticulo.Name = "lblAgregarArticulo";
            this.lblAgregarArticulo.Size = new System.Drawing.Size(120, 13);
            this.lblAgregarArticulo.TabIndex = 26;
            this.lblAgregarArticulo.Text = "AGREGAR ARTÍCULO:";
            // 
            // MercaderiaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 321);
            this.Controls.Add(this.lblAgregarArticulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbxArticulos);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblAgregarCantidad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAgregarPrecio);
            this.Controls.Add(this.lblAgregarArt);
            this.Name = "MercaderiaAgregar";
            this.Text = "AgregarMercaderia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxArticulos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblAgregarCantidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAgregarPrecio;
        private System.Windows.Forms.Label lblAgregarArt;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAgregarArticulo;
    }
}