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

namespace UI.Clientes
{
    public partial class home : Form
    {
        clientes Clientes_ = new clientes();
        public home()
        {
            InitializeComponent();
            Lista_clientes();
        }

        private void Lista_clientes()
        {
            dataGridView1.DataSource = Clientes_.Listado_Clientes();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes.crearCliente Crear_cliente = new Clientes.crearCliente();
            Crear_cliente.Show();
        }
    }
}
