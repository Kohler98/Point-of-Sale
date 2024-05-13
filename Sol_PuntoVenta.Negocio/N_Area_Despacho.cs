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
            SqlParameter[] SqlParams = new SqlParameter[4];
            SqlParams[0] = new SqlParameter("@nOpcion", SqlDbType.Int);
            SqlParams[0].Value = nOpcion;
            SqlParams[1] = new SqlParameter("@nCodigo", SqlDbType.Int);
            SqlParams[1].Value = oPropiedad.Codigo_ad;
            SqlParams[2] = new SqlParameter("@cDescripcion", SqlDbType.VarChar);
            SqlParams[2].Value = oPropiedad.Descripcion_ad;
            SqlParams[3] = new SqlParameter("@cImpresora", SqlDbType.VarChar);
            SqlParams[3].Value = oPropiedad.Impresora;
            D_Generic Datos = new D_Generic();
            error = "No se pudo guardar el elemento";
            return Datos.Envia_Consulta("USP_Guardar_ad", SqlParams, error);
        }

        public static string Eliminar_ad(int nCodigo)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@nCodigo", SqlDbType.Int);
            SqlParams[0].Value = nCodigo;
            D_Generic Datos = new D_Generic();
            error = "No se pudo eliminar el elemento";
            return Datos.Envia_Consulta("USP_Eliminar_ad", SqlParams, error);
        }
    }
}
