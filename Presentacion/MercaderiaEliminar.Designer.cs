namespace Presentacion
{
    partial class MercaderiaEliminar
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
            this.cbxArticulosEliminar = new System.Windows.Forms.ComboBox();
            this.lblArticuloEliminar = new System.Windows.Forms.Label();
            this.btnAceptarEliminar = new System.Windows.Forms.Button();
            this.btnCancelarEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxArticulosEliminar
            // 
            this.cbxArticulosEliminar.FormattingEnabled = true;
            this.cbxArticulosEliminar.Location = new System.Drawing.Point(123, 42);
            this.cbxArticulosEliminar.Name = "cbxArticulosEliminar";
            this.cbxArticulosEliminar.Size = new System.Drawing.Size(156, 21);
            this.cbxArticulosEliminar.TabIndex = 19;
            // 
            // lblArticuloEliminar
            // 
            this.lblArticuloEliminar.AutoSize = true;
            this.lblArticuloEliminar.Location = new System.Drawing.Point(66, 45);
            this.lblArticuloEliminar.Name = "lblArticuloEliminar";
            this.lblArticuloEliminar.Size = new System.Drawing.Size(45, 13);
            this.lblArticuloEliminar.TabIndex = 18;
            this.lblArticuloEliminar.Text = "Articulo:";
            // 
            // btnAceptarEliminar
            // 
            this.btnAceptarEliminar.Location = new System.Drawing.Point(48, 95);
            this.btnAceptarEliminar.Name = "btnAceptarEliminar";
            this.btnAceptarEliminar.Size = new System.Drawing.Size(81, 44);
            this.btnAceptarEliminar.TabIndex = 20;
            this.btnAceptarEliminar.Text = "Eliminar";
            this.btnAceptarEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarEliminar
            // 
            this.btnCancelarEliminar.Location = new System.Drawing.Point(232, 96);
            this.btnCancelarEliminar.Name = "btnCancelarEliminar";
            this.btnCancelarEliminar.Size = new System.Drawing.Size(86, 43);
            this.btnCancelarEliminar.TabIndex = 21;
            this.btnCancelarEliminar.Text = "Cancelar";
            this.btnCancelarEliminar.UseVisualStyleBackColor = true;
            this.btnCancelarEliminar.Click += new System.EventHandler(this.btnCancelarEliminar_Click);
            // 
            // MercaderiaEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 178);
            this.Controls.Add(this.btnCancelarEliminar);
            this.Controls.Add(this.btnAceptarEliminar);
            this.Controls.Add(this.cbxArticulosEliminar);
            this.Controls.Add(this.lblArticuloEliminar);
            this.Name = "MercaderiaEliminar";
            this.Text = "EliminarMercaderia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxArticulosEliminar;
        private System.Windows.Forms.Label lblArticuloEliminar;
        private System.Windows.Forms.Button btnAceptarEliminar;
        private System.Windows.Forms.Button btnCancelarEliminar;
    }
}