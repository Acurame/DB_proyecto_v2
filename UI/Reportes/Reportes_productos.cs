using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Reportes
{
    public partial class Reportes_productos : Form
    {
        public Reportes_productos()
        {
            InitializeComponent();
        }

        private void Reportes_productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_ProyectoDataSet1.Listado_Producto' Puede moverla o quitarla según sea necesario.
            this.listado_ProductoTableAdapter.Fill(this.dB_ProyectoDataSet1.Listado_Producto);

            this.reportViewer1.RefreshReport();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
