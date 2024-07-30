namespace Presentacion
{
    partial class VentasMes
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
            this.dgvVentasMes = new System.Windows.Forms.DataGridView();
            this.lblVentasMes = new System.Windows.Forms.Label();
            this.cbxVentasMes = new System.Windows.Forms.ComboBox();
            this.calendarMes = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasMes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentasMes
            // 
            this.dgvVentasMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasMes.Location = new System.Drawing.Point(41, 58);
            this.dgvVentasMes.Name = "dgvVentasMes";
            this.dgvVentasMes.Size = new System.Drawing.Size(299, 360);
            this.dgvVentasMes.TabIndex = 0;
            // 
            // lblVentasMes
            // 
            this.lblVentasMes.AutoSize = true;
            this.lblVentasMes.Location = new System.Drawing.Point(42, 30);
            this.lblVentasMes.Name = "lblVentasMes";
            this.lblVentasMes.Size = new System.Drawing.Size(103, 13);
            this.lblVentasMes.TabIndex = 1;
            this.lblVentasMes.Text = "VENTAS DEL MES:";
            // 
            // cbxVentasMes
            // 
            this.cbxVentasMes.FormattingEnabled = true;
            this.cbxVentasMes.Location = new System.Drawing.Point(151, 27);
            this.cbxVentasMes.Name = "cbxVentasMes";
            this.cbxVentasMes.Size = new System.Drawing.Size(156, 21);
            this.cbxVentasMes.TabIndex = 2;
            // 
            // calendarMes
            // 
            this.calendarMes.Location = new System.Drawing.Point(352, 58);
            this.calendarMes.Name = "calendarMes";
            this.calendarMes.TabIndex = 3;
            // 
            // VentasMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.calendarMes);
            this.Controls.Add(this.cbxVentasMes);
            this.Controls.Add(this.lblVentasMes);
            this.Controls.Add(this.dgvVentasMes);
            this.Name = "VentasMes";
            this.Text = "VentasMes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentasMes;
        private System.Windows.Forms.Label lblVentasMes;
        private System.Windows.Forms.ComboBox cbxVentasMes;
        private System.Windows.Forms.MonthCalendar calendarMes;
    }
}