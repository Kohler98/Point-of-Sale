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
    public class N_Area_Despacho
    {
        private static string error = "";
        public static DataTable Listado_ad(string cTexto)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@cTexto", SqlDbType.VarChar);
            SqlParams[0].Value = cTexto;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Listado_ad", SqlParams);
        }

        public static string Guardar_ad(int nOpcion, E_Area_Despacho oPropiedad)
        {
            D_Area_Despacho Datos = new D_Area_Despacho();
            return Datos.Guardar_ad(nOpcion, oPropiedad);
        }

        public static string Eliminar_ad(int nCodigo)
        {
            D_Area_Despacho Datos = new D_Area_Despacho();
            return Datos.Eliminar_ad(nCodigo);
        }
    }
}
