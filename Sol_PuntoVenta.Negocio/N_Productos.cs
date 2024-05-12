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
    public class N_Productos
    {
        public static DataTable Listado_pr(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listado_pr(cTexto);
        }

        public static string Guardar_pr(int nOpcion, E_Productos oPropiedad, DataTable DT)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Guardar_pr(nOpcion, oPropiedad,DT);
        }

        public static string Eliminar_pr(int nCodigo)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Eliminar_pr(nCodigo);
        }
        public static DataTable Listado_ma(string cTexto)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@cTexto", SqlDbType.VarChar);
            SqlParams[0].Value = cTexto;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Listado_ma", SqlParams);
        }
        public static DataTable Listado_um(string cTexto)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@cTexto", SqlDbType.VarChar);
            SqlParams[0].Value = cTexto;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Listado_um", SqlParams);
        }
        public static DataTable Listado_sf(string cTexto)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@cTexto", SqlDbType.VarChar);
            SqlParams[0].Value = cTexto;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Listado_sf", SqlParams);
        }
        public static DataTable Listado_ad(string cTexto)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@cTexto", SqlDbType.VarChar);
            SqlParams[0].Value = cTexto;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Listado_ad", SqlParams);
        }
        public static DataTable Puntos_Ventas_Ok(int nOpcion, int nCodigo_pr)
        {
            D_Productos Datos = new D_Productos();
            return Datos.USP_Puntos_Ventas_Ok(nOpcion,nCodigo_pr);
        }
        
        public static Byte[] Mostrar_img( int nCodigo_pr)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Mostrar_img(nCodigo_pr);
        }
        public static Byte[] Mostrar_img_prod_pred()
        {
            D_Productos Datos = new D_Productos();
            return Datos.Mostrar_img_prod_pred();
        }
    }
}
