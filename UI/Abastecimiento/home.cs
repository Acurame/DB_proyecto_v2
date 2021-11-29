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

namespace UI.Abastecimiento
{
    public partial class home : Form
    { 
        Abastecimientos abastecimientos_ = new Abastecimientos();
        public home()
        {
            InitializeComponent();
            Listado_abast();
        }

        private void Listado_abast()
        {
            dataGridView1.DataSource = abastecimientos_.Listado_Abastecimiento();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abastecimiento.Crear_Abasto abasto = new Abastecimiento.Crear_Abasto();
            abasto.Show();
        }
    }
}
