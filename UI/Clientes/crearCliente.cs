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
    public partial class crearCliente : Form
    {
        clientes clientes_ = new clientes();
        public crearCliente()
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

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string Nombre = textBox1.Text;
            string Apellidos = textBox2.Text;
            DateTime Nacimineto = dateTimePicker1.Value;
            string Nit = textBox4.Text;
            string Numero = textBox5.Text;
            string direccion = textBox6.Text;

            clientes_.Crear_Clientes(Nombre, Apellidos, Nacimineto, Nit, Numero, direccion);
            this.Close();
        }

        private void btn_canselar_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
