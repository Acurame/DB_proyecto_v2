using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSet1TableAdapters;
using System.Data;

namespace BLL
{
    public class Facturas
    {
        private clientesTableAdapter clientes_;
        private productosTableAdapter productos_;
        private fencabezadoTableAdapter fencabezado_;
        private fdetalleTableAdapter fdetalle_;
        private DataTable1TableAdapter DataTable1;
        public Facturas()
        {
            clientes_ = new clientesTableAdapter();
            productos_ = new productosTableAdapter();
            fencabezado_ = new fencabezadoTableAdapter();
            fdetalle_ = new fdetalleTableAdapter();
            DataTable1 = new DataTable1TableAdapter();
        }

        public DataTable Cliente(string nit_)
        {
            return clientes_.Cliente_compra(nit_);
        }
        public DataTable productos()
        {
            return productos_.Listado_productos();
        }
        public string fcreate (string nit_)
        {
            try
            {
                fencabezado_.CrearfacturaEncadesado(nit_);
                return "reado con exito";
            }
            catch (Exception e)
            {
                return "ERROR" + e.Message;
            }
        }
        public string fdetalle (int producto,int cantidad)
        {
            try
            {
                fdetalle_.CrearfacturaDetalle(producto,cantidad);
                return "con exito";
            }catch (Exception e)
            {
                return e.Message;
            }
        }
        public DataTable Listado_Facturas()
        {
            return DataTable1.Listado_Facturas();
        }
        public string EliminarFactura (int numer_)
        {
            try
            {
                fencabezado_.EliminarFactura(numer_);
                return "Exitosamente";
            }catch (Exception e)
            {
                return "ERROR " + e.Message;
            }
        }
    }
}
