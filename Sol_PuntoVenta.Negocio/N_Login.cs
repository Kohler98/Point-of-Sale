using Sol_PuntoVenta.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_PuntoVenta.Negocio
{
    public class N_Login
    {
        public static DataTable Acceder_us(string cLogin_us, string cPassword_us)
        {
            D_Login Datos = new D_Login();
            return Datos.Acceder_us(cLogin_us, cPassword_us);
        }
        public static string Registrar_us(string cLogin_us, string cPassword_us, string cNombre_us, int nCodigo_ca, int nCodigo_ro)
        {
            D_Login Datos = new D_Login();
            return Datos.Registrar_us(cLogin_us, cPassword_us, cNombre_us,  nCodigo_ca,  nCodigo_ro);
        }
        public static DataTable Listado_car(string cTexto)
        {
            D_Login Datos = new D_Login();
            return Datos.Listado_car(cTexto);
        }
        public static DataTable Listado_ro(string cTexto)
        {
            D_Login Datos = new D_Login();
            return Datos.Listado_ro(cTexto);
        }
    }
}
