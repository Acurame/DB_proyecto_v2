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

namespace UI.Contacto
{
    public partial class home : Form
    {
        Proveedor proveedor_ = new Proveedor();
        contacto Contacto_ = new contacto();
        public home()
        {
            InitializeComponent();
            Listado_Proveedor();
        }

        private void Listado_Proveedor()
        {
            comboBox1.DataSource = proveedor_.Lista_Proveedor();
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idproveedor";
            comboBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Busqueda = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            dataGridView1.DataSource = Contacto_.Busqueda_Contacto(Busqueda);
        }
    }
}
