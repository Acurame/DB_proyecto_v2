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
    public partial class Crear_Abasto : Form
    {
        Abastecimientos abasto = new Abastecimientos();
        public Crear_Abasto()
        {
            InitializeComponent();
            Listado_producto();
            Listado_proveedor();
        }
        int x = 0;
        int y = 0;
        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
            else
            {
                Top = Top + (e.Y - y);
                Left = Left + (e.X - x);
            }
        }
        private void Listado_producto()
        {
            comboBox1.DataSource = abasto.Listo_producto();
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idproductos";
            comboBox1.Refresh();
        }
        private void Listado_proveedor()
        {
            comboBox2.DataSource = abasto.Listo_proveedor();
            comboBox2.DisplayMember = "nombre";
            comboBox2.ValueMember = "idproveedor";
            comboBox2.Refresh();
        }

        private void btn_canselar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            int proveedor_ = Convert.ToInt32(comboBox1.SelectedValue);
            int producto_ = Convert.ToInt32(comboBox2.SelectedValue);
            int unidades_ = Convert.ToInt32(textBox1.Text);
            abasto.Crear_abasto(producto_, proveedor_, unidades_);
            this.Close();
        }
    }
}
