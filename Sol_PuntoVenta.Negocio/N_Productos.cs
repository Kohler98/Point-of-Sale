using Sol_PuntoVenta.Datos;
using Sol_PuntoVenta.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
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
            D_Marcas Datos = new D_Marcas();
            return Datos.Listado_ma(cTexto);
        }
        public static DataTable Listado_um(string cTexto)
        {
            D_Unidades_Medidas Datos = new D_Unidades_Medidas();
            return Datos.Listado_um(cTexto);
        }
        public static DataTable Listado_sf(string cTexto)
        {
            D_SubFamilias Datos = new D_SubFamilias();
            return Datos.Listado_sf(cTexto);
        }
        public static DataTable Listado_ad(string cTexto)
        {
            D_Area_Despacho Datos = new D_Area_Despacho();
            return Datos.Listado_ad(cTexto);
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
