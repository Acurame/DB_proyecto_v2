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
    public partial class crearTipo : Form
    {
        producto tipo = new producto();
        public crearTipo()
        {
            InitializeComponent();
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

        private void btn_canselar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            tipo.Crear_tipo(nombre);
            this.Close();
        }

        
    }
}
