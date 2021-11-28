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
    public partial class crear_contactos : Form
    {
        Proveedor contactos_ = new Proveedor();
        public crear_contactos()
        {
            InitializeComponent();
            proveedor();
        }
        private void proveedor()
        {
            comboBox1.DataSource = contactos_.Lista_Proveedor();
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idproveedor";
            comboBox1.Refresh();
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

        private void btn_canselar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre_ = textBox1.Text;
            string Numero_ = textBox2.Text;
            string Correo_ = textBox3.Text;
            int proveedor_ = Convert.ToInt32(comboBox1.SelectedValue.ToString());

            contactos_.Crear_contactos(Nombre_,Numero_,Correo_,proveedor_);
            this.Close();
            
        }
    }
}
