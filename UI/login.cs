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

namespace UI
{
    public partial class login : Form
    {
        Empleados validacion = new Empleados(); 
        public login()
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

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string permiso;
            permiso = validacion.Validacion_Usuario(Usuario.Text,Clave.Text);

            if (permiso == "Administrador")
            {
                admin Administrador = new admin();
                Administrador.Show();
                this.Hide();
            }
        }
    }
}
