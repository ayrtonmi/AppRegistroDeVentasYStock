namespace Presentacion
{
    partial class AgregarPromo
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
            this.lblArticuloPromo = new System.Windows.Forms.Label();
            this.lblPrecioPromo = new System.Windows.Forms.Label();
            this.lblCantidadPromo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArticuloPromo
            // 
            this.lblArticuloPromo.AutoSize = true;
            this.lblArticuloPromo.Location = new System.Drawing.Point(3, 40);
            this.lblArticuloPromo.Name = "lblArticuloPromo";
            this.lblArticuloPromo.Size = new System.Drawing.Size(92, 13);
            this.lblArticuloPromo.TabIndex = 0;
            this.lblArticuloPromo.Text = "Articulo en promo:";
            // 
            // lblPrecioPromo
            // 
            this.lblPrecioPromo.AutoSize = true;
            this.lblPrecioPromo.Location = new System.Drawing.Point(13, 83);
            this.lblPrecioPromo.Name = "lblPrecioPromo";
            this.lblPrecioPromo.Size = new System.Drawing.Size(82, 13);
            this.lblPrecioPromo.TabIndex = 1;
            this.lblPrecioPromo.Text = "Precio especial:";
            // 
            // lblCantidadPromo
            // 
            this.lblCantidadPromo.AutoSize = true;
            this.lblCantidadPromo.Location = new System.Drawing.Point(43, 125);
            this.lblCantidadPromo.Name = "lblCantidadPromo";
            this.lblCantidadPromo.Size = new System.Drawing.Size(52, 13);
            this.lblCantidadPromo.TabIndex = 2;
            this.lblCantidadPromo.Text = "Cantidad:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(262, 30);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 50);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Agregar a la compra";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(262, 105);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 52);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AgregarPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 178);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCantidadPromo);
            this.Controls.Add(this.lblPrecioPromo);
            this.Controls.Add(this.lblArticuloPromo);
            this.Name = "AgregarPromo";
            this.Text = "AgregarPromo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticuloPromo;
        private System.Windows.Forms.Label lblPrecioPromo;
        private System.Windows.Forms.Label lblCantidadPromo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}