namespace Presentacion
{
    partial class MercaderiaVerTodo
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
            this.dgvMercaderia = new System.Windows.Forms.DataGridView();
            this.btnSinStock = new System.Windows.Forms.Button();
            this.lblMercaderia = new System.Windows.Forms.Label();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cbxBuscarArt = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercaderia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMercaderia
            // 
            this.dgvMercaderia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMercaderia.Location = new System.Drawing.Point(27, 58);
            this.dgvMercaderia.Name = "dgvMercaderia";
            this.dgvMercaderia.Size = new System.Drawing.Size(739, 366);
            this.dgvMercaderia.TabIndex = 0;
            // 
            // btnSinStock
            // 
            this.btnSinStock.Location = new System.Drawing.Point(785, 58);
            this.btnSinStock.Name = "btnSinStock";
            this.btnSinStock.Size = new System.Drawing.Size(172, 64);
            this.btnSinStock.TabIndex = 1;
            this.btnSinStock.Text = "Ver mercadería sin stock";
            this.btnSinStock.UseVisualStyleBackColor = true;
            // 
            // lblMercaderia
            // 
            this.lblMercaderia.AutoSize = true;
            this.lblMercaderia.Location = new System.Drawing.Point(24, 42);
            this.lblMercaderia.Name = "lblMercaderia";
            this.lblMercaderia.Size = new System.Drawing.Size(148, 13);
            this.lblMercaderia.TabIndex = 2;
            this.lblMercaderia.Text = "LISTADO DE MERCADERÍA:";
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(24, 443);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(43, 13);
            this.lblFiltrar.TabIndex = 3;
            this.lblFiltrar.Text = "Buscar:";
            // 
            // cbxBuscarArt
            // 
            this.cbxBuscarArt.FormattingEnabled = true;
            this.cbxBuscarArt.Location = new System.Drawing.Point(73, 440);
            this.cbxBuscarArt.Name = "cbxBuscarArt";
            this.cbxBuscarArt.Size = new System.Drawing.Size(190, 21);
            this.cbxBuscarArt.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(269, 440);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // MercaderiaVerTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 496);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxBuscarArt);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.lblMercaderia);
            this.Controls.Add(this.btnSinStock);
            this.Controls.Add(this.dgvMercaderia);
            this.Name = "MercaderiaVerTodo";
            this.Text = "VerMercaderia";
            this.Load += new System.EventHandler(this.MercaderiaVerTodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercaderia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMercaderia;
        private System.Windows.Forms.Button btnSinStock;
        private System.Windows.Forms.Label lblMercaderia;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cbxBuscarArt;
        private System.Windows.Forms.Button btnBuscar;
    }
}