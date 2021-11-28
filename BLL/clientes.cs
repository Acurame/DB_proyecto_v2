using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.DataSet1TableAdapters;

namespace BLL
{
    public class clientes
    {
        private clientesTableAdapter Clientes;
        public clientes()
        {
            Clientes = new clientesTableAdapter();
        }
        public DataTable Listado_Clientes()
        {
            return Clientes.Listado_clientes();
        }
        public string Crear_Clientes(string _nombre, string _apellidos,DateTime _fecha,string _nit,string _numero,string _direccion)
        {
            string Crear_clientes = " ";
            try
            {
                Clientes.crear_clientes(_nombre, _apellidos, _fecha, _nit, _numero, _direccion);
            }catch(Exception ex)
            {
               Crear_clientes  = ex.Message;
            }
            return Crear_clientes;
        }
    }
}
