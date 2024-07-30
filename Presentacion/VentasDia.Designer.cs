namespace Presentacion
{
    partial class VentasDia
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
            this.dgvVentasHoy = new System.Windows.Forms.DataGridView();
            this.lblVentasHoy = new System.Windows.Forms.Label();
            this.calendarVentasHoy = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasHoy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentasHoy
            // 
            this.dgvVentasHoy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasHoy.Location = new System.Drawing.Point(12, 55);
            this.dgvVentasHoy.Name = "dgvVentasHoy";
            this.dgvVentasHoy.Size = new System.Drawing.Size(240, 453);
            this.dgvVentasHoy.TabIndex = 0;
            // 
            // lblVentasHoy
            // 
            this.lblVentasHoy.AutoSize = true;
            this.lblVentasHoy.Location = new System.Drawing.Point(12, 24);
            this.lblVentasHoy.Name = "lblVentasHoy";
            this.lblVentasHoy.Size = new System.Drawing.Size(97, 13);
            this.lblVentasHoy.TabIndex = 1;
            this.lblVentasHoy.Text = "VENTAS DE HOY:";
            // 
            // calendarVentasHoy
            // 
            this.calendarVentasHoy.Location = new System.Drawing.Point(283, 55);
            this.calendarVentasHoy.Name = "calendarVentasHoy";
            this.calendarVentasHoy.TabIndex = 2;
            // 
            // VentasDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 520);
            this.Controls.Add(this.calendarVentasHoy);
            this.Controls.Add(this.lblVentasHoy);
            this.Controls.Add(this.dgvVentasHoy);
            this.Name = "VentasDia";
            this.Text = "VentasDia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasHoy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentasHoy;
        private System.Windows.Forms.Label lblVentasHoy;
        private System.Windows.Forms.MonthCalendar calendarVentasHoy;
    }
}