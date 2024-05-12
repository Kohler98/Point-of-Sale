using Sol_PuntoVenta.Datos;
using Sol_PuntoVenta.Entidades;
 
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_PuntoVenta.Negocio
{
    public class N_Marcas
    {
        private static string error = "";
        public static DataTable Listado_ma(string cTexto)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@cTexto", SqlDbType.VarChar);
            SqlParams[0].Value = cTexto;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Listado_ma", SqlParams);
        }

        public static string Guardar_ma(int nOpcion, E_Marcas oPropiedad)
        {
            D_Marcas Datos = new D_Marcas();
            return Datos.Guardar_ma(nOpcion, oPropiedad);
        }

        public static string Eliminar_ma(int nCodigo)
        {
            D_Marcas Datos = new D_Marcas();
            return Datos.Eliminar_ma(nCodigo);
        }
    }
}
