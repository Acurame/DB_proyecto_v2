using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSet1TableAdapters;
using System.Data;

namespace BLL
{
    public class Empleados
    {
        private usuariosTableAdapter Empleado;
        private empleadoTableAdapter EmpleadoAdapter;
        public Empleados()
        {
            Empleado = new usuariosTableAdapter();
            EmpleadoAdapter = new empleadoTableAdapter();
        }
        public string Validacion_Usuario(string _nombre, string _clave)
        {
            string validacion = "";
            try
            {
                DataTable Usuario = Empleado.validacion_usuario(_nombre, _clave);
                if (Usuario != null)
                {
                    if(Usuario.Rows[0]["npermisos"].ToString() == "1")
                    {
                        validacion = "Administrador";
                    }
                    else if(Usuario.Rows[0]["npermisos"].ToString() == "2")
                    {
                        validacion = "Gerente";
                    }
                    else if (Usuario.Rows[0]["npermisos"].ToString() == "3")
                    {
                        validacion = "Resepcion";
                    }
                    else if (Usuario.Rows[0]["npermisos"].ToString() == "4")
                    {
                        validacion = "Bodegero";
                    }
                    else if (Usuario.Rows[0]["npermisos"].ToString() == "5")
                    {
                        validacion = "Inactivo";
                    }
                    else
                    {
                        validacion = "Permiso ERROR";
                    }
                }
            }
            catch (Exception ex)
            {
                validacion = "ERROR" + ex.Message;
            }
            return validacion;
        }
        public string crear_empleado(string _Usuario, string _clave, string _permisos, string _nombre, string _apellidos, string _telefono)
        {
            string empledo = " ";
            try
            {
                Empleado.crearEmpleado(_Usuario, _clave, _permisos, _nombre, _apellidos, _telefono);
            }catch (Exception ex)
            {
                empledo = ex.Message;
            }
            return empledo;
        }
        public DataTable Listado_Empleado_()
        {
            return EmpleadoAdapter.Listado_Empleados_();
        }
    }
}
