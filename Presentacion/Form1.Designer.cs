﻿namespace Presentacion
{
    partial class Form1
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
            this.listPedido = new System.Windows.Forms.ListView();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preciosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMercaderíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verVentasDeHoyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verVentasDelMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblSubtotal1 = new System.Windows.Forms.Label();
            this.lblSubTotal2 = new System.Windows.Forms.Label();
            this.cbxArticulos = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPedido
            // 
            this.listPedido.HideSelection = false;
            this.listPedido.Location = new System.Drawing.Point(515, 88);
            this.listPedido.Name = "listPedido";
            this.listPedido.Size = new System.Drawing.Size(270, 284);
            this.listPedido.TabIndex = 0;
            this.listPedido.UseCompatibleStateImageBehavior = false;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(25, 91);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(45, 13);
            this.lblArticulo.TabIndex = 2;
            this.lblArticulo.Text = "Articulo:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(30, 149);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(82, 202);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(156, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Location = new System.Drawing.Point(350, 69);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(112, 78);
            this.btnAgregarPedido.TabIndex = 7;
            this.btnAgregarPedido.Text = "Agregar a la compra";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 78);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar venta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(422, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2024, 7, 24, 19, 56, 26, 0);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preciosToolStripMenuItem1,
            this.ventasToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // preciosToolStripMenuItem1
            // 
            this.preciosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.modificarArtículoToolStripMenuItem,
            this.eliminarArtículoToolStripMenuItem,
            this.verMercaderíaToolStripMenuItem});
            this.preciosToolStripMenuItem1.Name = "preciosToolStripMenuItem1";
            this.preciosToolStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.preciosToolStripMenuItem1.Text = "Mercadería";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem.Text = "Agregar";
            // 
            // modificarArtículoToolStripMenuItem
            // 
            this.modificarArtículoToolStripMenuItem.Name = "modificarArtículoToolStripMenuItem";
            this.modificarArtículoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarArtículoToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarArtículoToolStripMenuItem
            // 
            this.eliminarArtículoToolStripMenuItem.Name = "eliminarArtículoToolStripMenuItem";
            this.eliminarArtículoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarArtículoToolStripMenuItem.Text = "Eliminar";
            // 
            // verMercaderíaToolStripMenuItem
            // 
            this.verMercaderíaToolStripMenuItem.Name = "verMercaderíaToolStripMenuItem";
            this.verMercaderíaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verMercaderíaToolStripMenuItem.Text = "Ver mercadería";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verVentasDeHoyToolStripMenuItem,
            this.verVentasDelMesToolStripMenuItem,
            this.verTodasToolStripMenuItem});
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // verVentasDeHoyToolStripMenuItem
            // 
            this.verVentasDeHoyToolStripMenuItem.Name = "verVentasDeHoyToolStripMenuItem";
            this.verVentasDeHoyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verVentasDeHoyToolStripMenuItem.Text = "Ver ventas de hoy";
            // 
            // verVentasDelMesToolStripMenuItem
            // 
            this.verVentasDelMesToolStripMenuItem.Name = "verVentasDelMesToolStripMenuItem";
            this.verVentasDelMesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verVentasDelMesToolStripMenuItem.Text = "Ver ventas del mes";
            // 
            // verTodasToolStripMenuItem
            // 
            this.verTodasToolStripMenuItem.Name = "verTodasToolStripMenuItem";
            this.verTodasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verTodasToolStripMenuItem.Text = "Ver todas las ventas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(350, 294);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 78);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Location = new System.Drawing.Point(515, 69);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(76, 13);
            this.lblCarrito.TabIndex = 12;
            this.lblCarrito.Text = "EN CARRITO:";
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Location = new System.Drawing.Point(791, 209);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(45, 13);
            this.lblTotal1.TabIndex = 13;
            this.lblTotal1.Text = "TOTAL:";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTotal2.Location = new System.Drawing.Point(842, 209);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(10, 13);
            this.lblTotal2.TabIndex = 14;
            this.lblTotal2.Text = " ";
            // 
            // lblSubtotal1
            // 
            this.lblSubtotal1.AutoSize = true;
            this.lblSubtotal1.Location = new System.Drawing.Point(82, 247);
            this.lblSubtotal1.Name = "lblSubtotal1";
            this.lblSubtotal1.Size = new System.Drawing.Size(67, 13);
            this.lblSubtotal1.TabIndex = 15;
            this.lblSubtotal1.Text = "SUBTOTAL:";
            // 
            // lblSubTotal2
            // 
            this.lblSubTotal2.AutoSize = true;
            this.lblSubTotal2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSubTotal2.Location = new System.Drawing.Point(155, 247);
            this.lblSubTotal2.Name = "lblSubTotal2";
            this.lblSubTotal2.Size = new System.Drawing.Size(10, 13);
            this.lblSubTotal2.TabIndex = 16;
            this.lblSubTotal2.Text = " ";
            // 
            // cbxArticulos
            // 
            this.cbxArticulos.FormattingEnabled = true;
            this.cbxArticulos.Location = new System.Drawing.Point(82, 88);
            this.cbxArticulos.Name = "cbxArticulos";
            this.cbxArticulos.Size = new System.Drawing.Size(156, 21);
            this.cbxArticulos.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 513);
            this.Controls.Add(this.cbxArticulos);
            this.Controls.Add(this.lblSubTotal2);
            this.Controls.Add(this.lblSubtotal1);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.lblTotal1);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregarPedido);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.listPedido);
            this.Name = "Form1";
            this.Text = "VENTAS";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listPedido;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.ToolStripMenuItem preciosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verVentasDeHoyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verVentasDelMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMercaderíaToolStripMenuItem;
        private System.Windows.Forms.Label lblSubtotal1;
        private System.Windows.Forms.Label lblSubTotal2;
        private System.Windows.Forms.ComboBox cbxArticulos;
        private System.Windows.Forms.TextBox textBox1;
    }
}

