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
    public partial class crearProducto : Form
    {
        producto Crear_Producto = new producto();
        public crearProducto()
        {
            InitializeComponent();
            Lista_tipo();
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
        private void Lista_tipo()
        {
            comboBox1.DataSource = Crear_Producto.lista_tipo();
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idtipo";
            comboBox1.Refresh();
        }

        private void btn_canselar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            string nombre = textBox1.Text;
            string Descripcion = textBox2.Text;
            string Color = textBox3.Text;
            decimal precio = Convert.ToDecimal(textBox4.Text);
            decimal descuento = Convert.ToDecimal(textBox5.Text);
            int stok = Convert.ToInt32(textBox6.Text);
            int stok_min = Convert.ToInt32(textBox6.Text);
            int tipo_producto = Convert.ToInt32(comboBox1.SelectedValue.ToString());

            Crear_Producto.Crear_producto(nombre,Descripcion,Color,precio,descuento,stok,stok_min,tipo_producto);
            this.Close();
        }
    }
}
