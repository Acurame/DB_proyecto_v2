using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSet1TableAdapters;
using System.Data;
using DAL.DataSet1TableAdapters;

namespace BLL
{
    public class contacto
    {
        private contactosTableAdapter Contacto_;
        public contacto()
        {
            Contacto_ = new contactosTableAdapter();
        }

        public DataTable Busqueda_Contacto(int proveedor_)
        {
            return Contacto_.Lista_Contacros_Proveedor(proveedor_);
        }
    }
}
