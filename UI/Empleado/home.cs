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

namespace UI.Empleado
{
    public partial class home : Form
    {
        Empleados Empleado_ = new Empleados();
        public home()
        {
            InitializeComponent();
            Lista_empleados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado.crearEmpleado Empleado_ = new Empleado.crearEmpleado();
            Empleado_.Show();
        }
        private void Lista_empleados()
        {
            dataGridView1.DataSource = Empleado_.Listado_Empleado_();
            dataGridView1.Refresh();
        }

    }
}
