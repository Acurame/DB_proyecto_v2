using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI.Factura
{
    public partial class home : Form
    {
        Facturas facturas_l = new Facturas();
        public home()
        {
            InitializeComponent();
            facturas_();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factura.Crea_Factura crea_Factura = new Factura.Crea_Factura();
            crea_Factura.Show();
        }
        private void facturas_()
        {
            dataGridView1.DataSource = facturas_l.Listado_Facturas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(textBox1.Text);
            facturas_l.EliminarFactura(temp);
        }
    }
}
