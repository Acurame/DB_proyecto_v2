using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        private void OpenForm(object formulario)
        {
            if (this.panelAdmin.Controls.Count > 0)
                this.panelAdmin.Controls.RemoveAt(0);
            Form Formulario_open = formulario as Form;
            Formulario_open.TopLevel = false;
            Formulario_open.Dock = DockStyle.Fill;
            this.panelAdmin.Controls.Add(Formulario_open);
            this.panelAdmin.Tag = Formulario_open;
            Formulario_open.Show();
        }
        
        int x = 0;
        int y = 0;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
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
            OpenForm(new productos.home());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(new Clientes.home());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm(new Empleado.home());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenForm(new Proveedores.home());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenForm(new Contacto.home());
        }
    }
}
