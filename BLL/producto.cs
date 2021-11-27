using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.DataSet1TableAdapters;

namespace BLL
{
    public class producto
    {
        private productosTableAdapter productos_;
        private tipoTableAdapter tipo_;

        public producto()
        {
            productos_ = new productosTableAdapter();
            tipo_ = new tipoTableAdapter();
        }

        public DataTable lista_productos()
        {
            return productos_.Listado_productos();
        }
        public DataTable lista_tipo()
        {
            return tipo_.Lista_tipo();
        }
        public string Crear_producto(string _nombre, string _descripcion, string _color, decimal _precio, decimal _descuento, int _stock, int _stockmin, int _tipo)
        {
            string temp = "";
            try
            {
               productos_.crear_producto(_nombre, _descripcion,_color, _precio, _descuento,_stock, _stockmin, _tipo);

            }catch (Exception ex)
            {
                temp = ex.Message;
            }
            return temp;
        }
        public string Crear_tipo(string _nombre)
        {
            string temp = " ";
            try
            {
                tipo_.Crear_tipoProducto(_nombre);
            }catch (Exception ex)
            {
                temp = "ERROR" + ex.Message;
            }
            return temp;
        }
    }
}
