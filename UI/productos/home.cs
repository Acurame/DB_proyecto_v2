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

namespace UI.productos
{
    public partial class home : Form
    {
        producto productos_ = new producto();
        public home()
        {
            InitializeComponent();
            Listado_Productos();
        }

        private void Listado_Productos()
        {
            dataGridView1.DataSource = productos_.lista_productos();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productos.crearProducto crear_producto = new productos.crearProducto();
            crear_producto.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           productos.crearTipo tipo = new productos.crearTipo();
           tipo.Show();
        }
    }
}
