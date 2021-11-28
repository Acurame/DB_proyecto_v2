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
    public partial class crearEmpleado : Form
    {
        Empleados Empleados_ = new Empleados();
        public crearEmpleado()
        {
            InitializeComponent();
        }
        int x = 0;
        int y = 0;
        private void panel8_MouseUp(object sender, MouseEventArgs e)
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
            string Usuario = textBox1.Text;
            string Clave = textBox2.Text;
            string Permisos = Convert.ToString(1+comboBox1.SelectedIndex);
            string Nombre = textBox3.Text;
            string Apellidos = textBox4.Text; 
            string Telefono = textBox5.Text;

            if (Permisos != "-1")
            {
                Empleados_.crear_empleado(Usuario, Clave, Permisos, Nombre, Apellidos, Telefono);
            }
            this.Close();
        }
    }
}
