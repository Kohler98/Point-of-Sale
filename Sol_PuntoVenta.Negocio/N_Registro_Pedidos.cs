using Sol_PuntoVenta.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_PuntoVenta.Negocio
{
    public class N_Registro_Pedidos
    {
        public static DataTable Listado_pv(string cTexto)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@cTexto", SqlDbType.VarChar);
            SqlParams[0].Value = cTexto;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Listado_pv", SqlParams);
        }
        public static DataTable Estado_turno_pv(int nCodigo_pv)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@nCodigo_pv", SqlDbType.Int);
            SqlParams[0].Value = nCodigo_pv;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Estado_turno_pv", SqlParams);
        }
        public static DataTable Mostrar_me_rp(int nCodigo_pv)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@nCodigo_pv", SqlDbType.Int);
            SqlParams[0].Value = nCodigo_pv;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Mostrar_me_rp", SqlParams);
        }
        public static Byte[] Imagen_estado_me(int nEstado)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@nEstado", SqlDbType.Int);
            SqlParams[0].Value = nEstado;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_imagen("USP_Imagen_estado_me", SqlParams);
        }
    }
}
