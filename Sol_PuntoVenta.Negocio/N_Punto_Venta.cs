using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_PuntoVenta.Entidades;
using Sol_PuntoVenta.Datos;

namespace Sol_PuntoVenta.Negocio
{
    public class N_Punto_Venta
    {
        private static string error = "";
        public static DataTable Listado_pv(string cTexto)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@cTexto", SqlDbType.VarChar);
            SqlParams[0].Value = cTexto;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Listado_pv", SqlParams);
        }

        public static string Guardar_pv(int nOpcion, E_Punto_Venta oPropiedad)
        {
            D_Punto_Venta Datos = new D_Punto_Venta();
            return Datos.Guardar_pv(nOpcion, oPropiedad);
        }

        public static string Eliminar_pv(int nCodigo)
        {
            D_Punto_Venta Datos = new D_Punto_Venta();
            return Datos.Eliminar_Pv(nCodigo);
        }
    }
}
