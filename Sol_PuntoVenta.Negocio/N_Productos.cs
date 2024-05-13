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
        private static string error = "";
        public static DataTable Listado_pr(string cTexto)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@cTexto", SqlDbType.VarChar);
            SqlParams[0].Value = cTexto;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Listado_pr", SqlParams);
        }

        public static string Guardar_pr(int nOpcion, E_Productos oPropiedad, DataTable DT)
        {
            SqlParameter[] SqlParams = new SqlParameter[11];
            SqlParams[0] = new SqlParameter("@nOpcion", SqlDbType.Int);
            SqlParams[0].Value = nOpcion;
            SqlParams[1] = new SqlParameter("@nCodigo", SqlDbType.Int);
            SqlParams[1].Value = oPropiedad.Codigo_pr;
            SqlParams[2] = new SqlParameter("@cDescripcion_pr", SqlDbType.VarChar);
            SqlParams[2].Value = oPropiedad.Descripcion_pr;
            SqlParams[3] = new SqlParameter("@nCodigo_ma", SqlDbType.Int);
            SqlParams[3].Value = oPropiedad.Codigo_ma;
            SqlParams[4] = new SqlParameter("@nCodigo_um", SqlDbType.Int);
            SqlParams[4].Value = oPropiedad.Codigo_um;
            SqlParams[5] = new SqlParameter("@nCodigo_sf", SqlDbType.Int);
            SqlParams[5].Value = oPropiedad.Codigo_sf;
            SqlParams[6] = new SqlParameter("@nCodigo_ad", SqlDbType.Int);
            SqlParams[6].Value = oPropiedad.Codigo_ad;
            SqlParams[7] = new SqlParameter("@nPrecio_unitario", SqlDbType.Decimal);
            SqlParams[7].Value = oPropiedad.Precio_unitario;
            SqlParams[8] = new SqlParameter("@cObservacion", SqlDbType.VarChar);
            SqlParams[8].Value = oPropiedad.Observacion;
            SqlParams[9] = new SqlParameter("@oImagen", SqlDbType.Image);
            SqlParams[9].Value = oPropiedad.Imagen;
            SqlParams[10] = new SqlParameter("@Ty_01", SqlDbType.Structured);
            SqlParams[10].Value = DT;
            error = "No se pudo guardar el elemento";
            D_Generic Datos = new D_Generic();
            return Datos.Envia_Consulta("USP_Guardar_pr", SqlParams, error);
        }

        public static string Eliminar_pr(int nCodigo)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@nCodigo", SqlDbType.Int);
            SqlParams[0].Value = nCodigo;
            D_Generic Datos = new D_Generic();
            error = "No se pudo eliminar el elemento";
            return Datos.Envia_Consulta("USP_Eliminar_pr", SqlParams, error);
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
            SqlParameter[] SqlParams = new SqlParameter[2];
            SqlParams[0] = new SqlParameter("@nOpcion", SqlDbType.Int);
            SqlParams[0].Value = nOpcion;
            SqlParams[1] = new SqlParameter("@nCodigo_pr", SqlDbType.Int);
            SqlParams[1].Value = nCodigo_pr;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Puntos_Ventas_Ok", SqlParams);
        }
        
        public static Byte[] Mostrar_img( int nCodigo_pr)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@nCodigo_pr", SqlDbType.Int);
            SqlParams[0].Value = nCodigo_pr;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_imagen("USP_Mostrar_img", SqlParams);
        }
        public static Byte[] Mostrar_img_prod_pred()
        {
            SqlParameter[] SqlParams = null;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_imagen("USP_Mostrar_img_prod_pred", SqlParams);
        }
    }
}
