using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_PuntoVenta.Datos;
using Sol_PuntoVenta.Entidades;

namespace Sol_PuntoVenta.Negocio
{
    public class N_Cierres_Turnos
    {
        private static string error = "";
        public static string Abrir_turno(string cFecha_ct,int nCodigo_pv, int nCodigo_tu)
        {
            SqlParameter[] SqlParams = new SqlParameter[3];
            SqlParams[0] = new SqlParameter("@fFecha_ct", SqlDbType.Date);
            SqlParams[0].Value = cFecha_ct;
            SqlParams[1] = new SqlParameter("@nCodigo_pv", SqlDbType.Int);
            SqlParams[1].Value = nCodigo_pv;
            SqlParams[2] = new SqlParameter("@nCodigo_tu", SqlDbType.Int);
            SqlParams[2].Value = nCodigo_tu;
            D_Generic Datos = new D_Generic();
            error = "No se pudo abrir el turno";
            return Datos.Envia_Consulta("USP_Abrir_turno", SqlParams, error);
        }
        public static string Cerrar_turno(string cFecha_ct, int nCodigo_pv, int nCodigo_tu)
        {
            SqlParameter[] SqlParams = new SqlParameter[3];
            SqlParams[0] = new SqlParameter("@fFecha_ct", SqlDbType.Date);
            SqlParams[0].Value = cFecha_ct;
            SqlParams[1] = new SqlParameter("@nCodigo_pv", SqlDbType.Int);
            SqlParams[1].Value = nCodigo_pv;
            SqlParams[2] = new SqlParameter("@nCodigo_tu", SqlDbType.Int);
            SqlParams[2].Value = nCodigo_tu;
            D_Generic Datos = new D_Generic();
            error = "No se pudo cerrar el turno";
            return Datos.Envia_Consulta("USP_Cerrar_turno", SqlParams, error);
        }
        public static DataTable Listado_pv(string cTexto)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@cTexto", SqlDbType.VarChar);
            SqlParams[0].Value = cTexto;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Listado_pv", SqlParams);
        }
        public static DataTable Estado_gestion_turno_pv(int nCodigo_pv)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@nCodigo_pv", SqlDbType.Int);
            SqlParams[0].Value = nCodigo_pv;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_estado_gestion_turno_pv", SqlParams);
        }
    }
}
