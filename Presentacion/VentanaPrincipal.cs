using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MercaderiaAgregar agregarFrm = new MercaderiaAgregar();
            agregarFrm.ShowDialog();
        }

        private void modificarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MercaderiaAgregar agregarMercaderia = new MercaderiaAgregar();
            agregarMercaderia.ShowDialog();
        }

        private void eliminarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MercaderiaEliminar eliminarMercaderia = new MercaderiaEliminar();
            eliminarMercaderia.ShowDialog();
        }

        private void verMercaderíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MercaderiaVerTodo verTodo = new MercaderiaVerTodo();
            verTodo.ShowDialog();
        }

        private void verVentasDeHoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentasDia venta = new VentasDia();
            venta.ShowDialog();
        }

        private void verVentasDelMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentasMes delMes = new VentasMes();
            delMes.ShowDialog();
        }

        private void verTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentasTodas ventasTodas = new VentasTodas();
            ventasTodas.ShowDialog();
        }

        private void btnPromocion_Click(object sender, EventArgs e)
        {
            AgregarPromo promo = new AgregarPromo();
            promo.ShowDialog();
        }
    }
}
