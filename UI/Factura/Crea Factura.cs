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
namespace UI.Factura
{
    public partial class Crea_Factura : Form
    {
        Facturas Factura_ = new Facturas();
        public Crea_Factura()
        {
            InitializeComponent();
            Lista_productos();
        }

       private void Lista_productos()
        {
            comboBox1.DataSource = Factura_.productos();
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idproductos";
            comboBox1.Refresh();
        }
        int x = 0;
        int y = 0;
        private void panel3_MouseMove(object sender, MouseEventArgs e)
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
            DataTable Facturas_ = Factura_.Cliente(textBox1.Text);
            if (Factura_ != null)
            {
                textBox2.Text = Facturas_.Rows[0]["nombre"].ToString() + " " + Facturas_.Rows[0]["apellidos"].ToString();
                Factura_.fcreate(textBox1.Text);
            }
            else
            {
                Clientes.crearCliente Cliente_crear = new Clientes.crearCliente();
                Cliente_crear.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable Facturas_ = Factura_.Cliente(textBox1.Text);
            if (Factura_ != null)
            {
                int temp = Convert.ToInt32(comboBox1.SelectedValue);
                int temp2 = Convert.ToInt32(textBox3.Text);
                Factura_.fdetalle(temp,temp2);

            }
        }

        private void btn_canselar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
