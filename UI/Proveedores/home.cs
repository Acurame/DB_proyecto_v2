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

namespace UI.Proveedores
{
    public partial class home : Form
    {
        private Proveedor proveedor_ = new Proveedor();
        public home()
        {
            InitializeComponent();
            Lista_proveedor();
        }
        private void Lista_proveedor()
        {
            dataGridView1.DataSource = proveedor_.Lista_Proveedor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedores.crear_proveedor proveedor_ = new Proveedores.crear_proveedor();
            proveedor_.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proveedores.crear_contactos contactos_ = new Proveedores.crear_contactos();
            contactos_.Show();
        }
    }
}
