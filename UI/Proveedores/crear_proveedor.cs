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
    public partial class crear_proveedor : Form
    {
        Proveedor proveedor_ = new Proveedor();
        public crear_proveedor()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre_ = textBox1.Text;
            string Nit_ = textBox2.Text;

            proveedor_.crear_proveedor(Nombre_, Nit_);
            this.Close();
        }
    }
}
