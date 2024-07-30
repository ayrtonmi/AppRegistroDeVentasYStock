namespace Presentacion
{
    partial class VentasTodas
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
            this.dgvVentasTodas = new System.Windows.Forms.DataGridView();
            this.lblVentasTodas = new System.Windows.Forms.Label();
            this.lblFiltrarVentas = new System.Windows.Forms.Label();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.lblY = new System.Windows.Forms.Label();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnQuitarFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasTodas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentasTodas
            // 
            this.dgvVentasTodas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasTodas.Location = new System.Drawing.Point(12, 46);
            this.dgvVentasTodas.Name = "dgvVentasTodas";
            this.dgvVentasTodas.Size = new System.Drawing.Size(288, 512);
            this.dgvVentasTodas.TabIndex = 0;
            // 
            // lblVentasTodas
            // 
            this.lblVentasTodas.AutoSize = true;
            this.lblVentasTodas.Location = new System.Drawing.Point(12, 27);
            this.lblVentasTodas.Name = "lblVentasTodas";
            this.lblVentasTodas.Size = new System.Drawing.Size(104, 13);
            this.lblVentasTodas.TabIndex = 1;
            this.lblVentasTodas.Text = "LISTA DE VENTAS:";
            // 
            // lblFiltrarVentas
            // 
            this.lblFiltrarVentas.AutoSize = true;
            this.lblFiltrarVentas.Location = new System.Drawing.Point(378, 64);
            this.lblFiltrarVentas.Name = "lblFiltrarVentas";
            this.lblFiltrarVentas.Size = new System.Drawing.Size(88, 13);
            this.lblFiltrarVentas.TabIndex = 2;
            this.lblFiltrarVentas.Text = "Ver ventas entre:";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Location = new System.Drawing.Point(323, 84);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha1.TabIndex = 3;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(416, 111);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(12, 13);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "y";
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Location = new System.Drawing.Point(323, 131);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha2.TabIndex = 5;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(381, 173);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(85, 41);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnQuitarFiltro
            // 
            this.btnQuitarFiltro.Location = new System.Drawing.Point(381, 221);
            this.btnQuitarFiltro.Name = "btnQuitarFiltro";
            this.btnQuitarFiltro.Size = new System.Drawing.Size(85, 23);
            this.btnQuitarFiltro.TabIndex = 7;
            this.btnQuitarFiltro.Text = "Limpiar filtro";
            this.btnQuitarFiltro.UseVisualStyleBackColor = true;
            // 
            // VentasTodas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 614);
            this.Controls.Add(this.btnQuitarFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dtpFecha2);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.dtpFecha1);
            this.Controls.Add(this.lblFiltrarVentas);
            this.Controls.Add(this.lblVentasTodas);
            this.Controls.Add(this.dgvVentasTodas);
            this.Name = "VentasTodas";
            this.Text = "VentasTodas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasTodas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentasTodas;
        private System.Windows.Forms.Label lblVentasTodas;
        private System.Windows.Forms.Label lblFiltrarVentas;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnQuitarFiltro;
    }
}