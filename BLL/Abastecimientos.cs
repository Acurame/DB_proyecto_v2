using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSet1TableAdapters;
using System.Data;

namespace BLL
{

    public class Abastecimientos
    {
        private pedidosTableAdapter tipo_;
        private productosTableAdapter producto_;
        private proveedorTableAdapter proveedor_;
        public Abastecimientos()
        {
            tipo_ = new pedidosTableAdapter();
            producto_ = new productosTableAdapter();
            proveedor_ = new proveedorTableAdapter();
        }

        public DataTable Listado_Abastecimiento()
        {
            return tipo_.Listado_pedidos();
        }

        public DataTable Listo_producto()
        {
            return producto_.Listado_productos();
        }
        public DataTable Listo_proveedor()
        {
            return proveedor_.Listado_proveedores();
        }

        public string Crear_abasto(int proveedor_, int producto_, int desk_ )
        {   
            try
            {
               tipo_.Abastecimineto( proveedor_, producto_, desk_ );
                return "Echo";
            }catch( Exception ex)
            {
                return "ERROR" + ex.Message;
            }
        }
    }
}
