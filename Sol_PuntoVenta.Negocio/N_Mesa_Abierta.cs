using Sol_PuntoVenta.Datos;
using Sol_PuntoVenta.Entidades;
using System.Data;
 
namespace Sol_PuntoVenta.Negocio
{
    public class N_Mesa_Abierta
    {
        public static DataTable Listar_SubFamilias_RP(int nCodigo_pv)
        {
            D_Mesa_Abierta Datos = new D_Mesa_Abierta();
            return Datos.Listar_SubFamilias_RP(nCodigo_pv);
        }
        public static DataTable Listar_Productos_Sf_Rp(int nCodigo_pv, int nCodigo_sf)
        {
            D_Mesa_Abierta Datos = new D_Mesa_Abierta();
            return Datos.Listar_Productos_Sf_Rp(nCodigo_pv, nCodigo_sf);
        }
        public static DataTable Busqueda_rapida_pr(string cTexto)
        {
            D_Mesa_Abierta Datos = new D_Mesa_Abierta();
            return Datos.Busqueda_rapida_pr(cTexto);
        }
        public static DataTable Busqueda_cl(string cTexto)
        {
            D_Mesa_Abierta Datos = new D_Mesa_Abierta();
            return Datos.Busqueda_cl(cTexto);
        }
        public static DataTable Guardar_RP(E_Registro_Pedidos oRP, DataTable Detalle_ticket)
        {
            D_Mesa_Abierta Datos = new D_Mesa_Abierta();
            return Datos.Guardar_RP(oRP,Detalle_ticket);
        }
        public static DataTable Imprimir_comanda(int nCodigo_ti, string cImpresora)
        {
            D_Mesa_Abierta Datos = new D_Mesa_Abierta();
            return Datos.Imprimir_comanda(nCodigo_ti, cImpresora);
        }
        public static DataTable Mostrar_Tickets_Mesa(int nCodigo_me)
        {
            D_Mesa_Abierta Datos = new D_Mesa_Abierta();
            return Datos.Mostrar_Tickets_Mesa(nCodigo_me);
        }
        public static DataTable Mostrar_ticket(int nCodigo_ti)
        {
            D_Mesa_Abierta Datos = new D_Mesa_Abierta();
            return Datos.Mostrar_ticket(nCodigo_ti);
        }
        public static DataTable Remprimir_comanda(int nCodigo_ti)
        {
            D_Mesa_Abierta Datos = new D_Mesa_Abierta();
            return Datos.Remprimir_comanda(nCodigo_ti);
        }
        public static DataTable Usuario_Admin(int nCodigo_us)
        {
            D_Mesa_Abierta Datos = new D_Mesa_Abierta();
            return Datos.Usuario_Admin(nCodigo_us);
        }
        public static string Eliminar_Ti(int nCodigo_ti, int nCodigo_me, string cObsanulado_ti)
        {
            D_Mesa_Abierta Datos = new D_Mesa_Abierta();
            return Datos.Eliminar_Ti(nCodigo_ti, nCodigo_me, cObsanulado_ti);
        }
    }
}
