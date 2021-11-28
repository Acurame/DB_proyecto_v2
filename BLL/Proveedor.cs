using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSet1TableAdapters;
using System.Data;


namespace BLL
{
    public class Proveedor
    {
        private proveedorTableAdapter proveedor_;
        private contactosTableAdapter contactos_;
        public Proveedor()
        {
          proveedor_ = new proveedorTableAdapter();
          contactos_ = new contactosTableAdapter();
        }
        public DataTable Lista_Proveedor()
        {
           return proveedor_.Listado_proveedores();
        }
        public string crear_proveedor(string nombre_, string nit_)
        {
            string temp_ = "";
            try
            {
                proveedor_.Crear_proveedor(nombre_,nit_);
            }catch(Exception ex)
            {
                temp_ = "ERROR" + ex.Message;
            }
            return temp_;
        }
        public string Crear_contactos(string nombre_,string numero_,string mail_,int proveedor_)
        {
            string temp_ = " ";
            try
            {
                contactos_.Crear_contacto(nombre_,numero_,mail_,proveedor_);
            }catch(Exception ex)
            {
                temp_ = "ERROR: " + ex;
            }
            return temp_;
        }
    }
}
