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
    public class N_Familias
    {
        private static string error = "";
        public static DataTable Listado_fa(string cTexto)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@cTexto", SqlDbType.VarChar);
            SqlParams[0].Value = cTexto;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Listado_fa", SqlParams);
        }

        public static string Guardar_fa(int nOpcion, E_Familias oPropiedad)
        {
            D_Familias Datos = new D_Familias();
            return Datos.Guardar_fa(nOpcion, oPropiedad);
        }

        public static string Eliminar_fa(int nCodigo)
        {
            D_Familias Datos = new D_Familias();
            return Datos.Eliminar_fa(nCodigo);
        }
    }
}
